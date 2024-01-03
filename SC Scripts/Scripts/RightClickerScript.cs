using SC_Data;
using SC_Scripts.Scripts_Managment;
using SC_Scripts.Utilities;
using System.Diagnostics;

namespace SC_Scripts.Scripts
{
    public static class RightClickerScript
    {
        public static void RightClicker(ScriptUtility su)
        {
            ScriptsManager.GetScriptByName("RightClicker")!.EndWithMethod += () => ScriptsHotkey.CancelStopCaptureKey(Keys.RButton);

            Data data = DataProvider.Get();

            Stopwatch s = new();

            while (true)
            {
                s.Restart();

                //Adds 2 clicks to ignore it by hotkey
                ScriptsHotkey.StopCaptureKey(Keys.RButton); 
                ScriptsHotkey.StopCaptureKey(Keys.RButton);

                su.SendMouseButton(MouseButtons.Right); //Do those 2 clicks
                int time = 1000 / data.Clicker.RightCps - (int)s.ElapsedMilliseconds;
                su.Sleep(time);
            }

        }
    }
}
