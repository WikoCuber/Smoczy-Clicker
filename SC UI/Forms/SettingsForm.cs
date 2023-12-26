using SC_Data;
using SC_Scripts.Scripts_Helpers;

namespace SC_UI.Forms
{
    public partial class SettingsForm : Form
    {
        private readonly ScriptsUtilities su = new();
        private readonly Data _data;

        public SettingsForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            _data = DataProvider.Get();

            #region Start Values
            backgroundDelayNumeric.Value = _data.Delays.Backgorund;
            commandDelayNumeric.Value = _data.Delays.Command;
            leftButton.Text = _data.Coordinates.LeftX + "; " + _data.Coordinates.LeftX;
            rightButton.Text = _data.Coordinates.RightX + "; " + _data.Coordinates.RightX;
            #endregion
        }

        #region Navigate
        private void miningButton_Click(object sender, EventArgs e)
        {
            _data.CurrentFormType = FormType.Mining;
            Close();
        }

        private void pvpButton_Click(object sender, EventArgs e)
        {
            _data.CurrentFormType = FormType.PvP;
            Close();
        }

        private void othersButton_Click(object sender, EventArgs e)
        {
            _data.CurrentFormType = FormType.Others;
            Close();
        }

        private void bindsButton_Click(object sender, EventArgs e)
        {
            _data.CurrentFormType = FormType.Binds;
            Close();
        }
        #endregion

        private void SetCoordinate(Button button)
        {
            Enabled = false;
            string oldText = button.Text;
            button.Text = "......";
            Keys currentKey = ScriptsSetup.GetKey();

            while (currentKey != Keys.F12 && currentKey != Keys.Escape)
            {
                //Move cursor when arrows was pressed
                if (currentKey == Keys.Up)
                    su.MouseMove(MousePosition.X, MousePosition.Y - 1);
                if (currentKey == Keys.Down)
                    su.MouseMove(MousePosition.X, MousePosition.Y + 1);
                if (currentKey == Keys.Right)
                    su.MouseMove(MousePosition.X + 1, MousePosition.Y);
                if (currentKey == Keys.Left)
                    su.MouseMove(MousePosition.X - 1, MousePosition.Y);

                currentKey = ScriptsSetup.GetKey();
            }

            if (currentKey != Keys.Escape)
            {
                Point p;
                p = Cursor.Position;

                if (button == leftButton)
                {
                    _data.Coordinates.LeftX = p.X;
                    _data.Coordinates.LeftY = p.Y;
                }
                else
                {
                    _data.Coordinates.RightX = p.X;
                    _data.Coordinates.RightY = p.Y;
                }

                button.Text = p.X + "; " + p.X;
                SaveFile.Save();
            }
            else
                button.Text = oldText;
            
            Enabled = true;
        }

        private void leftButton_Click(object sender, EventArgs e) => Task.Run(() => SetCoordinate(leftButton));

        private void rightButton_Click(object sender, EventArgs e) => Task.Run(() => SetCoordinate(rightButton));

        private void backgroundDelayNumeric_KeyUp(object sender, KeyEventArgs e)
        {
            _data.Delays.Backgorund = (int)backgroundDelayNumeric.Value;
            SaveFile.Save();
        }

        private void commandDelayNumeric_KeyUp(object sender, KeyEventArgs e)
        {
            _data.Delays.Command = (int)commandDelayNumeric.Value;
            SaveFile.Save();
        }

        private void backgroundDelayNumeric_ValueChanged(object sender, EventArgs e) => backgroundDelayNumeric_KeyUp(sender, new KeyEventArgs(Keys.None));

        private void commandDelayNumeric_ValueChanged(object sender, EventArgs e) => commandDelayNumeric_KeyUp(sender, new KeyEventArgs(Keys.None));
    }
}
