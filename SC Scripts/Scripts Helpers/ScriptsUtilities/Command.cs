using SC_Data;

namespace SC_Scripts.Scripts_Helpers
{
    public partial class ScriptsUtilities
    {
        public void SendCommand(string command)
        {
            Data data = DataProvider.Get();
            SendKey(data.SlotsBinds.Chat);
            Sleep(data.Delays.Command);

            if(!IsBackground)
                SendKeys.SendWait(command);
            else
            {
                foreach (var letter in command)
                {
                    if (letter == '/')
                    {
                        HoldKey(Keys.RShiftKey, true);
                        SendKey(Keys.OemQuestion);
                        HoldKey(Keys.RShiftKey, false);
                    }
                    else if (letter == '|')
                    {
                        HoldKey(Keys.RShiftKey, true);
                        SendKey(Keys.OemPipe);
                        HoldKey(Keys.RShiftKey, false);
                    }
                    else if (letter == ':')
                    {
                        HoldKey(Keys.RShiftKey, true);
                        SendKey(Keys.Oem1);
                        HoldKey(Keys.RShiftKey, false);
                    }
                    else if (letter == '#')
                    {
                        HoldKey(Keys.RShiftKey, true);
                        SendKey(Keys.D3);
                        HoldKey(Keys.RShiftKey, false);
                    }
                    else if (letter == '-')
                        SendKey(Keys.OemMinus);
                    else if (letter == ' ')
                        SendKey(Keys.Space);
                    else if (letter == '.')
                        SendKey(Keys.OemPeriod); 
                    else if (int.TryParse(command, out _)) //Is number
                        SendKey((Keys)Enum.Parse(typeof(Keys), "D" + command.ToUpper()));
                    else
                        SendKey((Keys)Enum.Parse(typeof(Keys), command.ToUpper()));

                    Sleep(data.Delays.Command);
                }
            }

            SendKey(Keys.Return);
        }
    }
}
