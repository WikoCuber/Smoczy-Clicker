using SC_Scripts.EventArgs;
using SC_Scripts.Messages;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace SC_Scripts
{
    public static class Hotkey
    {
        #region DLLs Imports
        [DllImport("user32.dll")]
        private static extern IntPtr SetWindowsHookEx(int idHook, KeyboardCallback lpfn, IntPtr hMod, int dwThreadId);
        [DllImport("user32.dll")]
        private static extern IntPtr SetWindowsHookEx(int idHook, MouseCallback lpfn, IntPtr hMod, int dwThreadId);
        [DllImport("user32.dll")]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);
        [DllImport("user32.dll")]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);
        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);
        #endregion

        public static event EventHandler<EventArgs.MouseEventArgs>? MouseEvent;
        public static event EventHandler<KeyboardEventArgs>? KeyboardEvent;

        private delegate IntPtr MouseCallback(int nCode, IntPtr wParam, IntPtr lParam);
        private delegate IntPtr KeyboardCallback(int nCode, IntPtr wParam, IntPtr lParam);

        //Sets the callback
        private static readonly MouseCallback mouseCallback = MouseCallbackFunc;
        private static readonly KeyboardCallback keyboardCallback = KeyboardCallbackFunc;

        //List thats forbades multiply down messages
        private static readonly List<Keys> downList = [];

        private static IntPtr mouseHookID = IntPtr.Zero;
        private static IntPtr keyboardHookID = IntPtr.Zero;

        public static void MouseStart() => mouseHookID = SetMouseHook(mouseCallback);

        public static void KeyboardStart() => keyboardHookID = SetKeyboardHook(keyboardCallback);

        public static void MouseStop() => UnhookWindowsHookEx(mouseHookID);

        public static void KeyboardStop() => UnhookWindowsHookEx(keyboardHookID);

        public static bool IsKeyDown(Keys key)
        {
            if (downList.Contains(key))
                return true;
            else
                return false;
        }

        //True if key was added to list
        private static bool SetDownKey(Keys key)
        {
            if (!downList.Contains(key))
            {
                downList.Add(key);
                return true;
            }

            return false;
        }

        private static IntPtr SetMouseHook(MouseCallback proc)
        {
            using Process curProcess = Process.GetCurrentProcess();
            using ProcessModule curModule = curProcess.MainModule!;
            return SetWindowsHookEx(14, proc, GetModuleHandle(curModule.ModuleName), 0);
        }

        private static IntPtr SetKeyboardHook(KeyboardCallback proc)
        {
            using Process curProcess = Process.GetCurrentProcess();
            using ProcessModule curModule = curProcess.MainModule!;
            return SetWindowsHookEx(13, proc, GetModuleHandle(curModule.ModuleName), 0);
        }

        private static IntPtr MouseCallbackFunc(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0)
            {
                MSLLHOOKSTRUCT hookStruct = (MSLLHOOKSTRUCT)Marshal.PtrToStructure(lParam, typeof(MSLLHOOKSTRUCT))!;
                MouseMessages msg = (MouseMessages)wParam;

                bool isInvoke = true;

                switch (msg)
                {
                    case MouseMessages.WM_LBUTTONDOWN:
                        isInvoke = SetDownKey(Keys.LButton);
                        break;
                    case MouseMessages.WM_LBUTTONUP:
                        downList.Remove(Keys.LButton);
                        break;
                    case MouseMessages.WM_RBUTTONDOWN:
                        isInvoke = SetDownKey(Keys.RButton);
                        break;
                    case MouseMessages.WM_RBUTTONUP:
                        downList.Remove(Keys.RButton);
                        break;
                    case MouseMessages.WM_MBUTTONDOWN:
                        isInvoke = SetDownKey(Keys.MButton);
                        break;
                    case MouseMessages.WM_MBUTTONUP:
                        downList.Remove(Keys.MButton);
                        break;
                    case MouseMessages.WM_XBUTTONDOWN:
                        if (hookStruct.mouseData > 0 && hookStruct.mouseData < 70000)
                            isInvoke = SetDownKey(Keys.XButton1);
                        else if (hookStruct.mouseData > 70000)
                            isInvoke = SetDownKey(Keys.XButton2);
                        break;
                    case MouseMessages.WM_XBUTTONUP:
                        if (hookStruct.mouseData > 0 && hookStruct.mouseData < 70000)
                            downList.Remove(Keys.XButton1);
                        else if (hookStruct.mouseData > 70000)
                            downList.Remove(Keys.XButton2);
                        break;
                }

                if (isInvoke)
                    MouseEvent?.Invoke(null, new EventArgs.MouseEventArgs(hookStruct, msg));
            }

            return CallNextHookEx(mouseHookID, nCode, wParam, lParam);
        }

        private static IntPtr KeyboardCallbackFunc(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0)
            {
                Keys key = (Keys)Marshal.ReadInt32(lParam);
                KeyboardMessages msg = (KeyboardMessages)wParam;

                switch (msg)
                {
                    case KeyboardMessages.WM_KEYDOWN:
                        if (SetDownKey(key))
                            KeyboardEvent?.Invoke(null, new KeyboardEventArgs(key, msg));
                        break;
                    case KeyboardMessages.WM_KEYUP:
                        downList.Remove(key);
                        KeyboardEvent?.Invoke(null, new KeyboardEventArgs(key, msg));
                        break;
                }
            }

            return CallNextHookEx(keyboardHookID, nCode, wParam, lParam);
        }
    }
}
