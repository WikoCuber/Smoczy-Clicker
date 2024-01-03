using SC_Data;
using SC_Scripts.Scripts_Managment;
using SC_UI.Helpers;

namespace SC_UI.Forms
{
    public partial class PvPForm : Form
    {
        private readonly Data _data;

        public PvPForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            UpdateImages();

            _data = DataProvider.Get();

            SetStartValues();
        }

        private void SetStartValues()
        {
            leftClickerBindButton.Text = ConvertHelper.KeysToString(_data.ScriptsBinds.LeftClicker);
            rightClickerBindButton.Text = ConvertHelper.KeysToString(_data.ScriptsBinds.RightClicker);
            armor1BindButton.Text = ConvertHelper.KeysToString(_data.ScriptsBinds.Armor1);
            armor2BindButton.Text = ConvertHelper.KeysToString(_data.ScriptsBinds.Armor2);
            armor3BindButton.Text = ConvertHelper.KeysToString(_data.ScriptsBinds.Armor3);
            snowballBindButton.Text = ConvertHelper.KeysToString(_data.ScriptsBinds.Snowball);
            fishingRodBindButton.Text = ConvertHelper.KeysToString(_data.ScriptsBinds.FishingRod);

            leftClickerCpsNumeric.Value = _data.Clicker.LeftCps;
            rightClickerCpsNumeric.Value = _data.Clicker.RightCps;
            armorDelayNumeric.Value = _data.Delays.Armor;
            snowballDelayNumeric.Value = _data.Delays.Snowball;
            fishingRodDelayNumeric.Value = _data.Delays.FishingRod;

            armor1OnCheckBox.Checked = _data.Settings.IsArmor1On;
            armor2OnCheckBox.Checked = _data.Settings.IsArmor2On;
            armor3OnCheckBox.Checked = _data.Settings.IsArmor3On;
            snowballOnCheckBox.Checked = _data.Settings.IsSnowballOn;
            fishingRodOnCheckBox.Checked = _data.Settings.IsFishingRodOn;

            if (_data.Clicker.RightType == 1)
                rightClickerOCRadioButton.Checked = true;
            else if (_data.Clicker.RightType == 2)
                rightClickerPCRadioButton.Checked = true;
            else if (_data.Clicker.RightType == 3)
                rightClickerDHRadioButton.Checked = true;

            if (_data.Clicker.LeftType == 1)
                leftClickerOCRadioButton.Checked = true;
            else if (_data.Clicker.LeftType == 2)
                leftClickerPCRadioButton.Checked = true;
            else if (_data.Clicker.LeftType == 3)
                leftClickerDHRadioButton.Checked = true;
        }

        private void UpdateImages()
        {
            if (ScriptsManager.GetScriptByName("Armor1")!.IsActive)
                armorStatusPicBox.BackgroundImage = Properties.Resources.Yes;
            else
                armorStatusPicBox.BackgroundImage = Properties.Resources.No;
            if (ScriptsManager.GetScriptByName("Snowball")!.IsActive)
                snowballFishingRodStatusPicBox.BackgroundImage = Properties.Resources.Yes;
            else
                snowballFishingRodStatusPicBox.BackgroundImage = Properties.Resources.No;
            if (ScriptsManager.GetScriptByName("LeftClicker")!.IsActive)
                clickerStatusPicBox.BackgroundImage = Properties.Resources.Yes;
            else
                clickerStatusPicBox.BackgroundImage = Properties.Resources.No;
        }

        private void SetBind(Button button, string? scriptName = null)
        {
            Keys key = BindHelper.Get(button, this, scriptName);

            if (key == Keys.Escape)
                return;

            if (button == snowballBindButton)
                _data.ScriptsBinds.Snowball = key;
            else if (button == fishingRodBindButton)
                _data.ScriptsBinds.FishingRod = key;
            else if (button == leftClickerBindButton)
                _data.ScriptsBinds.LeftClicker = key;
            else if (button == rightClickerBindButton)
                _data.ScriptsBinds.RightClicker = key;
            else if (button == armor1BindButton)
                _data.ScriptsBinds.Armor1 = key;
            else if (button == armor2BindButton)
                _data.ScriptsBinds.Armor2 = key;
            else if (button == armor3BindButton)
                _data.ScriptsBinds.Armor3 = key;

            SaveFile.Save();
        }

        private void ChangeRadioButton(RadioButton radioButton)
        {
            if (radioButton == leftClickerOCRadioButton && leftClickerOCRadioButton.Checked)
            {
                _data.Clicker.LeftType = 1;
                ScriptsManager.GetScriptByName("LeftClicker")!.CaptureType = CaptureTypes.KEY_DOWN;
            }
            else if (radioButton == leftClickerPCRadioButton && leftClickerPCRadioButton.Checked)
            {
                _data.Clicker.LeftType = 2;
                ScriptsManager.GetScriptByName("LeftClicker")!.CaptureType = CaptureTypes.KEY_PRESS;
            }
            else if (radioButton == leftClickerDHRadioButton && leftClickerDHRadioButton.Checked)
            {
                _data.Clicker.LeftType = 3;
                ScriptsManager.GetScriptByName("LeftClicker")!.CaptureType = CaptureTypes.KEYSTROKE_PRESS;
            }
            else if (radioButton == rightClickerOCRadioButton && rightClickerOCRadioButton.Checked)
            {
                _data.Clicker.RightType = 1;
                ScriptsManager.GetScriptByName("RightClicker")!.CaptureType = CaptureTypes.KEY_DOWN;
            }
            else if (radioButton == rightClickerPCRadioButton && rightClickerPCRadioButton.Checked)
            {
                _data.Clicker.RightType = 2;
                ScriptsManager.GetScriptByName("RightClicker")!.CaptureType = CaptureTypes.KEY_PRESS;
            }
            else if (radioButton == rightClickerDHRadioButton && rightClickerDHRadioButton.Checked)
            {
                _data.Clicker.RightType = 3;
                ScriptsManager.GetScriptByName("RightClicker")!.CaptureType = CaptureTypes.KEYSTROKE_PRESS;
            }

            SaveFile.Save();
        }

