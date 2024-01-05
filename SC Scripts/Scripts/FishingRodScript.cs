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

            su.SendKey(data.SlotsBinds.FishingRod);
            su.Sleep(50);
            su.SendMouseButton(MouseButtons.Right);
            su.Sleep(data.Delays.FishingRod);
            su.SendKey(data.SlotsBinds.Sword);
        }
    }
}
