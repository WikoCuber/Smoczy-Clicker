using SC_Scripts.Scripts_Managment;
using SC_Scripts.Utilities;

namespace SC_UI.Helpers
{
    public static class CoordniateHelper
    {
        public static Point Get(Button button, Form form)
        {
            form.Enabled = false;
            string oldText = button.Text;
            button.Text = "......";
            ScriptUtility su = new();
            Keys currentKey = ScriptsHotkey.GetKey();

            while (currentKey != Keys.F12 && currentKey != Keys.Escape)
            {
                //Move cursor when arrows was pressed
                if (currentKey == Keys.Up)
                    su.MouseMove(Cursor.Position.X, Cursor.Position.Y - 1);
                if (currentKey == Keys.Down)
                    su.MouseMove(Cursor.Position.X, Cursor.Position.Y + 1);
                if (currentKey == Keys.Right)
                    su.MouseMove(Cursor.Position.X + 1, Cursor.Position.Y);
                if (currentKey == Keys.Left)
                    su.MouseMove(Cursor.Position.X - 1, Cursor.Position.Y);

                currentKey = ScriptsHotkey.GetKey();
            }

            Point p = Cursor.Position;

            if (currentKey == Keys.Escape)
            {
                button.Text = oldText;
                p = new(0, 0); //0, 0 point to cancel
            }
            else
                button.Text = Cursor.Position.X + "; " + Cursor.Position.Y;

            form.Enabled = true;

            return p;
        }
    }
}
