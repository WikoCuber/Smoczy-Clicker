using SC_Data;
using SC_Scripts.Scripts_Helpers;
using SC_UI.Helpers;

namespace SC_UI.Forms
{
    public partial class OthersForm : Form
    {
        private readonly Data _data;

        public OthersForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            UpdateImages();

            _data = DataProvider.Get();

            SetStartValues();
        }

        private void SetStartValues()
        {
            effectsOnCheckBox.Checked = _data.Settings.IsEffectsOn;
            drawingOnCheckBox.Checked = _data.Settings.IsDrawingOn;
            intelligentVoidCheckBox.Checked = _data.Settings.IsIntelligentVoid;
            depositDelayNumeric.Value = _data.Delays.Deposit;
            voidDelayNumeric.Value = _data.Delays.Void;
            effectsCoordinateButton.Text = _data.Coordinates.EffectsX + "; " + _data.Coordinates.EffectsY;
            drawingCoordinateButton.Text = _data.Coordinates.DrawingX + "; " + _data.Coordinates.DrawingY;
            depositBindButton.Text = ConvertHelper.KeysToString(_data.ScriptsBinds.Deposit);
            dabingBindButton.Text = ConvertHelper.KeysToString(_data.ScriptsBinds.Dabing);
            altingBindButton.Text = ConvertHelper.KeysToString(_data.ScriptsBinds.Alting);
            mathewBindButton.Text = ConvertHelper.KeysToString(_data.ScriptsBinds.Mathew);
            effectsBindButton.Text = ConvertHelper.KeysToString(_data.ScriptsBinds.Effects);
            drawingBindButton.Text = ConvertHelper.KeysToString(_data.ScriptsBinds.Drawing);
            voidBindButton.Text = ConvertHelper.KeysToString(_data.ScriptsBinds.Void);
            dabingTypeComboBox.SelectedIndex = _data.Settings.DabingType - 1;

            if (_data.Settings.PickaxeType == 1)
                pickaxe6RadioButton.Checked = true;
            else if (_data.Settings.PickaxeType == 2)
                pickaxe5RadioButton.Checked = true;
            else
                pickaxe4RadioButton.Checked = true;
        }

        private void UpdateImages()
        {
            if (ScriptsSetup.GetScriptByName("Deposit")!.IsActive)
                depositStatusPicBox.BackgroundImage = Properties.Resources.Yes;
            else
                depositStatusPicBox.BackgroundImage = Properties.Resources.No;
            if (ScriptsSetup.GetScriptByName("Effects")!.IsActive)
                effectsDrawingStatusPicBox.BackgroundImage = Properties.Resources.Yes;
            else
                effectsDrawingStatusPicBox.BackgroundImage = Properties.Resources.No;
            if (ScriptsSetup.GetScriptByName("Alting")!.IsActive)
                altingStatusPicBox.BackgroundImage = Properties.Resources.Yes;
            else
                altingStatusPicBox.BackgroundImage = Properties.Resources.No;
            if (ScriptsSetup.GetScriptByName("Mathew")!.IsActive)
                mathewStatusPicBox.BackgroundImage = Properties.Resources.Yes;
            else
                mathewStatusPicBox.BackgroundImage = Properties.Resources.No;
            if (ScriptsSetup.GetScriptByName("Dabing")!.IsActive)
                dabingStatusPicBox.BackgroundImage = Properties.Resources.Yes;
            else
                dabingStatusPicBox.BackgroundImage = Properties.Resources.No;
            if (ScriptsSetup.GetScriptByName("Void")!.IsActive)
                voidStatusPicBox.BackgroundImage = Properties.Resources.Yes;
            else
                voidStatusPicBox.BackgroundImage = Properties.Resources.No;
        }

        private void SetCoordinate(Button button)
        {
            Point coordinate = CoordniateHelper.Get(button, this);

            if (coordinate.X == 0 && coordinate.Y == 0)
                return;

            if (button == effectsCoordinateButton)
            {
                _data.Coordinates.EffectsX = coordinate.X;
                _data.Coordinates.EffectsY = coordinate.Y;
            }
            else
            {
                _data.Coordinates.DrawingX = coordinate.X;
                _data.Coordinates.DrawingY = coordinate.Y;
            }

            SaveFile.Save();
        }

        private void SetBind(Button button, string? scriptName = null)
        {
            Keys key = BindHelper.Get(button, this, scriptName);

            if (key == Keys.Escape)
                return;

            if (button == altingBindButton)
                _data.ScriptsBinds.Alting = key;
            else if (button == voidBindButton)
                _data.ScriptsBinds.Void = key;
            else if (button == depositBindButton)
                _data.ScriptsBinds.Deposit = key;
            else if (button == effectsBindButton)
                _data.ScriptsBinds.Effects = key;
            else if (button == drawingBindButton)
                _data.ScriptsBinds.Drawing = key;
            else if (button == mathewBindButton)
                _data.ScriptsBinds.Mathew = key;
            else if (button == dabingBindButton)
                _data.ScriptsBinds.Dabing = key;

            SaveFile.Save();
        }

