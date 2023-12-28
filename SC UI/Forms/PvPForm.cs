using SC_Data;
using SC_Scripts.Scripts_Helpers;
using SC_UI.Helpers;
using System.Windows.Forms;

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
            leftMacroBindButton.Text = ConvertHeleper.KeysToString(_data.ScriptsBinds.LeftMacro);
            rightMacroBindButton.Text = ConvertHeleper.KeysToString(_data.ScriptsBinds.RightMacro);
            armor1BindButton.Text = ConvertHeleper.KeysToString(_data.ScriptsBinds.Armor1);
            armor2BindButton.Text = ConvertHeleper.KeysToString(_data.ScriptsBinds.Armor2);
            armor3BindButton.Text = ConvertHeleper.KeysToString(_data.ScriptsBinds.Armor3);
            snowballBindButton.Text = ConvertHeleper.KeysToString(_data.ScriptsBinds.Snowball);
            fishingRodBindButton.Text = ConvertHeleper.KeysToString(_data.ScriptsBinds.FishingRod);

            leftMacroCpsNumeric.Value = _data.Macro.LeftCps;
            rightMacroCpsNumeric.Value = _data.Macro.RightCps;
            armorDelayNumeric.Value = _data.Delays.Armor;
            snowballDelayNumeric.Value = _data.Delays.Snowball;
            fishingRodDelayNumeric.Value = _data.Delays.FishingRod;

            armor1OnCheckBox.Checked = _data.Settings.IsArmor1On;
            armor2OnCheckBox.Checked = _data.Settings.IsArmor2On;
            armor3OnCheckBox.Checked = _data.Settings.IsArmor3On;
            snowballOnCheckBox.Checked = _data.Settings.IsSnowballOn;
            fishingRodOnCheckBox.Checked = _data.Settings.IsFishingRodOn;

            if (_data.Macro.RightType == 1)
                rightMacroOCRadioButton.Checked = true;
            else if (_data.Macro.RightType == 2)
                rightMacroPCRadioButton.Checked = true;
            else if (_data.Macro.RightType == 3)
                rightMacroDHRadioButton.Checked = true;

            if (_data.Macro.LeftType == 1)
                leftMacroOCRadioButton.Checked = true;
            else if (_data.Macro.LeftType == 2)
                leftMacroPCRadioButton.Checked = true;
            else if (_data.Macro.LeftType == 3)
                leftMacroDHRadioButton.Checked = true;
        }

        private void UpdateImages()
        {
            if (ScriptsSetup.GetScriptByName("Armor1")!.IsActive)
                armorStatusPicBox.BackgroundImage = Properties.Resources.Yes;
            else
                armorStatusPicBox.BackgroundImage = Properties.Resources.No;
            if (ScriptsSetup.GetScriptByName("Snowball")!.IsActive)
                snowballFishingRodStatusPicBox.BackgroundImage = Properties.Resources.Yes;
            else
                snowballFishingRodStatusPicBox.BackgroundImage = Properties.Resources.No;
            if (ScriptsSetup.GetScriptByName("LeftMacro")!.IsActive)
                macroStatusPicBox.BackgroundImage = Properties.Resources.Yes;
            else
                macroStatusPicBox.BackgroundImage = Properties.Resources.No;
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
            else if (button == leftMacroBindButton)
                _data.ScriptsBinds.LeftMacro = key;
            else if (button == rightMacroBindButton)
                _data.ScriptsBinds.RightMacro = key;
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
            if (radioButton == leftMacroOCRadioButton && leftMacroOCRadioButton.Checked)
            {
                _data.Macro.LeftType = 1;
                ScriptsSetup.GetScriptByName("LeftMacro")!.CaptureType = ScriptsSetup.CaptureTypes.KEY_DOWN;
            }
            else if (radioButton == leftMacroPCRadioButton && leftMacroPCRadioButton.Checked)
            {
                _data.Macro.LeftType = 2;
                ScriptsSetup.GetScriptByName("LeftMacro")!.CaptureType = ScriptsSetup.CaptureTypes.KEY_PRESS;
            }
            else if (radioButton == leftMacroDHRadioButton && leftMacroDHRadioButton.Checked)
            {
                _data.Macro.LeftType = 3;
                ScriptsSetup.GetScriptByName("LeftMacro")!.CaptureType = ScriptsSetup.CaptureTypes.KEYSTROKE_PRESS;
            }
            else if (radioButton == rightMacroOCRadioButton && rightMacroOCRadioButton.Checked)
            {
                _data.Macro.RightType = 1;
                ScriptsSetup.GetScriptByName("RightMacro")!.CaptureType = ScriptsSetup.CaptureTypes.KEY_DOWN;
            }
            else if (radioButton == rightMacroPCRadioButton && rightMacroPCRadioButton.Checked)
            {
                _data.Macro.RightType = 2;
                ScriptsSetup.GetScriptByName("RightMacro")!.CaptureType = ScriptsSetup.CaptureTypes.KEY_PRESS;
            }
            else if (radioButton == rightMacroDHRadioButton && rightMacroDHRadioButton.Checked)
            {
                _data.Macro.RightType = 3;
                ScriptsSetup.GetScriptByName("RightMacro")!.CaptureType = ScriptsSetup.CaptureTypes.KEYSTROKE_PRESS;
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
        private void leftMacroCpsNumeric_ValueChanged(object sender, EventArgs e)
        {
            _data.Macro.LeftCps = (int)leftMacroCpsNumeric.Value;
            SaveFile.Save();
        }
        private void rightMacroCpsNumeric_ValueChanged(object sender, EventArgs e)
        {
            _data.Macro.RightCps = (int)rightMacroCpsNumeric.Value;
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
        private void leftMacroOCRadioButton_CheckedChanged(object sender, EventArgs e) => ChangeRadioButton(leftMacroOCRadioButton);
        private void leftMacroPCRadioButton_CheckedChanged(object sender, EventArgs e) => ChangeRadioButton(leftMacroPCRadioButton);
        private void leftMacroDHRadioButton_CheckedChanged(object sender, EventArgs e) => ChangeRadioButton(leftMacroDHRadioButton);
        private void rightMacroOCRadioButton_CheckedChanged(object sender, EventArgs e) => ChangeRadioButton(rightMacroOCRadioButton);
        private void rightMacroPCRadioButton_CheckedChanged(object sender, EventArgs e) => ChangeRadioButton(rightMacroPCRadioButton);
        private void rightMacroDHRadioButton_CheckedChanged(object sender, EventArgs e) => ChangeRadioButton(rightMacroDHRadioButton);

        //Binds buttons
        private void snowballBindButton_Click(object sender, EventArgs e) => Task.Run(() => SetBind(snowballBindButton, "Snowball"));
        private void fishingRodBindButton_Click(object sender, EventArgs e) => Task.Run(() => SetBind(fishingRodBindButton, "FishingRod"));
        private void rightMacroBindButton_Click(object sender, EventArgs e) => Task.Run(() => SetBind(rightMacroBindButton, "RightMacro"));
        private void leftMacroBindButton_Click(object sender, EventArgs e) => Task.Run(() => SetBind(leftMacroBindButton, "LeftMacro"));
        private void armor1BindButton_Click(object sender, EventArgs e) => Task.Run(() => SetBind(armor1BindButton, "Armor1"));
        private void armor2BindButton_Click(object sender, EventArgs e) => Task.Run(() => SetBind(armor2BindButton, "Armor2"));
        private void armor3BindButton_Click(object sender, EventArgs e) => Task.Run(() => SetBind(armor3BindButton, "Armor3"));

        //Scripts status buttons
        private void armorStatusButton_Click(object sender, EventArgs e)
        {
            ScriptsSetup.GetScriptByName("Armor1")!.ToggleActiveState();
            ScriptsSetup.GetScriptByName("Armor2")!.ToggleActiveState();
            ScriptsSetup.GetScriptByName("Armor3")!.ToggleActiveState();
            UpdateImages();
        }
        private void snowballFishingRodStatusButton_Click(object sender, EventArgs e)
        {
            ScriptsSetup.GetScriptByName("Snowball")!.ToggleActiveState();
            ScriptsSetup.GetScriptByName("FishingRod")!.ToggleActiveState();
            UpdateImages();
        }
        private void macroStatusButton_Click(object sender, EventArgs e)
        {
            ScriptsSetup.GetScriptByName("LeftMacro")!.ToggleActiveState();
            ScriptsSetup.GetScriptByName("RightMacro")!.ToggleActiveState();
            UpdateImages();
        }
    }
}
