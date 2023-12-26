using SC_Data;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace SC_Scripts.Scripts_Helpers
{
    public class Hotkey
    {
        #region Imports DLLs
        [DllImport("user32.dll")]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);
        [DllImport("user32.dll")]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelMouseProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll")]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);
        #endregion

        public delegate void MouseEvent(MouseEventArgs args);
        public delegate void KeyboardEvent(KeyboardEventArgs args);

        public static event MouseEvent? MouseAction;
        public static event KeyboardEvent? KeyboardAction;

        //Properties which shows whether hook is on
        public bool IsKeyboardOn { get; private set; } = false;
        public bool IsMouseOn { get; private set; } = false;

        //Lists which forbades multiply down messages
        private static readonly List<Keys> keyboardDownList = [];
        private static readonly List<Keys> mouseDownList = [];

        private delegate IntPtr LowLevelMouseProc(int nCode, IntPtr wParam, IntPtr lParam);
        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        //Sets the callback
        private readonly LowLevelMouseProc mouseProc = MouseHookCallback;
        private readonly LowLevelKeyboardProc keyboardProc = KeyboardHookCallback;

        private static IntPtr mouseHookID = IntPtr.Zero;
        private static IntPtr keyboardHookID = IntPtr.Zero;

        public enum KeyboardMessages
        {
            WM_KEYDOWN = 0x0100,
            WM_KEYUP = 0x0101
        }

        public enum MouseMessages
        {
            WM_LBUTTONDOWN = 0x0201,
            WM_LBUTTONUP = 0x0202,
            WM_MOUSEMOVE = 0x0200,
            WM_MOUSEWHEEL = 0x020A,
            WM_RBUTTONDOWN = 0x0204,
            WM_RBUTTONUP = 0x0205,
            WM_XBUTTONDOWN = 0x020B,
            WM_XBUTTONUP = 0x020C,
            WM_MBUTTONUP = 0x0208,
            WM_MBUTTONDOWN = 0x0207
        }

        //For convert from windows API to this struct
        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int x;
            public int y;
        }

        //For convert from windows API to this struct
        [StructLayout(LayoutKind.Sequential)]
        public struct MSLLHOOKSTRUCT
        {
            public POINT pt;
            public uint mouseData, flags, time;
            public IntPtr dwExtraInfo;
        }

        public class MouseEventArgs : EventArgs
        {
            public int X { get; set; }
            public int Y { get; set; }
            public uint MouseData { get; set; }
            public uint Time { get; set; }
            public uint Flags { get; set; }
            public IntPtr DwExtraInfo { get; set; }
            public MouseMessages Message { get; set; }
            public Keys WhichXButton { get; set; } = Keys.None;
            public MouseEventArgs(MSLLHOOKSTRUCT structobj, MouseMessages mouseMessages)
            {
                X = structobj.pt.x;
                Y = structobj.pt.y;
                MouseData = structobj.mouseData;
                Time = structobj.time;
                Flags = structobj.flags;
                Message = mouseMessages;
                DwExtraInfo = structobj.dwExtraInfo;

                //Checking is XButton was pressed and sets which 
                if (MouseData > 0 && MouseData < 70000)
                    WhichXButton = Keys.XButton1;
                else if (MouseData > 70000)
                    WhichXButton = Keys.XButton2;
            }
        }

        public class KeyboardEventArgs(Keys key, KeyboardMessages keyboardMessages) : EventArgs
        {
            public Keys Key { get; set; } = key;
            public KeyboardMessages Message = keyboardMessages;
        }

        //Starts the hook
        public void MouseStart()
        {
            if (IsMouseOn == false)
            {
                IsMouseOn = true;
                mouseHookID = SetMouseHook(mouseProc);
            }
        }

        //Stops the hook
        public void MouseStop()
        {
            IsMouseOn = false;
            UnhookWindowsHookEx(mouseHookID);
        }

        //Starts the hook
        public void KeyboardStart()
        {
            if (IsKeyboardOn == false)
            {
                IsKeyboardOn = true;
                keyboardHookID = SetKeyboardHook(keyboardProc);
            }
        }

        //Stops the hook
        public void KeyboardStop()
        {
            IsKeyboardOn = false;
            UnhookWindowsHookEx(keyboardHookID);
        }

        public static bool IsKeyDown(Keys key)
        {
            if (keyboardDownList.Contains(key) || mouseDownList.Contains(key))
                return true;
            else
                return false;
        }

        private static IntPtr SetMouseHook(LowLevelMouseProc proc)
        {
            using Process curProcess = Process.GetCurrentProcess();
            using ProcessModule curModule = curProcess.MainModule!;
            return SetWindowsHookEx(14, proc, GetModuleHandle(curModule.ModuleName), 0);
        }

        private static IntPtr SetKeyboardHook(LowLevelKeyboardProc proc)
        {
            using Process curProcess = Process.GetCurrentProcess();
            using ProcessModule curModule = curProcess.MainModule!;
            return SetWindowsHookEx(13, proc, GetModuleHandle(curModule.ModuleName), 0);
        }

        private static IntPtr MouseHookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0)
            {
                MSLLHOOKSTRUCT hookStruct = (MSLLHOOKSTRUCT)Marshal.PtrToStructure(lParam, typeof(MSLLHOOKSTRUCT))!;
                MouseMessages msg = (MouseMessages)wParam;

                if (MouseMessages.WM_LBUTTONDOWN == msg) //For LBUTTONDOWN
                {
                    if (!mouseDownList.Contains(Keys.LButton))
                    {
                        mouseDownList.Add(Keys.LButton);
                        MouseAction?.Invoke(new MouseEventArgs(hookStruct, msg));
                    }
                }
                else if (MouseMessages.WM_LBUTTONUP == msg) //For LBUTTONUP
                {
                    mouseDownList.Remove(Keys.LButton);
                    MouseAction?.Invoke(new MouseEventArgs(hookStruct, msg));
                }
                else if (MouseMessages.WM_RBUTTONDOWN == msg) //For RBUTTONDOWN
                {
                    if (!mouseDownList.Contains(Keys.RButton))
                    {
                        mouseDownList.Add(Keys.RButton);
                        MouseAction?.Invoke(new MouseEventArgs(hookStruct, msg));
                    }
                }
                else if (MouseMessages.WM_RBUTTONUP == msg) //For RBUTTONUP
                {
                    mouseDownList.Remove(Keys.RButton);
                    MouseAction?.Invoke(new MouseEventArgs(hookStruct, msg));
                }
                else if (MouseMessages.WM_XBUTTONDOWN == msg) //For XBUTTONDOWN
                {
                    if (hookStruct.mouseData == 65536) //For XButton1
                    {
                        if (!mouseDownList.Contains(Keys.XButton1))
                        {
                            mouseDownList.Add(Keys.XButton1);
                            MouseAction?.Invoke(new MouseEventArgs(hookStruct, msg));
                        }
                    }
                    else //For XButton1
                    {
                        if (!mouseDownList.Contains(Keys.XButton2))
                        {
                            mouseDownList.Add(Keys.XButton2);
                            MouseAction?.Invoke(new MouseEventArgs(hookStruct, msg));
                        }
                    }
                }
                else if (MouseMessages.WM_XBUTTONUP == msg) //For XBUTTONUP
                {
                    if (hookStruct.mouseData == 65536)
                        mouseDownList.Remove(Keys.XButton1);
                    else
                        mouseDownList.Remove(Keys.XButton2);

                    MouseAction?.Invoke(new MouseEventArgs(hookStruct, msg));
                }
                else if (MouseMessages.WM_MBUTTONDOWN == msg) //For MBUTTONDOWN
                {
                    if (!mouseDownList.Contains(Keys.MButton))
                    {
                        MouseAction?.Invoke(new MouseEventArgs(hookStruct, msg));
                        mouseDownList.Add(Keys.MButton);
                    }
                }
                else if (MouseMessages.WM_MBUTTONUP == msg) //For MBUTTONUP
                {
                    mouseDownList.Remove(Keys.MButton);
                    MouseAction?.Invoke(new MouseEventArgs(hookStruct, msg));
                }
            }
            return CallNextHookEx(mouseHookID, nCode, wParam, lParam);
        }

        private static IntPtr KeyboardHookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0)
            {
                Keys key = (Keys)Marshal.ReadInt32(lParam);
                KeyboardMessages msg = (KeyboardMessages)wParam;

                if (KeyboardMessages.WM_KEYDOWN == msg) //For KEYDOWN
                {
                    if (!keyboardDownList.Contains(key))
                    {
                        keyboardDownList.Add(key);
                        KeyboardAction?.Invoke(new KeyboardEventArgs(key, msg));
                    }
                }
                else if (KeyboardMessages.WM_KEYUP == msg) //For KEYUP
                {
                    keyboardDownList.Remove(key);
                    KeyboardAction?.Invoke(new KeyboardEventArgs(key, msg));
                }
            }
            return CallNextHookEx(keyboardHookID, nCode, wParam, lParam);
        }
    }

}
