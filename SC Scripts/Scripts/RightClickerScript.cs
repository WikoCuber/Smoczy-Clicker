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
            ScriptsManager.GetScriptByName("RightClicker")!.EndWithMethod = () => ScriptsHotkey.RightButtonTimes = 0;

            Data data = DataProvider.Get();

            Stopwatch s = new();

            while (true)
            {
                s.Restart();
                ScriptsHotkey.RightButtonTimes += 2;
                su.SendMouseButton(MouseButtons.Right);
                int time = 1000 / data.Clicker.RightCps - (int)s.ElapsedMilliseconds;
                su.Sleep(time);
            }
        }
    }
}
