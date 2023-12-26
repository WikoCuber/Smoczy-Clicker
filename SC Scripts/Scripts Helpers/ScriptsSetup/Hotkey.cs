namespace SC_Scripts.Scripts_Helpers
{
    public static partial class ScriptsSetup
    {
        //For don't run another macro script when script send key
        public static int LeftTimes { get; set; }
        public static int RightTimes { get; set; }
        public static bool IsExited { get; private set; } = false; //If true, block everything

        //Do keys capture in other thread to avoid input lag
        private static readonly Thread hotkeyThread = new(new ThreadStart(HotkeySetup));
        private static Hotkey hotkey;
        private static Keys lastKey;
        private static bool stopCaptureScripts = false;

        //Changes whether hotkey should working. True for yes
        public static void ChangeHotkeyState(bool on)
        {
            if (IsExited)
                return;

            if (on)
            {
                hotkey.KeyboardStart();
                hotkey.MouseStart();
            }
            else
            {
                hotkey.KeyboardStop();
                hotkey.MouseStop();
            }
        }

        //Returns next Key that user press
        public static Keys GetKey(bool stopCaptureScriptsOnce = true)
        {
            if (IsExited)
                return Keys.None;

            ScriptsUtilities su = new();

            lastKey = Keys.None;
            stopCaptureScripts = stopCaptureScriptsOnce;
            while (lastKey == Keys.None)
                su.Sleep(1);

            return lastKey;
        }

        private static void HotkeySetup()
        {
            Hotkey.KeyboardAction += KeyboardAction;
            Hotkey.MouseAction += MouseAction;
            hotkey.KeyboardStart();
            hotkey.MouseStart();
            Application.Run();
        }

        //Calls the background method to avoid input lag
        private static void MouseAction(Hotkey.MouseEventArgs e) => Task.Run(() => MouseActionBackgound(e));

        //Calls the background method to avoid input lag
        private static void KeyboardAction(Hotkey.KeyboardEventArgs e) => Task.Run(() => KeyboardActionBackgound(e));

        //Captures mouse event
        private static void MouseActionBackgound(Hotkey.MouseEventArgs e)
        {
            Keys key = Keys.None;
            if (e.Message == Hotkey.MouseMessages.WM_LBUTTONDOWN || e.Message == Hotkey.MouseMessages.WM_LBUTTONUP)
                key = Keys.LButton;
            if (e.Message == Hotkey.MouseMessages.WM_RBUTTONDOWN || e.Message == Hotkey.MouseMessages.WM_RBUTTONUP)
                key = Keys.RButton;

            //Anti self turn off macro
            if (key == Keys.LButton && LeftTimes >= 0)
                LeftTimes--;
            else if (key == Keys.RButton && RightTimes >= 0)
                RightTimes--;

            if ((key == Keys.RButton && RightTimes <= 0) || (key == Keys.LButton && LeftTimes <= 0) || key == Keys.None)
            {
                #region Calls KeyboardAction with appropriate message and key
                switch (e.Message)
                {
                    case Hotkey.MouseMessages.WM_LBUTTONUP:
                        KeyboardActionBackgound(new Hotkey.KeyboardEventArgs(Keys.LButton, Hotkey.KeyboardMessages.WM_KEYUP));
                        break;
                    case Hotkey.MouseMessages.WM_LBUTTONDOWN:
                        KeyboardActionBackgound(new Hotkey.KeyboardEventArgs(Keys.LButton, Hotkey.KeyboardMessages.WM_KEYDOWN));
                        break;
                    case Hotkey.MouseMessages.WM_RBUTTONUP:
                        KeyboardActionBackgound(new Hotkey.KeyboardEventArgs(Keys.RButton, Hotkey.KeyboardMessages.WM_KEYUP));
                        break;
                    case Hotkey.MouseMessages.WM_RBUTTONDOWN:
                        KeyboardActionBackgound(new Hotkey.KeyboardEventArgs(Keys.RButton, Hotkey.KeyboardMessages.WM_KEYDOWN));
                        break;
                    case Hotkey.MouseMessages.WM_MBUTTONUP:
                        KeyboardActionBackgound(new Hotkey.KeyboardEventArgs(Keys.MButton, Hotkey.KeyboardMessages.WM_KEYUP));
                        break;
                    case Hotkey.MouseMessages.WM_MBUTTONDOWN:
                        KeyboardActionBackgound(new Hotkey.KeyboardEventArgs(Keys.MButton, Hotkey.KeyboardMessages.WM_KEYDOWN));
                        break;
                    case Hotkey.MouseMessages.WM_XBUTTONUP:
                        KeyboardActionBackgound(new Hotkey.KeyboardEventArgs(e.WhichXButton, Hotkey.KeyboardMessages.WM_KEYUP));
                        break;
                    case Hotkey.MouseMessages.WM_XBUTTONDOWN:
                        KeyboardActionBackgound(new Hotkey.KeyboardEventArgs(e.WhichXButton, Hotkey.KeyboardMessages.WM_KEYDOWN));
                        break;
                }
                #endregion
            }
        }

        //Captures keyboard event
        private static void KeyboardActionBackgound(Hotkey.KeyboardEventArgs e)
        {

            if (e.Message == Hotkey.KeyboardMessages.WM_KEYDOWN && lastKey == Keys.None)
                lastKey = e.Key;
            if (!stopCaptureScripts)
            {
                foreach (ScriptInfo script in scriptsList) //Check for all scripts
                {
                    if (script.CaptureType == CaptureTypes.KEY_DOWN &&
                        e.Message == Hotkey.KeyboardMessages.WM_KEYDOWN &&
                        e.Key == script.Key)
                    {
                        if (!script.IsScriptWork())
                            script.StartScript();
                        else if (script.IsScriptWork() && script.CanCancelByKey)
                            script.StopScript();
                    }
                    else if (script.CaptureType == CaptureTypes.KEY_UP &&
                             e.Message == Hotkey.KeyboardMessages.WM_KEYUP &&
                             e.Key == script.Key)
                    {
                        if (!script.IsScriptWork())
                            script.StartScript();
                        else if (script.IsScriptWork() && script.CanCancelByKey)
                            script.StopScript();
                    }
                    else if (script.CaptureType == CaptureTypes.KEY_PRESS &&
                            e.Message == Hotkey.KeyboardMessages.WM_KEYDOWN &&
                            e.Key == script.Key)
                    {
                        if (!script.IsScriptWork())
                            script.StartScript();
                    }
                    else if (script.CaptureType == CaptureTypes.KEY_PRESS &&
                            e.Message == Hotkey.KeyboardMessages.WM_KEYUP &&
                            e.Key == script.Key)
                    {
                        if (script.IsScriptWork())
                            script.StopScript();
                    }
                    else if (script.CaptureType == CaptureTypes.KEYSTROKE &&
                            e.Message == Hotkey.KeyboardMessages.WM_KEYDOWN &&
                            e.Key == script.SecondKey)
                    {
                        if (Hotkey.IsKeyDown(script.Key))
                        {
                            if (!script.IsScriptWork())
                                script.StartScript();
                            else if (script.IsScriptWork() && script.CanCancelByKey)
                                script.StopScript();
                        }
                    }
                    else if (script.CaptureType == CaptureTypes.KEYSTROKE_PRESS &&
                            e.Message == Hotkey.KeyboardMessages.WM_KEYDOWN &&
                            e.Key == script.SecondKey)
                    {
                        if (Hotkey.IsKeyDown(script.Key))
                        {
                            if (!script.IsScriptWork())
                                script.StartScript();
                        }
                    }
                    else if (script.CaptureType == CaptureTypes.KEYSTROKE_PRESS &&
                            e.Message == Hotkey.KeyboardMessages.WM_KEYUP &&
                            e.Key == script.SecondKey)
                    {
                        if (script.IsScriptWork())
                            script.StopScript();
                    }
                }
            }
            else
                stopCaptureScripts = false;

        }

    }
}
