using SC_Data;
using SC_Scripts.Utilities;

namespace SC_Scripts.Scripts
{
    public static class DepositScript
    {
        public static void Deposit(ScriptUtility su)
        {
            Data data = DataProvider.Get();

            while (true)
            {
                su.HoldKey(Keys.LControlKey, true);
                su.SendKey(data.SlotsBinds.Drop);
                su.Sleep(data.Delays.Deposit);
            }
        }
    }
}
