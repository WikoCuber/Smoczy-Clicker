using SC_Data;
using SC_Scripts.Scripts_Helpers;

namespace SC_Scripts.Scripts
{
    public partial class Scripts
    {
        public static void FishingRod(ScriptsUtilities su)
        {
            Data data = DataProvider.Get();

            //Returns when subscript "FishingRod" is disabled
            if (!data.Settings.IsFishingRodOn)
                return;

            su.DelayBetweenAnyOperation = data.Delays.FishingRod;

            su.SendKey(data.SlotsBinds.FishingRod);
            su.SendMouseButton(MouseButtons.Right);
            su.SendKey(data.SlotsBinds.Sword);
        }
    }
}
