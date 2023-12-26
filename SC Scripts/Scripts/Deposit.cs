using SC_Data;
using SC_Scripts.Scripts_Helpers;

namespace SC_Scripts.Scripts
{
    public partial class Scripts
    {
        public static void Deposit(ScriptsUtilities su)
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
