using System.Runtime.InteropServices;

namespace SC_Scripts.Utilities
{
    public static class DPIUtility
    {
        #region DLLs Imports
        [DllImport("User32.dll")]
        private static extern bool SystemParametersInfo(int uiAction, int uiParam, IntPtr pvParam, int fWinIni);
        #endregion

        private const int SPI_SETMOUSESPEED = 0x0071;
        private const int SPI_GETMOUSESPEED = 0x0070;

        private static int earlierDPI = 0; //DPI to back

        public static unsafe void SetLowDPI()
        {
            int DPI;
            SystemParametersInfo(SPI_GETMOUSESPEED, 0, new IntPtr(&DPI), 0); //Get currnet DPI
            if (earlierDPI == 0)
                earlierDPI = DPI; //Set earlier DPI
            SystemParametersInfo(SPI_SETMOUSESPEED, 0, 1, 0); //Set low DPI
        }

        public static unsafe void SetHighDPI()
        {
            int DPI;
            SystemParametersInfo(SPI_GETMOUSESPEED, 0, new IntPtr(&DPI), 0); //Get currnet DPI
            if (earlierDPI == 0)
                earlierDPI = DPI; //Set earlier DPI
            SystemParametersInfo(SPI_SETMOUSESPEED, 0, 20, 0); //Set high DPI
        }

        //Back to earlier DPI
        public static void BackDPI()
        {
            if (earlierDPI != 0)
                SystemParametersInfo(SPI_SETMOUSESPEED, 0, earlierDPI, 0);
        }
    }
}
