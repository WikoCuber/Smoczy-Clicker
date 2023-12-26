using SC_Data;
using SC_Scripts.Scripts_Helpers;

namespace SC_UI.Forms
{
    public partial class OthersForm : Form
    {
        private readonly ScriptsUtilities su;
        private readonly Data _data;

        public OthersForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            UpdateImages();

            su = new();
            _data = DataProvider.Get();

            #region Start Values
            if (_data.Settings.PickaxeType == 1)
                pickaxe6RadioButton.Checked = true;
            else if (_data.Settings.PickaxeType == 2)
                pickaxe5RadioButton.Checked = true;
            else
                pickaxe4RadioButton.Checked = true;
            effectsOnCheckBox.Checked = _data.Settings.IsEffectsOn;
            drawingOnCheckBox.Checked = _data.Settings.IsDrawingOn;
            effectsPositionButton.Text = _data.Coordinates.EffectsX + "; " + _data.Coordinates.EffectsY;
            drawingPositionButton.Text = _data.Coordinates.DrawingX + "; " + _data.Coordinates.DrawingY;
            depositDelayNumeric.Value = _data.Delays.Deposit;
            depositBindButton.Text = ScriptsUtilities.KeysToString(_data.ScriptsBinds.Deposit);
            dabingBindButton.Text = ScriptsUtilities.KeysToString(_data.ScriptsBinds.Dabing);
            altingBindButton.Text = ScriptsUtilities.KeysToString(_data.ScriptsBinds.Alting);
            mathewBindButton.Text = ScriptsUtilities.KeysToString(_data.ScriptsBinds.Mathew);
            effectsBindButton.Text = ScriptsUtilities.KeysToString(_data.ScriptsBinds.Effects);
            drawingBindButton.Text = ScriptsUtilities.KeysToString(_data.ScriptsBinds.Drawing);
            voidBindButton.Text = ScriptsUtilities.KeysToString(_data.ScriptsBinds.Void);
            dabingType.SelectedIndex = _data.Settings.DabingType - 1;
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

        private void bindsButton_Click(object sender, EventArgs e)
        {
            _data.CurrentFormType = FormType.Binds;
            Close();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            _data.CurrentFormType = FormType.Settings;
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

                if (button == effectsPositionButton)
                {
                    _data.Coordinates.EffectsX = p.X;
                    _data.Coordinates.EffectsY = p.Y;
                }
                else
                {
                    _data.Coordinates.DrawingX = p.X;
                    _data.Coordinates.DrawingY = p.Y;
                }

                button.Text = p.X + "; " + p.X;
                SaveFile.Save();
            }
            else
                button.Text = oldText;

            Enabled = true;
        }

        private void effects_Click(object sender, EventArgs e) => Task.Run(() => SetCoordinate(effectsPositionButton));

        private void drawing_Click(object sender, EventArgs e) => Task.Run(() => SetCoordinate(drawingPositionButton));

        private void UpdateImages()
        {
            if (ScriptsSetup.GetScriptByName("Deposit")!.IsActive)
                depositPicBox.BackgroundImage = Properties.Resources.Yes;
            else
                depositPicBox.BackgroundImage = Properties.Resources.No;
            if (ScriptsSetup.GetScriptByName("Effects")!.IsActive)
                effectsDrawingPicBox.BackgroundImage = Properties.Resources.Yes;
            else
                effectsDrawingPicBox.BackgroundImage = Properties.Resources.No;
            if (ScriptsSetup.GetScriptByName("Alting")!.IsActive)
                altingPicBox.BackgroundImage = Properties.Resources.Yes;
            else
                altingPicBox.BackgroundImage = Properties.Resources.No;
            if (ScriptsSetup.GetScriptByName("Mathew")!.IsActive)
                mathewPicBox.BackgroundImage = Properties.Resources.Yes;
            else
                mathewPicBox.BackgroundImage = Properties.Resources.No;
            if (ScriptsSetup.GetScriptByName("Dabing")!.IsActive)
                dabingPicBox.BackgroundImage = Properties.Resources.Yes;
            else
                dabingPicBox.BackgroundImage = Properties.Resources.No;
            if (ScriptsSetup.GetScriptByName("Void")!.IsActive)
                voidPicBox.BackgroundImage = Properties.Resources.Yes;
            else
                voidPicBox.BackgroundImage = Properties.Resources.No;
        }

