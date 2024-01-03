using SC_Data;
using SC_Scripts.Scripts_Managment;
using SC_Scripts.Utilities;
using System.Diagnostics;

namespace SC_Scripts.Scripts
{
    public static class LeftClickerScript
    {
        public static void LeftClicker(ScriptUtility su)
        {
            ScriptsManager.GetScriptByName("LeftClicker")!.EndWithMethod += () => ScriptsHotkey.CancelStopCaptureKey(Keys.LButton);

            Data data = DataProvider.Get();

            Stopwatch s = new();

            while (true)
            {
                s.Restart();

                //Adds 2 clicks to ignore it by hotkey
                ScriptsHotkey.StopCaptureKey(Keys.LButton);
                ScriptsHotkey.StopCaptureKey(Keys.LButton);

                su.SendMouseButton(MouseButtons.Left); //Do those 2 clicks
                int time = 1000 / data.Clicker.LeftCps - (int)s.ElapsedMilliseconds;
                su.Sleep(time);
            }
        }
    }
}
