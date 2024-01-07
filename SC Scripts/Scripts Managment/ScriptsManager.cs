namespace SC_Scripts.Scripts_Managment
{
    public static class ScriptsManager
    {
        //List of all scripts
        private static readonly List<ScriptInfo> scriptsList = [];

        public static ScriptInfo? GetScriptByName(string scriptName)
        {
            ScriptInfo? script = scriptsList.FirstOrDefault(x => x.Name == scriptName);

            return script;
        }

        public static List<ScriptInfo> GetCopyOfSciptsList() => scriptsList.ToList();

        public static void AddScript(ScriptInfo si)
        {
            if (GetScriptByName(si.Name) != null)
                return;

            scriptsList.Add(si);
        }

        public static void RemoveScript(string scriptName)
        {
            ScriptInfo? scriptToRemove = GetScriptByName(scriptName);

            //If script doesn't exist
            if (scriptToRemove == null)
                return;

            scriptToRemove.StopScript();
            scriptsList.Remove(scriptToRemove);
        }

        public static List<string> GetActiveScriptsName()
        {
            List<string> result = [];

            var activeScripts = scriptsList.Where(x => x.IsActive == true);

            foreach (var script in activeScripts)
                result.Add(script.Name);

            return result;
        }
    }
}
