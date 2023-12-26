using SC_Data;
using System.Runtime.InteropServices;

namespace SC_Scripts.Scripts_Helpers
{
    public partial class ScriptsUtilities
    {
        #region Imports DLLs
        [DllImport("user32.dll")]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
        #endregion

        public void MouseMove(int x, int y)
        {
            token.ThrowIfCancellationRequested(); //Abort script

            if (IsBackground)
                _ = PostMessage(BackgorundWindow, 0x0200, 0x0001, MakeLParam(x, y)); //Send Message to background window
            else
                Cursor.Position = new Point(x, y);

            Sleep(DelayBetweenAnyOperation);
        }

        public void HoldMouseButton(MouseButtons button, bool isHold)
        {
            token.ThrowIfCancellationRequested(); //Abort script

            lock (KeysDownScripts)
            {
                if (isHold)
                    KeysDownScripts.Add(MouseButtonsToKeys(button));
                else
                    KeysDownScripts.Remove(MouseButtonsToKeys(button));
            }

            if (IsBackground)
            {
                int msg = 0;
                int xButtonInfo = 0;

                switch (button) //Sets a message
                {
                    case MouseButtons.Left:
                        msg = 0x0201;
                        break;
                    case MouseButtons.Right:
                        msg = 0x0204;
                        break;
                    case MouseButtons.Middle:
                        msg = 0x0207;
                        break;
                    case MouseButtons.XButton1:
                        msg = 0x020B;
                        xButtonInfo = 0x0020;
                        break;
                    case MouseButtons.XButton2:
                        msg = 0x020B;
                        xButtonInfo = 0x0040;
                        break;
                }

                if (isHold)
                    _ = PostMessage(BackgorundWindow, msg, xButtonInfo, 0); //Send key down to background window
                else
                    _ = PostMessage(BackgorundWindow, msg + 1, xButtonInfo, 0); //Send key up to background window
                
                Sleep(DataProvider.Get().Delays.Backgorund);
            }
            else
            {
                int msg = 0;
                int xButtonInfo = 0;

                switch (button) //Sets a message
                {
                    case MouseButtons.Left:
                        if (isHold)
                            msg = 0x0002;
                        else
                            msg = 0x0004;
                        break;
                    case MouseButtons.Right:
                        if (isHold)
                            msg = 0x0008;
                        else
                            msg = 0x0010;
                        break;
                    case MouseButtons.Middle:
                        if (isHold)
                            msg = 0x0020;
                        else
                            msg = 0x0040;
                        break;
                    case MouseButtons.XButton1:
                        if (isHold)
                            msg = 0x0080;
                        else
                            msg = 0x0100;
                        xButtonInfo = 0x0001;
                        break;
                    case MouseButtons.XButton2:
                        if (isHold)
                            msg = 0x0080;
                        else
                            msg = 0x0100;
                        xButtonInfo = 0x0002;
                        break;
                }

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

        //Changes MouseButtons to Keys. Keys.None for unknow mouseButton
        public static Keys MouseButtonsToKeys(MouseButtons mouseButton)
        {
            return mouseButton switch
            {
                MouseButtons.Left => Keys.LButton,
                MouseButtons.Right => Keys.RButton,
                MouseButtons.Middle => Keys.MButton,
                MouseButtons.XButton1 => Keys.XButton1,
                MouseButtons.XButton2 => Keys.XButton2,
                _ => Keys.None,
            };
        }

        //Changes Keys to MouseButtons. MouseButtons.None for unknow mouseButton
        public static MouseButtons KeysToMouseButtons(Keys key)
        {
            return key switch
            {
                Keys.LButton => MouseButtons.Left,
                Keys.RButton => MouseButtons.Right,
                Keys.MButton => MouseButtons.Middle,
                Keys.XButton1 => MouseButtons.XButton1,
                Keys.XButton2 => MouseButtons.XButton2,
                _ => MouseButtons.None,
            };
        }
    }
}
