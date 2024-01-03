using SC_Scripts.Messages;

namespace SC_Scripts.EventArgs
{
    public struct POINT
    {
        public int x;
        public int y;
    }

    public struct MSLLHOOKSTRUCT
    {
        public POINT pt;
        public int mouseData, flags, time;
        public IntPtr dwExtraInfo;
    }

    public class MouseEventArgs : System.EventArgs
    {
        public MouseMessages Message { get; set; }
        public Keys WhichXButton { get; set; } = Keys.None;
        public MouseEventArgs(MSLLHOOKSTRUCT structobj, MouseMessages mouseMessages)
        {
            Message = mouseMessages;

            //Checking is XButton was pressed and sets which 
            if (structobj.mouseData > 0 && structobj.mouseData < 70000)
                WhichXButton = Keys.XButton1;
            else if (structobj.mouseData > 70000)
                WhichXButton = Keys.XButton2;
        }
    }
}
