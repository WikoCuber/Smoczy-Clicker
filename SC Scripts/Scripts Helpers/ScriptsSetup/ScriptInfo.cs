using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace SC_Scripts.Scripts_Helpers
{
    public static partial class ScriptsSetup
    {
        //Types of capture
        public enum CaptureTypes
        {
            KEY_UP, //If key was relesed
            KEY_DOWN, //If key was in down 
            KEY_PRESS, //Turn on script when key was in down, and turn off when key was relesed
            KEYSTROKE, //If Key and SecondKey was in down
            KEYSTROKE_PRESS //Turn on script when Key and SecondKey was in down and turn off when SecondKey was relesed
        }

        public class ScriptInfo
        {
            public delegate void ScriptMethodDelegate(ScriptsUtilities su);
            public delegate void EndWithMethodDelegate();

            public string Name { get; private set; } //Private set because name is used to identify script
            public Keys Key { get; set; }
            public CaptureTypes CaptureType { get; set; } = CaptureTypes.KEY_DOWN;
            public Keys SecondKey { get; set; } = Keys.None; //Second key to keystroke. Used if capturetype is KEYSTROKE or KEYSTROKE_PRESS
            public bool CanCancelByKey { get; set; } = true; //Whether script can turn off by again press key
            public bool IsActive { get; private set; } = false;

            public EndWithMethodDelegate? EndWithMethod { get; set; }

            private readonly ScriptMethodDelegate scriptMethod;
            private Thread scriptThread;
            private ScriptsUtilities? su; //Script gets this instance 

            public ScriptInfo(string name, Keys key, ScriptMethodDelegate scriptMethod, CaptureTypes captureType)
            {
                Name = name;
                Key = key;
                CaptureType = captureType;
                this.scriptMethod = scriptMethod;
                scriptThread = new(ScriptMethod)
                {
                    IsBackground = true
                };
            }

            public void ToggleActiveState() => IsActive = !IsActive;

            //Returns whether script work
            public bool IsScriptWork() => scriptThread.IsAlive;

            //Cancel the script thread
            public void StopScript() => su?.Cancel();

            //Start the script thread. False if error occured
            public bool StartScript()
            {
                if (!IsActive)
                    return false;
                if (IsScriptWork())
                    return false;
                scriptThread = new(new ThreadStart(ScriptMethod));
                scriptThread.Start();
                return true;
            }

            //Invokes script and catch errors  
            private void ScriptMethod()
            {
                su = new();
                try
                {
                    scriptMethod.Invoke(su); //Invoke script
                }
                catch (Exception exception)
                {
                    if (exception is not OperationCanceledException) //In other case, rethrow 
                        throw;
                }
                finally
                {
                    scriptThread = new Thread(new ThreadStart(ScriptMethod)); //Reset thread

                    EndWithMethod?.Invoke();

                    //Relese keys in down
                    List<Keys> copyOfkeysDownScripts = new(su.KeysDownScripts); //Do copy
                    foreach (var item in copyOfkeysDownScripts)
                    {
                        ScriptsUtilities su = new(); 
                        if (ScriptsUtilities.KeysToMouseButtons(item) == MouseButtons.None)
                            su.HoldKey(item, false);
                        else
                            su.HoldMouseButton(ScriptsUtilities.KeysToMouseButtons(item), false);
                    }
                }
            }
        }
    }
}
