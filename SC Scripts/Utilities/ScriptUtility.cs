using SC_Data;
using SC_Scripts.Helpers;
using SC_Scripts.Scripts_Managment;
using SC_Scripts.Timer;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace SC_Scripts.Utilities
{
    public class ScriptUtility
    {
        #region DLLs Imports
        [DllImport("user32.dll")]
        internal static extern bool LockSetForegroundWindow(int code);
        [DllImport("user32.dll")]
        internal static extern bool SetForegroundWindow(IntPtr handle);
        [DllImport("user32")]
        internal static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")]
        internal static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        [DllImport("user32.dll")]
        internal static extern void SwitchToThisWindow(IntPtr hWnd, bool fAltTab);
        [DllImport("user32.dll")]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
        [DllImport("user32.dll")]
        private static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);
        [DllImport("user32.dll")]
        private static extern int PostMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        public bool IsBackground { get; set; } //Whether key should be clicked in background 
        public IntPtr BackgorundWindow { get; set; } //Window handle for background
        public int DelayBetweenAnyOperation { get; set; } //Delay after MouseMove, SendMouseButton, SendKey

        private readonly List<Keys> keysInDown = []; //To release keys after script stop
        private readonly CancellationTokenSource tokenSource;
        private readonly CancellationToken token;

        public ScriptUtility()
        {
            tokenSource = new();
            token = tokenSource.Token;
        }

        public void Cancel()
        {
            tokenSource.Cancel();

            lock (keysInDown)
            {
                //Relese keys
                foreach (var key in keysInDown)
                {
                    ScriptUtility su = new(); //This ScriptUtility is canceled
                    if (ConvertHelper.KeysToMouseButtons(key) != MouseButtons.None) //For mouse buttons
                        su.HoldMouseButton(ConvertHelper.KeysToMouseButtons(key), false);
                    else
                        su.HoldKey(key, false);
                }
            }
        }

        public void MouseMove(int x, int y)
        {
            token.ThrowIfCancellationRequested(); //Stop script

            //Moving in background is imposible
            if (!IsBackground)
                Cursor.Position = new Point(x, y);

            Sleep(DelayBetweenAnyOperation);
        }

        public void HoldMouseButton(MouseButtons button, bool isHold)
        {
            token.ThrowIfCancellationRequested(); //Stop script

            lock (keysInDown)
            {
                if (isHold)
                    keysInDown.Add(ConvertHelper.MouseButtonsToKeys(button));
                else
                    keysInDown.Remove(ConvertHelper.MouseButtonsToKeys(button));
            }

            int msg = ConvertHelper.MouseButtonToMsg(button, isHold, IsBackground);

            if (IsBackground)
            {
                int xButtonInfo = button switch
                {
                    MouseButtons.XButton1 => 0x0020,
                    MouseButtons.XButton2 => 0x0040,
                    _ => 0
                };

                _ = PostMessage(BackgorundWindow, msg, xButtonInfo, 0);

                Sleep(DataProvider.Get().Delays.Backgorund); //Backgorund delay
            }
            else
            {
                int xButtonInfo = button switch
                {
                    MouseButtons.XButton1 => 0x0001,
                    MouseButtons.XButton2 => 0x0002,
                    _ => 0
                };

                mouse_event(msg, 0, 0, xButtonInfo, 0);
            }

            Sleep(DelayBetweenAnyOperation);
        }

        public void SendMouseButton(MouseButtons button)
        {
            HoldMouseButton(button, true);
            Sleep(1);
            HoldMouseButton(button, false);
        }

        public void HoldKey(Keys key, bool isHold)
        {
            token.ThrowIfCancellationRequested(); //Stop script

            lock (keysInDown)
            {
                if (isHold)
                    keysInDown.Add(key);
                else
                    keysInDown.Remove(key);
            }

            if (IsBackground)
            {
                int lparam = ConvertHelper.MakeParam(key, isHold);

                if (isHold)
                    _ = PostMessage(BackgorundWindow, 0x0100, (int)key, lparam); //Keydown
                else
                    _ = PostMessage(BackgorundWindow, 0x0101, (int)key, lparam); //Keyup

                Sleep(DataProvider.Get().Delays.Backgorund);
            }
            else
            {
                if (isHold)
                    keybd_event((byte)key, 0, 0, 0); //Send key down to active window
                else
                    keybd_event((byte)key, 0, 2, 0); //Send key up to active window
            }

            Sleep(DelayBetweenAnyOperation);
        }

        public void SendKey(Keys key)
        {
            HoldKey(key, true);
            Sleep(1);
            HoldKey(key, false);
        }

        public void SendCommand(string command)
        {
            Data data = DataProvider.Get();

            SendKey(data.SlotsBinds.Chat);
            Sleep(data.Delays.Command);

            if (IsBackground)
            {
                foreach (char letter in command)
                {
                    var (key, modifierKey) = ConvertHelper.CharToKeys(letter);

                    if (modifierKey != Keys.None)
                        HoldKey(modifierKey, true);

                    SendKey(key);

                    if (modifierKey != Keys.None)
                        HoldKey(modifierKey, false);

                    Sleep(data.Delays.Command);
                }
            }
            else
                SendKeys.SendWait(command);

            SendKey(Keys.Enter);
        }
        
        public void Sleep(int time)
        {
            token.ThrowIfCancellationRequested(); //Stop script

            if (time <= 0)
                return;

            CancellationTokenSource sleepTokenSource = new();
            CancellationToken sleepToken = sleepTokenSource.Token;

            Task task = Task.Run(sleepToken.WaitHandle.WaitOne); //Wait to cancel

            TimerTick.AddSleepInfo(new SleepInfo(time, sleepTokenSource, token));

            task.Wait(int.MaxValue); //Wait to end the task with maximum timeout
        }
    }
}
