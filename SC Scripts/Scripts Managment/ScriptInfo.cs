using SC_Scripts.Utilities;

namespace SC_Scripts.Scripts_Managment
{
    public class ScriptInfo
    {
        public string Name { get; private set; } //Name is use as ID
        public Keys Key { get; set; }
        public CaptureTypes CaptureType { get; set; } = CaptureTypes.KEY_DOWN;
        public Keys SecondKey { get; set; } = Keys.None; //Second key to keystroke. Used if capturetype is KEYSTROKE or KEYSTROKE_PRESS
        public bool CanCancelByKey { get; set; } = true; //Whether script can turn off by again press key
        public bool IsActive { get; private set; } = false;

        public delegate void ScriptMethodDelegate(ScriptUtility su);
        public delegate void EndWithMethodDelegate();

        public EndWithMethodDelegate? EndWithMethod { get; set; }

        private readonly ScriptMethodDelegate scriptMethod;
        private Thread scriptThread;
        private ScriptUtility su; //Script gets this instance 
        private bool isWork;

        public ScriptInfo(string name, Keys key, ScriptMethodDelegate scriptMethod, CaptureTypes captureType)
        {
            Name = name;
            Key = key;
            CaptureType = captureType;
            this.scriptMethod = scriptMethod;
            scriptThread = new(ScriptMethod)
            {
                IsBackground = true,
                Name = name
            };

            su = new();
        }

        public void ToggleActiveState() => IsActive = !IsActive;

        public bool IsScriptWork() => isWork;

        public void StopScript() => su.Cancel();

        public void StartScript()
        {
            if (!IsActive || IsScriptWork())
                return;

            scriptThread = new(ScriptMethod);
            scriptThread.Start();

            isWork = true;
        }

        //Invokes script and catch errors  
        private void ScriptMethod()
        {
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
                EndWithMethod?.Invoke();

                su = new();

                scriptThread = new Thread(ScriptMethod); //Reset thread

                isWork = false;
            }
        }
    }
}
