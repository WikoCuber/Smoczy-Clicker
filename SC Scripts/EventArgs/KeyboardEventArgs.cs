using SC_Scripts.Messages;

namespace SC_Scripts.EventArgs
{
    public class KeyboardEventArgs(Keys key, KeyboardMessages keyboardMessages) : System.EventArgs
    {
        public Keys Key { get; set; } = key;
        public KeyboardMessages Message { get; set; } = keyboardMessages;
    }
}
