using SC_Scripts.Scripts_Managment;
using SC_Scripts.Utilities;
using System.Diagnostics;

namespace SC_Scripts.Scripts
{
    public static class AltingScript
    {
        public static void Alting(ScriptUtility su)
        {
            var myProcess = Process.GetProcesses().Where(p => p.MainWindowHandle == ScriptUtility.GetForegroundWindow());
            ScriptsManager.GetScriptByName("Alting")!.EndWithMethod += () => ProcessUtility.Resume(myProcess.ElementAt(0)); //Unfreeze thread on end script
            ProcessUtility.Suspend(myProcess.ElementAt(0)); //Freeze thread

            //Wait to stop script
            while (true)
                su.Sleep(10);
        }
    }
}
