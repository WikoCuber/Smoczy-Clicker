using SC_Data;
using SC_Scripts.Utilities;

namespace SC_Scripts.Scripts
{
    public static class VoidScript
    {
        public static void Void(ScriptUtility su)
        {
            Data data = DataProvider.Get();
            Bitmap? bitmap = null; //For intelligent void

            //First slot
            int X = data.Coordinates.LeftX;
            int Y = data.Coordinates.LeftY;

            //Distance between one slot
            int slotX = (data.Coordinates.RightX - data.Coordinates.LeftX) / 8;
            int slotY = (data.Coordinates.RightY - data.Coordinates.LeftY) / 5;

            su.DelayBetweenAnyOperation = data.Delays.Void;

            su.SendCommand("/otchlan");
            su.Sleep(200);
            su.SendKey(Keys.T); //Opens chat when void aren't open
            su.HoldKey(Keys.LControlKey, true);

            //Takes screenshot
            if (data.Settings.IsIntelligentVoid)
            {
                su.MouseMove(10, 10);
                su.Sleep(500);
                bitmap = ScreenUtility.CaptureFromScreen();
            }

            for (int i = 0; i < 6; i++) //Rows
            {
                for (int j = 0; j < 9; j++) //Columns
                {
                    if (data.Settings.IsIntelligentVoid)
                    {
                        Color c = ScreenUtility.GetColorFromBitmap(new Point(X, Y + 1), bitmap!); //Checks color of item
                        if (c.R < 10 && c.G < 10 && c.B < 10) //Drop only black item
                        {
                            su.MouseMove(X, Y);
                            su.SendKey(data.SlotsBinds.Drop);
                        }
                        X += slotX;
                    }
                    else
                    {
                        su.MouseMove(X, Y);
                        su.SendKey(data.SlotsBinds.Drop);
                        X += slotX;
                    }
                }
                X = data.Coordinates.LeftX;
                Y += slotY;
            }
            su.HoldKey(Keys.LControlKey, false);
        }
    }
}
