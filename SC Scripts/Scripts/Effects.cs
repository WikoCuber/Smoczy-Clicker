using SC_Data;
using SC_Scripts.Scripts_Helpers;

namespace SC_Scripts.Scripts
{
    public partial class Scripts
    {
        public static void Effects(ScriptsUtilities su)
        {
            Data data = DataProvider.Get();

            //Returns when subscript "Effects" is disabled
            if (!data.Settings.IsEffectsOn)
                return;

            //Backs DPI on end of script
            ScriptsSetup.GetScriptByName("Effects").EndWithMethod += ScriptsUtilities.BackDPI;

            //Sets low DPI for reduce mistakes
            ScriptsUtilities.SetLowDPI();

            su.DelayBetweenAnyOperation = 20;

            su.SendCommand("/efekty");
            su.Sleep(200);
            su.MouseMove(data.Coordinates.EffectsX, data.Coordinates.EffectsY);
            su.SendMouseButton(MouseButtons.Left);
        }
    }
}
