using SC_Data;
using SC_Scripts.Scripts_Managment;
using SC_Scripts.Utilities;

namespace SC_Scripts.Scripts
{
    public static class EffectsScript
    {
        public static void Effects(ScriptUtility su)
        {
            Data data = DataProvider.Get();

            //Returns when subscript "Effects" is disabled
            if (!data.Settings.IsEffectsOn)
                return;

            //Backs DPI on end of script
            ScriptsManager.GetScriptByName("Effects")!.EndWithMethod += DPIUtility.BackDPI;

            //Sets low DPI for reduce mistakes
            DPIUtility.SetLowDPI();

            su.DelayBetweenAnyOperation = 20;

            su.SendCommand("/efekty");
            su.Sleep(200);
            su.MouseMove(data.Coordinates.EffectsX, data.Coordinates.EffectsY);
            su.SendMouseButton(MouseButtons.Left);
        }
    }
}
