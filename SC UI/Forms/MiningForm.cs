using SC_Data;
using SC_Scripts.Scripts_Helpers;

namespace SC_UI.Forms
{
    public partial class MiningForm : Form
    {
        private int commandY = 0; //Command bar Y Coordinates

        private readonly Data _data;

        public MiningForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            UpdateImages();

            _data = DataProvider.Get();

            #region Start Values
            miningBindButton.Text = ScriptsUtilities.KeysToString(_data.ScriptsBinds.Mining);
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
            #endregion
        }

        #region Navigate
        private void bindsButton_Click(object sender, EventArgs e)
        {
            _data.CurrentFormType = FormType.Binds;
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
        private void settingsButton_Click(object sender, EventArgs e)
        {
            _data.CurrentFormType = FormType.Settings;
            Close();
        }
        #endregion

        #region Numeric
        private void lenghtNumeric_KeyUp(object sender, KeyEventArgs e)
        {
            _data.Mining.Length = (int)lenghtNumeric.Value;
            SaveFile.Save();
        }

        private void whichLapDropNumeric_KeyUp(object sender, KeyEventArgs e)
        {
            _data.Mining.WhichLapDrop = (int)whichLapDropNumric.Value;
            SaveFile.Save();
        }

        private void whichLapEatingNumeric_KeyUp(object sender, KeyEventArgs e)
        {
            _data.Mining.WhichLapEating = (int)whichLapEatingNumeric.Value;
            SaveFile.Save();
        }

        private void whichLapDropNumeric_ValueChanged(object sender, EventArgs e) => whichLapDropNumeric_KeyUp(sender, new KeyEventArgs(Keys.None));

        private void whichLapEatingNumeric_ValueChanged(object sender, EventArgs e) => whichLapEatingNumeric_KeyUp(sender, new KeyEventArgs(Keys.None));

        private void lenghtNumeric_ValueChanged(object sender, EventArgs e) => lenghtNumeric_KeyUp(sender, new KeyEventArgs(Keys.None));
        #endregion

        #region CheckBox
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

        private void dropCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _data.Mining.IsDropOn = dropOnCheckBox.Checked;
            SaveFile.Save();
        }

