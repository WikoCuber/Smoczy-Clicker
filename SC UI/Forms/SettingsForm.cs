using SC_Data;
using SC_UI.Helpers;

namespace SC_UI.Forms
{
    public partial class SettingsForm : Form
    {
        private readonly Data _data;

        public SettingsForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            _data = DataProvider.Get();

            SetStartValues();
        }

        private void SetStartValues()
        {
            backgroundDelayNumeric.Value = _data.Delays.Backgorund;
            commandDelayNumeric.Value = _data.Delays.Command;
            leftCoordniateButton.Text = _data.Coordinates.LeftX + "; " + _data.Coordinates.LeftY;
            rightCoordinateButton.Text = _data.Coordinates.RightX + "; " + _data.Coordinates.RightY;
        }

        private void SetCoordinate(Button button)
        {
            Point coordinate = CoordniateHelper.Get(button, this);

            if (coordinate.X == 0 && coordinate.Y == 0)
                return;

            if (button == leftCoordniateButton)
            {
                _data.Coordinates.LeftX = coordinate.X;
                _data.Coordinates.LeftY = coordinate.Y;
            }
            else
            {
                _data.Coordinates.RightX = coordinate.X;
                _data.Coordinates.RightY = coordinate.Y;
            }

            SaveFile.Save();
        }

        //Navigation buttons
        private void miningNavButton_Click(object sender, EventArgs e) => Navigation.ChangeForm(FormType.Mining, this);
        private void pvpNavButton_Click(object sender, EventArgs e) => Navigation.ChangeForm(FormType.PvP, this);
        private void othersNavButton_Click(object sender, EventArgs e) => Navigation.ChangeForm(FormType.Others, this);
        private void bindsNavButton_Click(object sender, EventArgs e) => Navigation.ChangeForm(FormType.Binds, this);

        //Coordinates buttons
        private void leftCoordinateButton_Click(object sender, EventArgs e) => Task.Run(() => SetCoordinate(leftCoordniateButton));
        private void rightCoordinateButton_Click(object sender, EventArgs e) => Task.Run(() => SetCoordinate(rightCoordinateButton));

        //Numerics
        private void backgroundDelayNumeric_ValueChanged(object sender, EventArgs e)
        {
            _data.Delays.Backgorund = (int)backgroundDelayNumeric.Value;
            SaveFile.Save();
        }
        private void commandDelayNumeric_ValueChanged(object sender, EventArgs e)
        {
            _data.Delays.Command = (int)commandDelayNumeric.Value;
            SaveFile.Save();
        }
    }
}
