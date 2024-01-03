using SC_Scripts.Messages;

namespace SC_Scripts.Helpers
{
    public static class ConvertHelper
    {
        //Changes MouseButton to Key.
        public static Keys MouseButtonsToKeys(MouseButtons mouseButton)
        {
            return mouseButton switch
            {
                MouseButtons.Left => Keys.LButton,
                MouseButtons.Right => Keys.RButton,
                MouseButtons.Middle => Keys.MButton,
                MouseButtons.XButton1 => Keys.XButton1,
                MouseButtons.XButton2 => Keys.XButton2,
                _ => Keys.None
            };
        }

        //Changes Key to MouseButton. MouseButtons.None for unknow mouseButton
        public static MouseButtons KeysToMouseButtons(Keys key)
        {
            return key switch
            {
                Keys.LButton => MouseButtons.Left,
                Keys.RButton => MouseButtons.Right,
                Keys.MButton => MouseButtons.Middle,
                Keys.XButton1 => MouseButtons.XButton1,
                Keys.XButton2 => MouseButtons.XButton2,
                _ => MouseButtons.None
            };
        }

        //Changes MouseButton to windows message
        public static int MouseButtonToMsg(MouseButtons button, bool isHold, bool isBackground)
        {
            int msg;

            if (isBackground)
            {
                msg = button switch
                {
                    MouseButtons.Left => 0x0201,
                    MouseButtons.Right => 0x0204,
                    MouseButtons.Middle => 0x0207,
                    MouseButtons.XButton1 => 0x020B,
                    MouseButtons.XButton2 => 0x020B,
                    _ => 0
                };

                if (isHold)
                    msg++;
            }
            else
            {
                msg = button switch
                {
                    MouseButtons.Left => 0x0004,
                    MouseButtons.Right => 0x0010,
                    MouseButtons.Middle => 0x0040,
                    MouseButtons.XButton1 => 0x0100,
                    MouseButtons.XButton2 => 0x0100,
                    _ => 0
                };

                if (isHold)
                    msg /= 2;
            }

            return msg;
        }

        //Change char to key and modifierKey
        public static (Keys key, Keys modifierKey) CharToKeys(char letter)
        {
            Keys modifierKey = Keys.None;
            Keys key;

            switch (letter)
            {
                case '/':
                    modifierKey = Keys.RShiftKey;
                    key = Keys.OemQuestion;
                    break;
                case '|':
                    modifierKey = Keys.RShiftKey;
                    key = Keys.OemPipe;
                    break;
                case ':':
                    modifierKey = Keys.RShiftKey;
                    key = Keys.Oem1;
                    break;
                case '!':
                    modifierKey = Keys.RShiftKey;
                    key = Keys.D1;
                    break;
                case '@':
                    modifierKey = Keys.RShiftKey;
                    key = Keys.D2;
                    break;
                case '#':
                    modifierKey = Keys.RShiftKey;
                    key = Keys.D3;
                    break;
                case '$':
                    modifierKey = Keys.RShiftKey;
                    key = Keys.D4;
                    break;
                case '%':
                    modifierKey = Keys.RShiftKey;
                    key = Keys.D5;
                    break;
                case '^':
                    modifierKey = Keys.RShiftKey;
                    key = Keys.D6;
                    break;
                case '&':
                    modifierKey = Keys.RShiftKey;
                    key = Keys.D7;
                    break;
                case '*':
                    modifierKey = Keys.RShiftKey;
                    key = Keys.D8;
                    break;
                case '(':
                    modifierKey = Keys.RShiftKey;
                    key = Keys.D9;
                    break;
                case ')':
                    modifierKey = Keys.RShiftKey;
                    key = Keys.D0;
                    break;
                case '-':
                    key = Keys.OemMinus;
                    break;
                case '+':
                    key = Keys.Oemplus;
                    break;
                case ' ':
                    key = Keys.Space;
                    break;
                case '.':
                    key = Keys.OemPeriod;
                    break;
                default:
                    key = Keys.None;
                    break;
            }

            if (int.TryParse(letter.ToString(), out _)) //Is number
                key = (Keys)Enum.Parse(typeof(Keys), "D" + char.ToUpper(letter));
            else if (key == Keys.None) //Key is still none
                key = (Keys)Enum.Parse(typeof(Keys), char.ToUpper(letter).ToString());

            return (key, modifierKey);
        }

        //Makes param to windows backgorund PostMessage
        public static int MakeParam(Keys key, bool isHold)
        {
            int repeatCount = 0, transition = 0, previousState = 0;
            int scanCode = (int)key, extended = 0, context = 0;

            int lParamDown, lParamUp;

            lParamDown = repeatCount | (scanCode << 16) | (extended << 24) |
                         (context << 29) | (previousState << 30) | (transition << 31);

            previousState = 1;
            transition = 1;

            lParamUp = repeatCount | (scanCode << 16) | (extended << 24) |
                       (context << 29) | (previousState << 30) | (transition << 31);

            if (isHold)
                return lParamDown;
            else
                return lParamUp;
        }

        //Change MouseMessage to Keys
        public static Keys MouseMessageToKeys(MouseMessages message, Keys whichXButton)
        {
            Keys key = Keys.None;

            if (message == MouseMessages.WM_LBUTTONDOWN || message == MouseMessages.WM_LBUTTONUP)
                key = Keys.LButton;
            else if (message == MouseMessages.WM_RBUTTONDOWN || message == MouseMessages.WM_RBUTTONUP)
                key = Keys.RButton;
            else if (message == MouseMessages.WM_MBUTTONDOWN || message == MouseMessages.WM_MBUTTONUP)
                key = Keys.MButton;
            else if (message == MouseMessages.WM_XBUTTONDOWN || message == MouseMessages.WM_XBUTTONUP)
                key = whichXButton;

            return key;
        }
    }
}