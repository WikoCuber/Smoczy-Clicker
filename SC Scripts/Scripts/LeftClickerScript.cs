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
            ScriptsManager.GetScriptByName("LeftClicker")!.EndWithMethod = () => ScriptsHotkey.LeftButtonTimes = 0;

            Data data = DataProvider.Get();

            Stopwatch s = new();

            while (true)
            {
                s.Restart();
                ScriptsHotkey.LeftButtonTimes += 2;
                su.SendMouseButton(MouseButtons.Left);
                int time = 1000 / data.Clicker.LeftCps - (int)s.ElapsedMilliseconds;
                su.Sleep(time);
            }
        }
    }
}
