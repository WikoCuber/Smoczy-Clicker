namespace SC_Scripts.Scripts_Helpers
{
    public static partial class ScriptsSetup
    {
        //List of all scripts
        private static readonly List<ScriptInfo> scriptsList = [];

        static ScriptsSetup()
        {
            hotkeyThread.Priority = ThreadPriority.Highest; //Set Higest prority to avoid input lag
            hotkeyThread.Start();
            hotkey = new Hotkey();
        }

        //Returns orginal script. Null if scipt doesn't exist
        public static ScriptInfo? GetScriptByName(string scriptName)
        {
            if (IsExited)
                return null;

            var scriptList = scriptsList.FirstOrDefault((x) => x.Name == scriptName);

            return scriptList;
        }

        //Returns copy of scriptList
        public static List<ScriptInfo> GetCopyOfSciptsList() => scriptsList.ToList();

        //Add script. False if error occured
        public static bool AddScript(ScriptInfo si)
        {
            if (IsExited)
                return false;

            if (GetScriptByName(si.Name) != null)
                return false;

            scriptsList.Add(si);

            return true;
        }

        //Removes and blocks everything
        public static void Exit()
        {
            if (IsExited)
                return;

            var copyOfScriptsList = GetCopyOfSciptsList();
            foreach (var script in copyOfScriptsList)
                RemoveScript(script.Name);

            IsExited = true; //It close main loop
            Application.Exit();
        }

        //Remove script. False if error occured
        public static bool RemoveScript(string scriptName)
        {
            if (IsExited)
                return false;

            ScriptInfo? scriptToRemove = GetScriptByName(scriptName);

            //Script doesn`t exist
            if (scriptToRemove == null)
                return false;

            scriptToRemove.StopScript();
            scriptsList.Remove(scriptToRemove);

            return true;
        }

        //Returns all active scripts
        public static List<string> GetActiveScriptsName()
        {
            List<string> result = [];

            var activeScripts = scriptsList.Where((x) => x.IsActive == true); //Get all active scripts

            foreach (var script in activeScripts)
                result.Add(script.Name);

            return result;
        }
    }
}
