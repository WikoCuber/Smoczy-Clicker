using SC_Data;
using SC_Scripts.Scripts_Helpers;

namespace SC_Scripts.Scripts
{
    public partial class Scripts
    {
        public static void Drawing(ScriptsUtilities su)
        {
            Data data = DataProvider.Get();

            //Returns when subscript "Drawing" is disabled
            if (!data.Settings.IsDrawingOn)
                return;

            //Backs DPI on end of script
            ScriptsSetup.GetScriptByName("Drawing").EndWithMethod += ScriptsUtilities.BackDPI;

            //Sets low DPI for reduce mistakes
            ScriptsUtilities.SetLowDPI();

            su.DelayBetweenAnyOperation = 20;

            su.SendCommand("/schowek");
            su.Sleep(200);
            su.MouseMove(data.Coordinates.DrawingX, data.Coordinates.DrawingY);
            su.SendMouseButton(MouseButtons.Left);
            su.SendKey(Keys.Escape);
        }
    }
}
