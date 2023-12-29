using SC_Data;
using SC_UI.Helpers;

namespace SC_UI
{
    public class CommandsBindsGenerator(Form form, Panel panel)
    {
        private const int MAX_SIZE = 12;

        private readonly Data _data = DataProvider.Get();
        private readonly Form senderForm = form;
        private readonly Panel displayPanel = panel;

        public int panelY;

        public void AddCommandOrBind()
        {
            if (panelY / 30 != MAX_SIZE)
            {
                //CheckBox for turn on/off
                CheckBox checkBox = new()
                {
                    Location = new Point(0, panelY + 4),
                    Tag = panelY / 30, //Tag shows index
                    Size = new Size(15, 14),
                };
                checkBox.CheckedChanged += CommandBindOnCheckBox_CheckedChanged;

                if (_data.Commands.IsCommandType)
                    checkBox.Checked = _data.Commands.IsCommandsOn[panelY / 30];
                else
                    checkBox.Checked = _data.Commands.IsBindsOn[panelY / 30];

                displayPanel.Controls.Add(checkBox);

                if (_data.Commands.IsCommandType)
                {
                    //TextBox for command content
                    TextBox textBox = new()
                    {
                        Location = new Point(20, panelY),
                        Tag = panelY / 30, //Tag shows index
                        Size = new Size(100, 20),
                        MaxLength = 50,
                        Text = _data.Commands.CommandsContent[panelY / 30]
                    };
                    textBox.TextChanged += CommandTextBox_TextChanged;
                    textBox.MouseClick += CommandTextBox_Click;

                    displayPanel.Controls.Add(textBox);
                }
                else
                {
                    //Button for bind content
                    Button button = new()
                    {
                        Location = new Point(20, panelY),
                        Tag = panelY / 30, //Tag shows index
                        Size = new Size(100, 20),
                        Text = ConvertHelper.KeysToString(_data.Commands.BindsList[panelY / 30])
                    };
                    button.Click += BindButton_Click;

                    displayPanel.Controls.Add(button);
                }

                //Numeric for information when command or bind should invoke
                NumericUpDown numeric = new()
                {
                    Location = new Point(145, panelY),
                    Tag = panelY / 30, //Tag shows index
                    Size = new Size(50, 20),
                    Minimum = 1,
                    Maximum = 50
                };
                numeric.ValueChanged += WhichLineCommandBind_ValueChanged;

                if (_data.Commands.IsCommandType)
                    numeric.Value = _data.Commands.WhichLapCommands[panelY / 30];
                else
                    numeric.Value = _data.Commands.WhichLapBinds[panelY / 30];

                displayPanel.Controls.Add(numeric);

                panelY += 30; //New line
            }
        }

        public void RemoveCommandOrBind(int index)
        {
            displayPanel.Controls.Clear(); //Clear panel

            //Delete command or bind
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

            //Recreate commands or binds
            int times = panelY / 30 - 1;
            panelY = 0;

            for (int i = 0; i < times; i++)
                AddCommandOrBind();
        }

        private void CommandTextBox_TextChanged(object? sender, EventArgs e)
        {
            TextBox textBox = (sender as TextBox)!;

            _data.Commands.CommandsContent[(int)textBox.Tag!] = textBox.Text;
            SaveFile.Save();
        }

        private void CommandTextBox_Click(object? sender, MouseEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control && e.Button == MouseButtons.Left)
            {
                displayPanel.Visible = false;

                int index = (int)(sender as TextBox)!.Tag!;
                RemoveCommandOrBind(index);

                displayPanel.Visible = true;
            }
        }

        private void BindButton_Click(object? sender, EventArgs e)
        {
            Button button = (sender as Button)!;
            int index = (int)button.Tag!;

            if (Control.ModifierKeys == Keys.Control)
            {
                displayPanel.Visible = false;

                RemoveCommandOrBind(index);

                displayPanel.Visible = true;
            }
            else
            {
                Task.Run(() =>
                {
                    Keys key = BindHelper.Get(button, senderForm);

                    if (key == Keys.Escape)
                        return;

                    _data.Commands.BindsList[index] = key;
                    SaveFile.Save();
                });
            }
        }

        private void CommandBindOnCheckBox_CheckedChanged(object? sender, EventArgs e)
        {
            CheckBox checkbox = (sender as CheckBox)!;
            int index = (int)checkbox.Tag!;

            if (_data.Commands.IsCommandType)
                _data.Commands.IsCommandsOn[index] = checkbox.Checked;
            else
                _data.Commands.IsBindsOn[index] = checkbox.Checked;

            SaveFile.Save();
        }

        private void WhichLineCommandBind_ValueChanged(object? sender, EventArgs e)
        {
            NumericUpDown numeric = (sender as NumericUpDown)!;
            int index = (int)numeric.Tag!;

            if (_data.Commands.IsCommandType)
                _data.Commands.WhichLapCommands[index] = (int)numeric.Value;
            else
                _data.Commands.WhichLapBinds[index] = (int)numeric.Value;

            SaveFile.Save();
        }
    }
}
