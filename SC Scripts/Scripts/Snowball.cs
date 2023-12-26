using SC_Data;
using SC_Scripts.Scripts_Helpers;

namespace SC_Scripts.Scripts
{
    public partial class Scripts
    {
        public static void Snowball(ScriptsUtilities su)
        {
            Data data = DataProvider.Get();

            //Returns when subscript "Snowball" is disabled
            if (!data.Settings.IsSnowballOn)
                return;

            su.DelayBetweenAnyOperation = data.Delays.Snowball;

            su.SendKey(data.SlotsBinds.Snowball);
            su.SendMouseButton(MouseButtons.Right);
            su.SendKey(data.SlotsBinds.Sword);
        }
    }
}