        private void eatingOnCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _data.Mining.IsEatingOn = eatingOnCheckBox.Checked;
            SaveFile.Save();
        }
        #endregion

        private void miningBindButton_Click(object sender, EventArgs e) => Task.Run(() => SetBind(miningBindButton, "Mining"));

        private void miningButton_Click(object sender, EventArgs e) { ScriptsSetup.GetScriptByName("Mining")!.ToggleActiveState(); UpdateImages(); }

        private void commandRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton)!.Checked == false)
                return;

            _data.Commands.IsCommandType = true;
            SaveFile.Save();

            commandY = 0;
            for (int i = 0; i < _data.Commands.CommandsContent.Count; i++)
                commandY += 30;

            SwitchCommandBar();
        }

        private void bindRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton)!.Checked == false)
                return;

            _data.Commands.IsCommandType = false;
            SaveFile.Save();

            commandY = 0;
            for (int i = 0; i < _data.Commands.BindsList.Count; i++)
                commandY += 30;

            SwitchCommandBar();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (commandY / 30 != 12)
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

                AddCommand();
            }
        }

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
            if (ScriptsSetup.GetScriptByName("Mining")!.IsActive)
                miningPicBox.BackgroundImage = Properties.Resources.Yes;
            else
                miningPicBox.BackgroundImage = Properties.Resources.No;
        }

        #region Commands
        private void AddCommand()
        {
            if (commandY / 30 != 12)
            {
                //CheckBox for turn on/off
                CheckBox checkBox = new()
                {
                    Location = new Point(0, commandY + 4),
                    Name = (commandY / 30).ToString(), //Name shows number of command
                    Size = new Size(15, 14),

                };
                if (_data.Commands.IsCommandType)
                    checkBox.Checked = _data.Commands.IsCommandsOn[commandY / 30];
                else
                    checkBox.Checked = _data.Commands.IsBindsOn[commandY / 30];

                checkBox.CheckedChanged += CommandOn_CheckedChanged;
                commandsPanel.Controls.Add(checkBox);

                if (_data.Commands.IsCommandType)
                {
                    //TextBox for command content
                    TextBox textBox = new()
                    {
                        Location = new Point(20, commandY),
                        Name = (commandY / 30).ToString(), //Name shows number of command
                        Size = new Size(100, 20),
                        MaxLength = 50,
                        Text = _data.Commands.CommandsContent[commandY / 30],
                    };
                    textBox.TextChanged += Command_TextChanged;
                    textBox.MouseClick += Command_Click;
                    commandsPanel.Controls.Add(textBox);
                }
                else
                {
                    //Button for bind content
                    Button button = new()
                    {
                        Location = new Point(20, commandY),
                        Name = (commandY / 30).ToString(), //Name shows number of command
                        Size = new Size(100, 20),
                        Text = ScriptsUtilities.KeysToString(_data.Commands.BindsList[commandY / 30])
                    };
                    button.Click += Bind_Click;
                    commandsPanel.Controls.Add(button);
                }
                //Numeric for information when command should do
                NumericUpDown numericUpDown = new()
                {
                    Location = new Point(145, commandY),
                    Name = (commandY / 30).ToString(), //Name shows number of command
                    Size = new Size(50, 20),
                    Minimum = 1,
                    Maximum = 50
                };
                if (_data.Commands.IsCommandType)
                    numericUpDown.Value = _data.Commands.WhichLapCommands[commandY / 30];
                else
                    numericUpDown.Value = _data.Commands.WhichLapBinds[commandY / 30];
                numericUpDown.KeyUp += CommandCoIle_KeyUp;
                numericUpDown.ValueChanged += CommandCoIle_ValueChanged;
                commandsPanel.Controls.Add(numericUpDown);

                commandY += 30;
            }
        }

        void RemoveCommand(int index)
        {
            commandsPanel.Controls.Clear(); //Clear panel

            //Delete command
            if (_data.Commands.IsCommandType)
            {
                _data.Commands.CommandsContent.RemoveAt(index);
                _data.Commands.IsCommandsOn.RemoveAt(index);
                _data.Commands.WhichLapCommands.RemoveAt(index);
            }
            else
            {
                _data.Commands.BindsList.RemoveAt(index);
                _data.Commands.IsBindsOn.RemoveAt(index);
                _data.Commands.WhichLapBinds.RemoveAt(index);
            }

            SaveFile.Save();

            //Create commands again
            int times = commandY / 30;
            commandY = 0;
            for (int i = 0; i < times - 1; i++)
                AddCommand();
        }

        private void CommandOn_CheckedChanged(object? sender, EventArgs e)
        {
            CheckBox checkbox = (sender as CheckBox)!;
            if (_data.Commands.IsCommandType)
                _data.Commands.IsCommandsOn[int.Parse(checkbox.Name)] = checkbox.Checked;
            else
                _data.Commands.IsBindsOn[int.Parse(checkbox.Name)] = checkbox.Checked;
            SaveFile.Save();
        }

        void Command_TextChanged(object? sender, EventArgs e)
        {
            TextBox textBox = (sender as TextBox)!;
            textBox.Text = textBox.Text.Replace(";", "");
            _data.Commands.CommandsContent[int.Parse(textBox.Name)] = textBox.Text;
            SaveFile.Save();
        }
        void Bind_Click(object? sender, EventArgs e)
        {
            if (ModifierKeys == Keys.Control)
            {
                commandsPanel.Visible = false;
                Button button = (sender as Button)!;
                RemoveCommand(int.Parse(button.Name));
                commandsPanel.Visible = true;
            }
            else
            {
                //Initialize key to override by function
                Keys bind = Keys.None;

                Button button = (sender as Button)!;
                Task.Run(() =>
                {
                    bind = SetBind(button);
                    _data.Commands.BindsList[int.Parse(button.Name)] = bind;
                    SaveFile.Save();
                });
            }
        }

        void Command_Click(object? sender, MouseEventArgs e)
        {
            if (ModifierKeys == Keys.Control && e.Button == MouseButtons.Left)
            {
                commandsPanel.Visible = false;
                TextBox textBox = (sender as TextBox)!;
                RemoveCommand(int.Parse(textBox.Name));
                commandsPanel.Visible = true;
            }
        }
        void CommandCoIle_KeyUp(object? sender, KeyEventArgs e)
        {
            NumericUpDown numericUpDown = (sender as NumericUpDown)!;
            if (_data.Commands.IsCommandType)
                _data.Commands.WhichLapCommands[int.Parse(numericUpDown.Name)] = (int)numericUpDown.Value;
            else
                _data.Commands.WhichLapBinds[int.Parse(numericUpDown.Name)] = (int)numericUpDown.Value;
            SaveFile.Save();

        }
        void CommandCoIle_ValueChanged(object? sender, EventArgs e) => CommandCoIle_KeyUp(sender, new KeyEventArgs(Keys.None));
        void SwitchCommandBar()
        {
            commandsPanel.Controls.Clear(); //Clear panel

            int times = commandY / 30;
            commandY = 0;
            for (int i = 0; i < times; i++)
                AddCommand();
        }
        #endregion
    }
}
