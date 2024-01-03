using SC_Data;
using SC_Scripts.Scripts_Managment;
using SC_Scripts.Utilities;

namespace SC_Scripts.Scripts
{
    public static class MathewScript
    {
        public static void Mathew(ScriptUtility su)
        {
            Data data = DataProvider.Get();

            //Backs DPI on end of script
            ScriptsManager.GetScriptByName("Mathew")!.EndWithMethod += DPIUtility.BackDPI;

            //Sets high DPI for faster work
            DPIUtility.SetHighDPI();

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
