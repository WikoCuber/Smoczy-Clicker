using System.Runtime.InteropServices;

namespace SC_Scripts.Scripts_Helpers
{
    public partial class ScriptsUtilities
    {
        #region Imports DLLs
        [DllImport("user32.dll")]
        private static extern int PostMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.dll")]
        internal static extern bool LockSetForegroundWindow(UInt32 code);
        [DllImport("user32.dll")]
        internal static extern bool SetForegroundWindow(IntPtr handle);
        [DllImport("user32")]
        internal static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")]
        internal static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        [DllImport("user32.dll")]
        internal static extern void SwitchToThisWindow(IntPtr hWnd, bool fAltTab);
        #endregion

        public bool IsBackground { get; set; } = false; //Whether key should be clicked in background 
        public IntPtr BackgorundWindow { get; set; } //Window handle for background
        public List<Keys> KeysDownScripts { get; set; } = []; //To release keys after script stop
        public int DelayBetweenAnyOperation { get; set; } = 0; //Delay after MouseMove, SendMouseButton, SendKey

        private readonly CancellationTokenSource tokenSource;
        private readonly CancellationToken token;

        public ScriptsUtilities()
        {
            tokenSource = new();
            token = tokenSource.Token;
        }

        public void Cancel() => tokenSource.Cancel();

        private static int MakeLParam(int x, int y) => (y << 16) | (x & 0xFFFF);
    }
}
