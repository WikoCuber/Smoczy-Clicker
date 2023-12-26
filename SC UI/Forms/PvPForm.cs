using SC_Data;
using SC_Scripts.Scripts_Helpers;
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

            #region Satrt Values
            leftBindButton.Text = ScriptsUtilities.KeysToString(_data.ScriptsBinds.LeftMacro);
            rightBindButton.Text = ScriptsUtilities.KeysToString(_data.ScriptsBinds.RightMacro);
            armor1BindButton.Text = ScriptsUtilities.KeysToString(_data.ScriptsBinds.Armor1);
            armor2BindButton.Text = ScriptsUtilities.KeysToString(_data.ScriptsBinds.Armor2);
            armor3BindButton.Text = ScriptsUtilities.KeysToString(_data.ScriptsBinds.Armor3);
            snowballBindButton.Text = ScriptsUtilities.KeysToString(_data.ScriptsBinds.Snowball);
            fishingRodBindButton.Text = ScriptsUtilities.KeysToString(_data.ScriptsBinds.FishingRod);

            leftCpsNumeric.Value = _data.Macro.LeftCps;
            rightCpsNumeric.Value = _data.Macro.RightCps;
            armorDelayNumeric.Value = _data.Delays.Armor;
            snowballDelayNumeric.Value = _data.Delays.Snowball;
            fishingRodDelayNumeric.Value = _data.Delays.FishingRod;

            armor1OnCheckBox.Checked = _data.Settings.IsArmor1On;
            armor2OnCheckBox.Checked = _data.Settings.IsArmor2On;
            armor3OnCheckBox.Checked = _data.Settings.IsArmor3On;
            snowballOnCheckBox.Checked = _data.Settings.IsSnowballOn;
            fishingRodOnCheckBox.Checked = _data.Settings.IsFishingRodOn;

            if (_data.Macro.RightType == 1)
                rightOCRadioButton.Checked = true;
            else if (_data.Macro.RightType == 2)
                rightDHRadioButton.Checked = true;
            else if (_data.Macro.RightType == 3)
                rightPCRadioButton.Checked = true;

            if (_data.Macro.LeftType == 1)
                leftOCRadioButton.Checked = true;
            else if (_data.Macro.LeftType == 2)
                leftDHRadioButton.Checked = true;
            else if (_data.Macro.LeftType == 3)
                leftPCRadioButton.Checked = true;
            #endregion
        }

        #region Navigate
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

        private void miningButton_Click(object sender, EventArgs e)
        {
            _data.CurrentFormType = FormType.Mining;
            Close();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            _data.CurrentFormType = FormType.Settings;
            Close();
        }
        #endregion

        //Sets bind to variable
        private Keys SetBind(Button button, string scriptName = "")
        {
            Enabled = false;
            string oldText = button.Text;
            button.Text = "......";
            Keys currentKey = ScriptsSetup.GetKey();

            if (currentKey != Keys.Escape)
            {
                ScriptsSetup.ScriptInfo? script = ScriptsSetup.GetScriptByName(scriptName);
                if (script != null)
                    script.Key = currentKey;
                button.Text = ScriptsUtilities.KeysToString(currentKey);
            }
            else
                button.Text = oldText;

            Enabled = true;

            return currentKey;
        }

        private void UpdateImages()
        {
            if (ScriptsSetup.GetScriptByName("Armor1")!.IsActive)
                armorPicBox.BackgroundImage = Properties.Resources.Yes;
            else
                armorPicBox.BackgroundImage = Properties.Resources.No;
            if (ScriptsSetup.GetScriptByName("Snowball")!.IsActive)
                snowballPicBox.BackgroundImage = Properties.Resources.Yes;
            else
                snowballPicBox.BackgroundImage = Properties.Resources.No;
            if (ScriptsSetup.GetScriptByName("LeftMacro")!.IsActive)
                macroPicBox.BackgroundImage = Properties.Resources.Yes;
            else
                macroPicBox.BackgroundImage = Properties.Resources.No;
        }

        #region CheckBox

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
        #endregion

        #region Numeric

        private void leftCpsNumeric_KeyUp(object sender, KeyEventArgs e)
        {
            _data.Macro.LeftCps = (int)leftCpsNumeric.Value;
            SaveFile.Save();
        }

        private void rightCpsNumeric_KeyUp(object sender, KeyEventArgs e)
        {
            _data.Macro.RightCps = (int)rightCpsNumeric.Value;
            SaveFile.Save();
        }

        private void armorDelayNumeric_KeyUp(object sender, KeyEventArgs e)
        {
            _data.Delays.Armor = (int)armorDelayNumeric.Value;
            SaveFile.Save();
        }

        private void snowballDelayNumeric_KeyUp(object sender, KeyEventArgs e)
        {
            _data.Delays.Snowball = (int)snowballDelayNumeric.Value;
            SaveFile.Save();
        }

        private void fishingRodDelayNumeric_KeyUp(object sender, KeyEventArgs e)
        {
            _data.Delays.FishingRod = (int)fishingRodDelayNumeric.Value;
            SaveFile.Save();
        }

        private void snowballDelayNumeric_ValueChanged(object sender, EventArgs e) => snowballDelayNumeric_KeyUp(sender, new KeyEventArgs(Keys.None));
        private void fishingRodDelayNumeric_ValueChanged(object sender, EventArgs e) => fishingRodDelayNumeric_KeyUp(sender, new KeyEventArgs(Keys.None));
        private void armorDelayNumeric_ValueChanged(object sender, EventArgs e) => armorDelayNumeric_KeyUp(sender, new KeyEventArgs(Keys.None));
        private void leftCpsNumeric_ValueChanged(object sender, EventArgs e) => leftCpsNumeric_KeyUp(sender, new KeyEventArgs(Keys.None));
        private void rightCpsNumeric_ValueChanged(object sender, EventArgs e) => rightCpsNumeric_KeyUp(sender, new KeyEventArgs(Keys.None));
        #endregion

        #region RadioButton
        private void leftOCRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton)!.Checked)
            {
                _data.Macro.LeftType = 1;
                ScriptsSetup.GetScriptByName("LeftMacro")!.CaptureType = ScriptsSetup.CaptureTypes.KEY_DOWN;
                SaveFile.Save();
            }
        }


        private void leftDHRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton)!.Checked)
            {
                _data.Macro.LeftType = 2;
                ScriptsSetup.GetScriptByName("LeftMacro")!.CaptureType = ScriptsSetup.CaptureTypes.KEYSTROKE_PRESS;
                SaveFile.Save();
            }
        }
        private void leftPCRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton)!.Checked)
            {
                _data.Macro.LeftType = 3;
                ScriptsSetup.GetScriptByName("LeftMacro")!.CaptureType = ScriptsSetup.CaptureTypes.KEY_PRESS;
                SaveFile.Save();
            }
        }

        private void rightOCRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton)!.Checked)
            {
                _data.Macro.RightType = 1;
                ScriptsSetup.GetScriptByName("RightMacro")!.CaptureType = ScriptsSetup.CaptureTypes.KEY_DOWN;
                SaveFile.Save();
            }
        }
        private void rightDHRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton)!.Checked)
            {
                _data.Macro.RightType = 2;
                ScriptsSetup.GetScriptByName("RightMacro")!.CaptureType = ScriptsSetup.CaptureTypes.KEYSTROKE_PRESS;
                SaveFile.Save();
            }
        }

        private void rightPCRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton)!.Checked)
            {
                _data.Macro.RightType = 3;
                ScriptsSetup.GetScriptByName("RightMacro")!.CaptureType = ScriptsSetup.CaptureTypes.KEY_PRESS;
                SaveFile.Save();
            }
        }

        #endregion

        #region New Bind
        private void snowballBindButton_Click(object sender, EventArgs e) => Task.Run(() => {
            Keys key = SetBind(snowballBindButton, "Snowball");
            if (key != Keys.Escape)
            {
                _data.ScriptsBinds.Snowball = key;
                SaveFile.Save();
            }
        });

        private void fishingRodBindButton_Click(object sender, EventArgs e) => Task.Run(() => { 
            Keys key = SetBind(fishingRodBindButton, "FishingRod");
            if (key != Keys.Escape)
            {
                _data.ScriptsBinds.FishingRod = key;
                SaveFile.Save();
            }
        });

        private void armor1BindButton_Click(object sender, EventArgs e) => Task.Run(() => {
            Keys key = SetBind(armor1BindButton, "Armor1");
            if (key != Keys.Escape)
            {
                _data.ScriptsBinds.Armor1 = key;
                SaveFile.Save();
            }
        });

        private void armor2BindButton_Click(object sender, EventArgs e) => Task.Run(() => {
            Keys key = SetBind(armor2BindButton, "Armor2");
            if (key != Keys.Escape)
            {
                _data.ScriptsBinds.Armor2 = key;
                SaveFile.Save();
            }
        });

        private void armor3BindButton_Click(object sender, EventArgs e) => Task.Run(() => {
            Keys key = SetBind(armor3BindButton, "Armor3");
            if (key != Keys.Escape)
            {
                _data.ScriptsBinds.Armor3 = key;
                SaveFile.Save();
            }
        });

        private void rightBindButton_Click(object sender, EventArgs e) => Task.Run(() => {
            Keys key = SetBind(rightBindButton, "RightMacro");
            if (key != Keys.Escape)
            {
                _data.ScriptsBinds.RightMacro = key;
                SaveFile.Save();
            }
        });

        private void leftBindButton_Click(object sender, EventArgs e) => Task.Run(() => {
            Keys key = SetBind(leftBindButton, "LeftMacro");
            if (key != Keys.Escape)
            {
                _data.ScriptsBinds.LeftMacro = key;
                SaveFile.Save();
            }
        });
        #endregion

        #region Scripts Buttons
        private void armorButton_Click(object sender, EventArgs e) { ScriptsSetup.GetScriptByName("Armor1")!.ToggleActiveState(); ScriptsSetup.GetScriptByName("Armor2")!.ToggleActiveState(); ScriptsSetup.GetScriptByName("Armor3")!.ToggleActiveState(); UpdateImages(); }
        private void snowballButton_Click(object sender, EventArgs e) { ScriptsSetup.GetScriptByName("Snowball")!.ToggleActiveState(); ScriptsSetup.GetScriptByName("FishingRod")!.ToggleActiveState(); UpdateImages(); }
        private void macroButton_Click(object sender, EventArgs e) { ScriptsSetup.GetScriptByName("LeftMacro")!.ToggleActiveState(); ScriptsSetup.GetScriptByName("RightMacro")!.ToggleActiveState(); UpdateImages(); }
        #endregion
    }
}
