using SC_Data;
using SC_Scripts.Utilities;

namespace SC_Scripts.Scripts
{
    public static class DabingScript
    {
        public static void Dabing(ScriptUtility su)
        {
            Data data = DataProvider.Get();

            while (true)
            {
                if (data.Settings.DabingType == 1) //Dab type 1 (spam)
                {
                    su.HoldKey(data.SlotsBinds.Dab, true);
                    su.Sleep(200);
                    su.HoldKey(data.SlotsBinds.Dab, false);
                    su.Sleep(200);
                }
                else if (data.Settings.DabingType == 2) //Dab type 2 (hold)
                {
                    su.HoldKey(data.SlotsBinds.Dab, true);
                    su.Sleep(50);
                }
            }
        }
    }
}
