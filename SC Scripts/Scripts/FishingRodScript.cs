using SC_Data;
using SC_Scripts.Utilities;

namespace SC_Scripts.Scripts
{
    public static class FishingRodScript
    {
        public static void FishingRod(ScriptUtility su)
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
