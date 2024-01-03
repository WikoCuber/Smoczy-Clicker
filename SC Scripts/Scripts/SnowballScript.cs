using SC_Data;
using SC_Scripts.Utilities;

namespace SC_Scripts.Scripts
{
    public static class SnowballScript
    {
        public static void Snowball(ScriptUtility su)
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
