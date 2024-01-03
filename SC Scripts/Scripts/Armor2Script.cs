using SC_Data;
using SC_Scripts.Scripts_Managment;
using SC_Scripts.Utilities;

namespace SC_Scripts.Scripts
{
    public static class Armor2Script
    {
        public static void Armor2(ScriptUtility su)
        {
            Data data = DataProvider.Get();

            //Returns when subscript "Armor2" is disabled
            if (!data.Settings.IsArmor2On)
                return;

            //Backs DPI on end of script
            ScriptsManager.GetScriptByName("Armor2")!.EndWithMethod += DPIUtility.BackDPI;

            //Set low DPI for reduce mistakes
            DPIUtility.SetLowDPI();

            //First slot
            int X = data.Coordinates.LeftX;
            int Y = data.Coordinates.LeftY;

            //Distance between one slot
            int slotX = (data.Coordinates.RightX - data.Coordinates.LeftX) / 8;
            int slotY = (data.Coordinates.RightY - data.Coordinates.LeftY) / 5;

            //Coordinates of slots in game
            Point helmet = new(X, Y + slotY);
            Point chestplate = new(X, Y + slotY * 2);
            Point leggings = new(X, Y + slotY * 3);
            Point boots = new(X, Y + slotY * 4);
            Point helmetEQ = new(X, (int)(Y + slotY * 6.5));
            Point chestplateEQ = new(X + slotX, (int)(Y + slotY * 6.5));
            Point leggingsEQ = new(X + slotX * 2, (int)(Y + slotY * 6.5));
            Point bootsEQ = new(X + slotX * 3, (int)(Y + slotY * 6.5));

            su.DelayBetweenAnyOperation = data.Delays.Armor;

            su.SendKey(data.SlotsBinds.Eq);
            su.Sleep(data.Delays.Armor);

            su.MouseMove(helmetEQ.X, helmetEQ.Y);
            su.SendMouseButton(MouseButtons.Left);
            su.MouseMove(helmet.X, helmet.Y);
            su.SendMouseButton(MouseButtons.Left);


            su.MouseMove(chestplateEQ.X, chestplateEQ.Y);
            su.SendMouseButton(MouseButtons.Left);
            su.MouseMove(chestplate.X, chestplate.Y);
            su.SendMouseButton(MouseButtons.Left);


            su.MouseMove(leggingsEQ.X, leggingsEQ.Y);
            su.SendMouseButton(MouseButtons.Left);
            su.MouseMove(leggings.X, leggings.Y);
            su.SendMouseButton(MouseButtons.Left);


            su.MouseMove(bootsEQ.X, bootsEQ.Y);
            su.SendMouseButton(MouseButtons.Left);
            su.MouseMove(boots.X, boots.Y);
            su.SendMouseButton(MouseButtons.Left);


            su.MouseMove(helmetEQ.X, helmetEQ.Y);
            su.SendMouseButton(MouseButtons.Left);

            su.SendKey(Keys.Escape);
        }
    }
}
