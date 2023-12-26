using SC_Data;
using SC_Scripts.Scripts_Helpers;

namespace SC_Scripts.Scripts
{
    public partial class Scripts
    {
        public static void Mathew(ScriptsUtilities su)
        {
            Data data = DataProvider.Get();

            //Backs DPI on end of script
            ScriptsSetup.GetScriptByName("Mathew").EndWithMethod += ScriptsUtilities.BackDPI;

            //Sets high DPI for faster work
            ScriptsUtilities.SetHighDPI();

            su.DelayBetweenAnyOperation = 10;

            while (true)
            {
                su.SendKey(data.SlotsBinds.Pickaxe);

                su.HoldMouseButton(MouseButtons.Left, true);

                if (data.Settings.PickaxeType == 1) //6/3/3
                    su.Sleep(150);
                if (data.Settings.PickaxeType == 2) //5/3/3
                    su.Sleep(400);
                if (data.Settings.PickaxeType == 3) //4/3/3
                    su.Sleep(430);

                su.HoldMouseButton(MouseButtons.Left, false);

                //Look down
                for (int i = 0; i < 10; i++)
                    su.MouseMove(700, 1000); 

                //Place block
                su.SendKey(data.SlotsBinds.Block);
                su.HoldKey(Keys.Space, true);
                su.HoldMouseButton(MouseButtons.Right, true);
                su.Sleep(350);
                su.HoldKey(Keys.Space, false);
                su.HoldMouseButton(MouseButtons.Right, false);

                //Look up
                for (int i = 0; i < 10; i++)
                    su.MouseMove(700, 0); 
            }

        }
    }
}
