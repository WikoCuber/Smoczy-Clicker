using SC_Data;
using SC_Scripts.Scripts_Managment;
using SC_Scripts.Utilities;

namespace SC_Scripts.Scripts
{
    public static class DrawingScript
    {
        public static void Drawing(ScriptUtility su)
        {
            Data data = DataProvider.Get();

            //Returns when subscript "Drawing" is disabled
            if (!data.Settings.IsDrawingOn)
                return;

            //Backs DPI on end of script
            ScriptsManager.GetScriptByName("Drawing")!.EndWithMethod += DPIUtility.BackDPI;

            //Sets low DPI for reduce mistakes
            DPIUtility.SetLowDPI();

            su.DelayBetweenAnyOperation = 20;

            su.SendCommand("/schowek");
            su.Sleep(200);
            su.MouseMove(data.Coordinates.DrawingX, data.Coordinates.DrawingY);
            su.SendMouseButton(MouseButtons.Left);
            su.SendKey(Keys.Escape);
        }
    }
}