        private void ChangeRadioButton(RadioButton radioButton)
        {
            if (radioButton == pickaxe6RadioButton && pickaxe6RadioButton.Checked)
                _data.Settings.PickaxeType = 1;
            else if (radioButton == pickaxe5RadioButton && pickaxe5RadioButton.Checked)
                _data.Settings.PickaxeType = 2;
            else if (radioButton == pickaxe4RadioButton && pickaxe4RadioButton.Checked)
                _data.Settings.PickaxeType = 3;

            SaveFile.Save();
        }

        //Navigation buttons
        private void miningNavButton_Click(object sender, EventArgs e) => Navigation.ChangeForm(FormType.Mining, this);
        private void pvpNavButton_Click(object sender, EventArgs e) => Navigation.ChangeForm(FormType.PvP, this);
        private void bindsNavButton_Click(object sender, EventArgs e) => Navigation.ChangeForm(FormType.Binds, this);
        private void settingsNavButton_Click(object sender, EventArgs e) => Navigation.ChangeForm(FormType.Settings, this);

        //Coordinates buttons
        private void effectsCoordinateButtons_Click(object sender, EventArgs e) => Task.Run(() => SetCoordinate(effectsCoordinateButton));
        private void drawingCoordinateButtons_Click(object sender, EventArgs e) => Task.Run(() => SetCoordinate(drawingCoordinateButton));

        //Radio buttons
        private void pickaxe6RadioButton_CheckedChanged(object sender, EventArgs e) => ChangeRadioButton(pickaxe6RadioButton);
        private void pickaxe5RadioButton_CheckedChanged(object sender, EventArgs e) => ChangeRadioButton(pickaxe5RadioButton);
        private void pickaxe4RadioButton_CheckedChanged(object sender, EventArgs e) => ChangeRadioButton(pickaxe4RadioButton);

        //Check boxes
        private void drawingOnCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _data.Settings.IsDrawingOn = drawingOnCheckBox.Checked;
            SaveFile.Save();
        }
        private void effectsOnCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _data.Settings.IsEffectsOn = effectsOnCheckBox.Checked;
            SaveFile.Save();
        }
        private void intelligentVoidCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _data.Settings.IsIntelligentVoid = intelligentVoidCheckBox.Checked;
            SaveFile.Save();
        }

        //Numerics
        private void depositDelayNumeric_ValueChanged(object sender, EventArgs e)
        {
            _data.Delays.Deposit = (int)depositDelayNumeric.Value;
            SaveFile.Save();
        }
        private void voidDelayNumeric_ValueChanged(object sender, EventArgs e)
        {
            _data.Delays.Void = (int)voidDelayNumeric.Value;
            SaveFile.Save();
        }

        //Binds buttons
        private void depositBindButton_Click(object sender, EventArgs e) => Task.Run(() => SetBind(depositBindButton, "Deposit"));
        private void dabingBindButton_Click(object sender, EventArgs e) => Task.Run(() => SetBind(dabingBindButton, "Dabing"));
        private void altingBindButton_Click(object sender, EventArgs e) => Task.Run(() => SetBind(altingBindButton, "Alting"));
        private void mathewBindButton_Click(object sender, EventArgs e) => Task.Run(() => SetBind(mathewBindButton, "Mathew"));
        private void effectsBindButton_Click(object sender, EventArgs e) => Task.Run(() => SetBind(effectsBindButton, "Effects"));
        private void drawingBindButton_Click(object sender, EventArgs e) => Task.Run(() => SetBind(drawingBindButton, "Drawing"));
        private void voidBindButton_Click(object sender, EventArgs e) => Task.Run(() => SetBind(voidBindButton, "Void"));

        //Scripts status buttons
        private void depositStatusButton_Click(object sender, EventArgs e)
        {
            ScriptsSetup.GetScriptByName("Deposit")!.ToggleActiveState();
            UpdateImages();
        }
        private void effectsDrawingStatusButton_Click(object sender, EventArgs e)
        {
            ScriptsSetup.GetScriptByName("Effects")!.ToggleActiveState();
            ScriptsSetup.GetScriptByName("Drawing")!.ToggleActiveState();
            UpdateImages();
        }
        private void altingStatusButton_Click(object sender, EventArgs e)
        {
            ScriptsSetup.GetScriptByName("Alting")!.ToggleActiveState();
            UpdateImages();
        }
        private void mathewStatusButton_Click(object sender, EventArgs e)
        {
            ScriptsSetup.GetScriptByName("Mathew")!.ToggleActiveState();
            UpdateImages();
        }
        private void dabingStatusButton_Click(object sender, EventArgs e)
        {
            ScriptsSetup.GetScriptByName("Dabing")!.ToggleActiveState();
            UpdateImages();
        }
        private void voidStatusButton_Click(object sender, EventArgs e)
        {
            ScriptsSetup.GetScriptByName("Void")!.ToggleActiveState();
            UpdateImages();
        }

        //Combo box
        private void dabingTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _data.Settings.DabingType = dabingTypeComboBox.SelectedIndex + 1;
            SaveFile.Save();
        }
    }
}