        //Navigation buttons
        private void othersNavButton_Click(object sender, EventArgs e) => Navigation.ChangeForm(FormType.Others, this);
        private void bindsNavButton_Click(object sender, EventArgs e) => Navigation.ChangeForm(FormType.Binds, this);
        private void miningNavButton_Click(object sender, EventArgs e) => Navigation.ChangeForm(FormType.Mining, this);
        private void settingsNavButton_Click(object sender, EventArgs e) => Navigation.ChangeForm(FormType.Settings, this);

        //Check boxes
        private void armor1OnCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _data.Settings.IsArmor1On = armor1OnCheckBox.Checked;
            SaveFile.Save();
        }
        private void armor2OnCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _data.Settings.IsArmor2On = armor2OnCheckBox.Checked;
            SaveFile.Save();
        }
        private void armor3OnCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _data.Settings.IsArmor3On = armor3OnCheckBox.Checked;
            SaveFile.Save();
        }
        private void snowballOnCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _data.Settings.IsSnowballOn = snowballOnCheckBox.Checked;
            SaveFile.Save();
        }
        private void fishingRodOnCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _data.Settings.IsFishingRodOn = fishingRodOnCheckBox.Checked;
            SaveFile.Save();
        }

        //Numerics
        private void leftClickerCpsNumeric_ValueChanged(object sender, EventArgs e)
        {
            _data.Clicker.LeftCps = (int)leftClickerCpsNumeric.Value;
            SaveFile.Save();
        }
        private void rightClickerCpsNumeric_ValueChanged(object sender, EventArgs e)
        {
            _data.Clicker.RightCps = (int)rightClickerCpsNumeric.Value;
            SaveFile.Save();
        }
        private void armorDelayNumeric_ValueChanged(object sender, EventArgs e)
        {
            _data.Delays.Armor = (int)armorDelayNumeric.Value;
            SaveFile.Save();
        }
        private void snowballDelayNumeric_ValueChanged(object sender, EventArgs e)
        {
            _data.Delays.Snowball = (int)snowballDelayNumeric.Value;
            SaveFile.Save();
        }
        private void fishingRodDelayNumeric_ValueChanged(object sender, EventArgs e)
        {
            _data.Delays.FishingRod = (int)fishingRodDelayNumeric.Value;
            SaveFile.Save();
        }

        //Radio buttons
        private void leftClickerOCRadioButton_CheckedChanged(object sender, EventArgs e) => ChangeRadioButton(leftClickerOCRadioButton);
        private void leftClickerPCRadioButton_CheckedChanged(object sender, EventArgs e) => ChangeRadioButton(leftClickerPCRadioButton);
        private void leftClickerDHRadioButton_CheckedChanged(object sender, EventArgs e) => ChangeRadioButton(leftClickerDHRadioButton);
        private void rightClickerOCRadioButton_CheckedChanged(object sender, EventArgs e) => ChangeRadioButton(rightClickerOCRadioButton);
        private void rightClickerPCRadioButton_CheckedChanged(object sender, EventArgs e) => ChangeRadioButton(rightClickerPCRadioButton);
        private void rightClickerDHRadioButton_CheckedChanged(object sender, EventArgs e) => ChangeRadioButton(rightClickerDHRadioButton);

        //Binds buttons
        private void snowballBindButton_Click(object sender, EventArgs e) => Task.Run(() => SetBind(snowballBindButton, "Snowball"));
        private void fishingRodBindButton_Click(object sender, EventArgs e) => Task.Run(() => SetBind(fishingRodBindButton, "FishingRod"));
        private void rightClickerBindButton_Click(object sender, EventArgs e) => Task.Run(() => SetBind(rightClickerBindButton, "RightClicker"));
        private void leftClickerBindButton_Click(object sender, EventArgs e) => Task.Run(() => SetBind(leftClickerBindButton, "LeftClicker"));
        private void armor1BindButton_Click(object sender, EventArgs e) => Task.Run(() => SetBind(armor1BindButton, "Armor1"));
        private void armor2BindButton_Click(object sender, EventArgs e) => Task.Run(() => SetBind(armor2BindButton, "Armor2"));
        private void armor3BindButton_Click(object sender, EventArgs e) => Task.Run(() => SetBind(armor3BindButton, "Armor3"));

        //Scripts status buttons
        private void armorStatusButton_Click(object sender, EventArgs e)
        {
            ScriptsManager.GetScriptByName("Armor1")!.ToggleActiveState();
            ScriptsManager.GetScriptByName("Armor2")!.ToggleActiveState();
            ScriptsManager.GetScriptByName("Armor3")!.ToggleActiveState();
            UpdateImages();
        }
        private void snowballFishingRodStatusButton_Click(object sender, EventArgs e)
        {
            ScriptsManager.GetScriptByName("Snowball")!.ToggleActiveState();
            ScriptsManager.GetScriptByName("FishingRod")!.ToggleActiveState();
            UpdateImages();
        }
        private void clickerStatusButton_Click(object sender, EventArgs e)
        {
            ScriptsManager.GetScriptByName("LeftClicker")!.ToggleActiveState();
            ScriptsManager.GetScriptByName("RightClicker")!.ToggleActiveState();
            UpdateImages();
        }
    }
}
