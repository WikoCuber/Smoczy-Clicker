using SC_Data;
using System.Runtime.InteropServices;

namespace SC_Scripts.Scripts_Helpers
{
    public partial class ScriptsUtilities
    {
        #region Imports DLLs
        [DllImport("user32.dll")]
        private static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);
        #endregion

        public void HoldKey(Keys key, bool isHold)
        {
            token.ThrowIfCancellationRequested(); //Abort script

            lock (KeysDownScripts)
            {
                if (isHold)
                    KeysDownScripts.Add(key);
                else
                    KeysDownScripts.Remove(key);
            }

            if (IsBackground)
            {
                uint repeatCount = 0, transition = 0, previousState = 0;
                uint scanCode = (uint)key, extended = 0, context = 0;

                uint lParamDown, lParamUp;

                lParamDown = repeatCount | (scanCode << 16) | (extended << 24) |
                             (context << 29) | (previousState << 30) | (transition << 31);

                previousState = 1;
                transition = 1;

                lParamUp = repeatCount | (scanCode << 16) | (extended << 24) |
                           (context << 29) | (previousState << 30) | (transition << 31);
                if (isHold)
                    _ = PostMessage(BackgorundWindow, 0x0100, (int)key, (int)lParamDown); //Send key down to background window
                else
                    _ = PostMessage(BackgorundWindow, 0x0101, (int)key, (int)lParamUp); //Send key up to background window
                
                Sleep(DataProvider.Get().Delays.Backgorund);
            }
            else
            {
                if (isHold)
                    keybd_event((byte)key, 0, 0, 0); //Send key down to current window
                else
                    keybd_event((byte)key, 0, 2, 0); //Send key up to current window
            }

            Sleep(DelayBetweenAnyOperation);
        }

        public void SendKey(Keys key)
        {
            HoldKey(key, true);
            Sleep(1);
            HoldKey(key, false);
        }

        //Convert Keys to string
        public static string KeysToString(Keys key)
        {
            string result = key.ToString();
            if (result.Length == 2 && result.Contains('D'))
                result = result[1].ToString();

            return result;
        }
    }
}
