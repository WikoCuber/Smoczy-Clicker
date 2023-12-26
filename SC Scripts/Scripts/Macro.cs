using SC_Data;
using SC_Scripts.Scripts_Helpers;
using System.Diagnostics;

namespace SC_Scripts.Scripts
{
    public partial class Scripts
    {
        public static void LeftClicker(ScriptsUtilities su)
        {
            Data data = DataProvider.Get();

            Stopwatch s = new();
            ScriptsSetup.LeftTimes = 0; //Sets number of left button clicks to 0

            while (true)
            {
                s.Restart();
                ScriptsSetup.LeftTimes += 2; //Adds 2 clicks to ignore it by hotkey
                su.SendMouseButton(MouseButtons.Left); //Do those 2 clicks
                int time = 1000 / data.Macro.LeftCps - (int)s.ElapsedMilliseconds;
                su.Sleep(time);
            }
        }

        public static void RightClicker(ScriptsUtilities su)
        {
            Data data = DataProvider.Get();

            Stopwatch s = new();
            ScriptsSetup.RightTimes = 0; //Sets number of right button clicks to 0

            while (true)
            {
                s.Restart();
                ScriptsSetup.RightTimes += 2; //Adds 2 clicks to ignore it by hotkey
                su.SendMouseButton(MouseButtons.Right); //Do those 2 clicks
                int time = 1000 / data.Macro.RightCps - (int)s.ElapsedMilliseconds;
                su.Sleep(time);
            }

        }
    }
}