        #region RadioButton
        private void pickaxe6RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (pickaxe6RadioButton.Checked)
            {
                _data.Settings.PickaxeType = 1;
                SaveFile.Save();
            }
        }

        private void pickaxe5RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (pickaxe5RadioButton.Checked)
            {
                _data.Settings.PickaxeType = 2;
                SaveFile.Save();
            }
        }

        private void pickaxe4RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (pickaxe4RadioButton.Checked)
            {
                _data.Settings.PickaxeType = 3;
                SaveFile.Save();
            }
        }
        #endregion

        #region CheckBox
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
        #endregion

        #region Numeric
        private void depositDelayNumeric_KeyUp(object sender, KeyEventArgs e)
        {
            _data.Delays.Deposit = (int)depositDelayNumeric.Value;
            SaveFile.Save();
        }

        private void depositDelayNumeric_ValueChanged(object sender, EventArgs e) => depositDelayNumeric_KeyUp(sender, new KeyEventArgs(Keys.None));
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

                switch (scriptName)
                {
                    case "Deposit":
                        _data.ScriptsBinds.Deposit = currentKey;
                        break;
                    case "Dabing":
                        _data.ScriptsBinds.Dabing = currentKey;
                        break;
                    case "Alting":
                        _data.ScriptsBinds.Alting = currentKey;
                        break;
                    case "Mathew":
                        _data.ScriptsBinds.Mathew = currentKey;
                        break;
                    case "Effects":
                        _data.ScriptsBinds.Effects = currentKey;
                        break;
                    case "Drawing":
                        _data.ScriptsBinds.Drawing = currentKey;
                        break;
                    case "Void":
                        _data.ScriptsBinds.Void = currentKey;
                        break;
                }
                SaveFile.Save();
            }
            else
                button.Text = oldText;

            Enabled = true;

            return currentKey;
        }

        #region New Bind
        private void depositBindButton_Click(object sender, EventArgs e) => Task.Run(() => SetBind(depositBindButton, "Deposit"));

        private void dabingBindButton_Click(object sender, EventArgs e) => Task.Run(() => SetBind(dabingBindButton, "Dabing"));

        private void altingBindButton_Click(object sender, EventArgs e) => Task.Run(() => SetBind(altingBindButton, "Alting"));

        private void mathewBindButton_Click(object sender, EventArgs e) => Task.Run(() => SetBind(mathewBindButton, "Mathew"));

        private void effectsBindButton_Click(object sender, EventArgs e) => Task.Run(() => SetBind(effectsBindButton, "Effects"));

        private void drawingBindButton_Click(object sender, EventArgs e) => Task.Run(() => SetBind(drawingBindButton, "Drawing"));

        private void voidBindButton_Click(object sender, EventArgs e) => Task.Run(() => SetBind(voidBindButton, "Void"));
        #endregion

        #region Scripts Buttons
        private void depositButton_Click(object sender, EventArgs e) { ScriptsSetup.GetScriptByName("Deposit")!.ToggleActiveState(); UpdateImages(); }
        private void effectsDrawingButton_Click(object sender, EventArgs e) { ScriptsSetup.GetScriptByName("Effects")!.ToggleActiveState(); ScriptsSetup.GetScriptByName("Drawing")!.ToggleActiveState(); UpdateImages(); }
        private void altingButton_Click(object sender, EventArgs e) { ScriptsSetup.GetScriptByName("Alting")!.ToggleActiveState(); UpdateImages(); }
        private void mathewButton_Click(object sender, EventArgs e) { ScriptsSetup.GetScriptByName("Mathew")!.ToggleActiveState(); UpdateImages(); }
        private void dabingButton_Click(object sender, EventArgs e) { ScriptsSetup.GetScriptByName("Dabing")!.ToggleActiveState(); UpdateImages(); }
        private void voidButton_Click(object sender, EventArgs e) { ScriptsSetup.GetScriptByName("Void")!.ToggleActiveState(); UpdateImages(); }
        #endregion

        private void dabingType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _data.Settings.DabingType = dabingType.SelectedIndex + 1;
            SaveFile.Save();
        }
    }
}
