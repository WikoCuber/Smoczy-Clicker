using SC_Scripts.Scripts_Helpers;
using System.Diagnostics;

namespace SC_Scripts.Scripts
{
    public partial class Scripts
    {
        public static void Alting(ScriptsUtilities su)
        {
            var myProcess = Process.GetProcesses().Where(p => p.MainWindowHandle == ScriptsUtilities.GetForegroundWindow());
            ScriptsSetup.GetScriptByName("Alting").EndWithMethod += () => ScriptsUtilities.Resume(myProcess.ElementAt(0)); //Unfreeze thread on end script
            ScriptsUtilities.Suspend(myProcess.ElementAt(0)); //Freeze thread

            //Wait to stop script
            while (true)
                su.Sleep(10);
        }
    }
}
