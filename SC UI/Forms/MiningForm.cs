using SC_Data;
using SC_Scripts.Scripts_Helpers;
using SC_UI.Helpers;

namespace SC_UI.Forms
{
    public partial class MiningForm : Form
    {
        private readonly Data _data;
        private readonly CommandsBindsGenerator generator;

        public MiningForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            UpdateImages();

            _data = DataProvider.Get();
            generator = new(this, commandsBindsPanel);

            SetStartValues();
        }

        private void SetStartValues()
        {
            miningBindButton.Text = ConvertHelper.KeysToString(_data.ScriptsBinds.Mining);
            lenghtNumeric.Value = _data.Mining.Length;
            whichLapDropNumric.Value = _data.Mining.WhichLapDrop;
            whichLapEatingNumeric.Value = _data.Mining.WhichLapEating;
            eatingOnCheckBox.Checked = _data.Mining.IsEatingOn;
            backgroundCheckBox.Checked = _data.Mining.IsEatingOn;
            slot1OnCheckBox.Checked = _data.Mining.IsSlot1On;
            slot2OnCheckBox.Checked = _data.Mining.IsSlot2On;
            slot3OnCheckBox.Checked = _data.Mining.IsSlot3On;
            slot4OnCheckBox.Checked = _data.Mining.IsSlot4On;
            slot5OnCheckBox.Checked = _data.Mining.IsSlot5On;
            dropOnCheckBox.Checked = _data.Mining.IsDropOn;
            backgroundBPCheckBox.Checked = _data.Mining.IsBackgroundBP;

            if (_data.Commands.IsCommandType)
                commandRadioButton.Checked = true;
            else
                bindRadioButton.Checked = true;
        }

        private void UpdateImages()
        {
            if (ScriptsSetup.GetScriptByName("Mining")!.IsActive)
                miningStatusPicBox.BackgroundImage = Properties.Resources.Yes;
            else
                miningStatusPicBox.BackgroundImage = Properties.Resources.No;
        }

        private void SetBind(Button button, string? scriptName = null)
        {
            Keys key = BindHelper.Get(button, this, scriptName);

            if (key == Keys.Escape)
                return;

            if (button == miningBindButton)
                _data.ScriptsBinds.Mining = key;

            SaveFile.Save();
        }

        private void SwitchCommandsBindsBar(RadioButton radioButton)
        {
            if (!radioButton.Checked)
                return;

            generator.panelY = 0;

            if (radioButton == commandRadioButton)
            {
                _data.Commands.IsCommandType = true;
                generator.panelY += _data.Commands.CommandsContent.Count * 30;
            }
            else
            {
                _data.Commands.IsCommandType = false;
                generator.panelY += _data.Commands.BindsList.Count * 30;
            }

            SaveFile.Save();

            //Regenerate panel
            commandsBindsPanel.Controls.Clear(); //Clear panel

            int times = generator.panelY / 30;
            generator.panelY = 0;
            for (int i = 0; i < times; i++)
                generator.AddCommandOrBind();
        }

        //Navigation buttons
        private void bindsNavButton_Click(object sender, EventArgs e) => Navigation.ChangeForm(FormType.Binds, this);
        private void pvpNavButton_Click(object sender, EventArgs e) => Navigation.ChangeForm(FormType.PvP, this);
        private void othersNavButton_Click(object sender, EventArgs e) => Navigation.ChangeForm(FormType.Others, this);
        private void settingsNavButton_Click(object sender, EventArgs e) => Navigation.ChangeForm(FormType.Settings, this);

        //Numerics
        private void whichLapDropNumeric_ValueChanged(object sender, EventArgs e)
        {
            _data.Mining.WhichLapDrop = (int)whichLapDropNumric.Value;
            SaveFile.Save();
        }
        private void whichLapEatingNumeric_ValueChanged(object sender, EventArgs e)
        {
            _data.Mining.WhichLapEating = (int)whichLapEatingNumeric.Value;
            SaveFile.Save();
        }
        private void lenghtNumeric_ValueChanged(object sender, EventArgs e)
        {
            _data.Mining.Length = (int)lenghtNumeric.Value;
            SaveFile.Save();
        }

        //Check boxes
        private void backgroundCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _data.Mining.IsBackground = backgroundCheckBox.Checked;

            if (backgroundCheckBox.Checked)
                backgroundBPCheckBox.Checked = false;

            if (backgroundCheckBox.Checked)
            {
                eatingOnCheckBox.Enabled = false;
                whichLapEatingNumeric.Enabled = false;
            }
            else
            {
                eatingOnCheckBox.Enabled = true;
                whichLapEatingNumeric.Enabled = true;
            }

            SaveFile.Save();
        }
        private void backgroundBPCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _data.Mining.IsBackgroundBP = backgroundBPCheckBox.Checked;

            if (backgroundBPCheckBox.Checked)
                backgroundCheckBox.Checked = false;

            if (backgroundBPCheckBox.Checked)
            {
                eatingOnCheckBox.Enabled = false;
                whichLapEatingNumeric.Enabled = false;
            }
            else
            {
                eatingOnCheckBox.Enabled = true;
                whichLapEatingNumeric.Enabled = true;
            }

            SaveFile.Save();
        }
        private void slot1OnCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _data.Mining.IsSlot1On = slot1OnCheckBox.Checked;
            SaveFile.Save();
        }
        private void slot2OnCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _data.Mining.IsSlot2On = slot2OnCheckBox.Checked;
            SaveFile.Save();
        }
        private void slot3OnCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _data.Mining.IsSlot3On = slot3OnCheckBox.Checked;
            SaveFile.Save();
        }
        private void slot4OnCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _data.Mining.IsSlot4On = slot4OnCheckBox.Checked;
            SaveFile.Save();
        }
        private void slot5OnCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _data.Mining.IsSlot5On = slot5OnCheckBox.Checked;
            SaveFile.Save();
        }
        private void dropOnCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _data.Mining.IsDropOn = dropOnCheckBox.Checked;
            SaveFile.Save();
        }
        private void eatingOnCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _data.Mining.IsEatingOn = eatingOnCheckBox.Checked;
            SaveFile.Save();
        }

        //Bind button
        private void miningBindButton_Click(object sender, EventArgs e) => Task.Run(() => SetBind(miningBindButton, "Mining"));

        //Status button
        private void miningStatusButton_Click(object sender, EventArgs e)
        {
            ScriptsSetup.GetScriptByName("Mining")!.ToggleActiveState();
            UpdateImages();
        }

        //Radio buttons
        private void commandRadioButton_CheckedChanged(object sender, EventArgs e) => SwitchCommandsBindsBar(commandRadioButton);
        private void bindRadioButton_CheckedChanged(object sender, EventArgs e) => SwitchCommandsBindsBar(bindRadioButton);

        //Add command button
        private void addButton_Click(object sender, EventArgs e)
        {
            //Save new command line
            if (_data.Commands.IsCommandType)
            {
                _data.Commands.CommandsContent.Add("");
                _data.Commands.WhichLapCommands.Add(1);
                _data.Commands.IsCommandsOn.Add(false);
            }
            else
            {
                _data.Commands.BindsList.Add(Keys.None);
                _data.Commands.WhichLapBinds.Add(1);
                _data.Commands.IsBindsOn.Add(false);
            }
            SaveFile.Save();

            generator.AddCommandOrBind();
        }
    }
}