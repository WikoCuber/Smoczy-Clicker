using SC_Scripts.EventArgs;
using SC_Scripts.Helpers;
using SC_Scripts.Messages;
using SC_Scripts.Utilities;

namespace SC_Scripts.Scripts_Managment
{
    public static class ScriptsHotkey
    {
        public static bool IsExited { get; private set; } //If true, block everything

        private static readonly Thread hotkeyThread;
        private static readonly List<Keys> stopCaptureKeysList;
        private static Keys lastKey;
        private static bool stopCaptureScripts;

        static ScriptsHotkey()
        {
            stopCaptureKeysList = [];

            hotkeyThread = new(HotkeySetup)
            {
                //Set Higest prority to avoid input lag
                Priority = ThreadPriority.Highest,
                Name = "hotkeyThread"
            };

            hotkeyThread.Start();
        }

        //Changes whether hotkey should working
        public static void ChangeHotkeyState(bool isOn)
        {
            if (IsExited)
                throw new Exception("Script loop is closed");

            if (isOn)
            {
                Hotkey.KeyboardStart();
                Hotkey.MouseStart();
            }
            else
            {
                Hotkey.KeyboardStop();
                Hotkey.MouseStop();
            }
        }

        //Removes and blocks everything
        public static void Exit()
        {
            if (IsExited)
                return;

            var copyOfScriptsList = ScriptsManager.GetCopyOfSciptsList();
            foreach (var script in copyOfScriptsList)
                ScriptsManager.RemoveScript(script.Name);

            IsExited = true;
            Application.Exit(); //Close main loop
        }

        //Returns next Key that user press
        public static Keys GetKey(bool stopCaptureScriptsOnce = true)
        {
            if (IsExited)
                throw new Exception("Script loop is closed");

            ScriptUtility su = new();

            lastKey = Keys.None;
            stopCaptureScripts = stopCaptureScriptsOnce;
            while (lastKey == Keys.None)
                su.Sleep(1);

            stopCaptureScripts = false;
            return lastKey;
        }

        public static void StopCaptureKey(Keys key)
        {
            lock (stopCaptureKeysList)
            { 
                stopCaptureKeysList.Add(key); 
            }
        }

        public static void CancelStopCaptureKey(Keys key)
        {
            lock (stopCaptureKeysList)
            {
                while (stopCaptureKeysList.Remove(key)) ;
            }
        }

        private static void HotkeySetup()
        {
            Hotkey.KeyboardEvent += KeyboardCallback;
            Hotkey.MouseEvent += MouseCallback;
            Hotkey.KeyboardStart();
            Hotkey.MouseStart();
            Application.Run();
        }

        //Calls the background method to avoid input lag
        private static void MouseCallback(object? sender, EventArgs.MouseEventArgs e) => Task.Run(() => MouseCallbackBackgound(e));

        //Calls the background method to avoid input lag
        private static void KeyboardCallback(object? sender, KeyboardEventArgs e) => Task.Run(() => KeyboardCallbackBackgound(e));

        //Captures mouse event
        private static void MouseCallbackBackgound(EventArgs.MouseEventArgs e)
        {
            Keys key = ConvertHelper.MouseMessageToKeys(e.Message, e.WhichXButton);

            //Calls KeyboardAction with appropriate message and key
            if (e.Message.ToString().Contains("DOWN"))
                KeyboardCallbackBackgound(new KeyboardEventArgs(key, KeyboardMessages.WM_KEYDOWN));
            else if (e.Message.ToString().Contains("UP"))
                KeyboardCallbackBackgound(new KeyboardEventArgs(key, KeyboardMessages.WM_KEYUP));
        }

        //Captures keyboard event
        private static void KeyboardCallbackBackgound(KeyboardEventArgs e)
        {
            if (stopCaptureScripts)
                return;

            lock (stopCaptureKeysList)
            {
                //If exists then return
                if (stopCaptureKeysList.Remove(e.Key))
                    return;
            }

            //For GetKey method
            if (e.Message == KeyboardMessages.WM_KEYDOWN && lastKey == Keys.None)
                lastKey = e.Key;


            foreach (ScriptInfo script in ScriptsManager.GetCopyOfSciptsList()) //Check for all scripts
            {
                switch (script.CaptureType)
                {
                    case CaptureTypes.KEY_UP:
                        if (e.Message == KeyboardMessages.WM_KEYUP && e.Key == script.Key)
                        {
                            if (!script.IsScriptWork())
                                script.StartScript();
                            else if (script.IsScriptWork() && script.CanCancelByKey)
                                script.StopScript();
                        }
                        break;
                    case CaptureTypes.KEY_DOWN:
                        if (e.Message == KeyboardMessages.WM_KEYDOWN && e.Key == script.Key)
                        {
                            if (!script.IsScriptWork())
                                script.StartScript();
                            else if (script.IsScriptWork() && script.CanCancelByKey)
                                script.StopScript();
                        }
                        break;
                    case CaptureTypes.KEY_PRESS:
                        if (e.Key == script.Key)
                        {
                            if (!script.IsScriptWork() && e.Message == KeyboardMessages.WM_KEYDOWN)
                                script.StartScript();
                            else if (script.IsScriptWork() && e.Message == KeyboardMessages.WM_KEYUP)
                                script.StopScript();
                        }
                        break;
                    case CaptureTypes.KEYSTROKE:
                        if (e.Message == KeyboardMessages.WM_KEYDOWN && e.Key == script.SecondKey && Hotkey.IsKeyDown(script.Key))
                        {
                            if (!script.IsScriptWork())
                                script.StartScript();
                            else if (script.IsScriptWork() && script.CanCancelByKey)
                                script.StopScript();
                        }
                        break;
                    case CaptureTypes.KEYSTROKE_PRESS:
                        if (e.Key == script.SecondKey)
                        {
                            if (!script.IsScriptWork() && e.Message == KeyboardMessages.WM_KEYDOWN && Hotkey.IsKeyDown(script.Key))
                                script.StartScript();
                            else if (script.IsScriptWork() && e.Message == KeyboardMessages.WM_KEYUP)
                                script.StopScript();
                        }
                        break;
                }
            }
        }
    }
}
