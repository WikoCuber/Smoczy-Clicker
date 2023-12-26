using SC_Data;
using SC_Scripts.Scripts;
using SC_Scripts.Scripts_Helpers;

namespace SC_UI.Forms
{
    public partial class MainForm : Form
    {
        private readonly Data _data;
        public MainForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            _data = DataProvider.Get();

            try
            {
                InitializeScripts();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


            //First form
            PvPForm PvP = new()
            {
                TopLevel = false
            };

            mainPanel.Controls.Add(PvP);
            PvP.FormClosed += ChangeForm;
            PvP.Show();

        }

        //Adds all scripts
        private void InitializeScripts()
        {
            ScriptsSetup.AddScript(new ScriptsSetup.ScriptInfo("Alting", _data.ScriptsBinds.Alting, Scripts.Alting, ScriptsSetup.CaptureTypes.KEY_DOWN));
            ScriptsSetup.AddScript(new ScriptsSetup.ScriptInfo("Dabing", _data.ScriptsBinds.Dabing, Scripts.Dabing, ScriptsSetup.CaptureTypes.KEY_DOWN));
            ScriptsSetup.AddScript(new ScriptsSetup.ScriptInfo("Drawing", _data.ScriptsBinds.Drawing, Scripts.Drawing, ScriptsSetup.CaptureTypes.KEY_DOWN));
            ScriptsSetup.AddScript(new ScriptsSetup.ScriptInfo("Effects", _data.ScriptsBinds.Effects, Scripts.Effects, ScriptsSetup.CaptureTypes.KEY_DOWN));
            ScriptsSetup.AddScript(new ScriptsSetup.ScriptInfo("Mining", _data.ScriptsBinds.Mining, Scripts.Mining, ScriptsSetup.CaptureTypes.KEY_DOWN));
            ScriptsSetup.AddScript(new ScriptsSetup.ScriptInfo("Mathew", _data.ScriptsBinds.Mathew, Scripts.Mathew, ScriptsSetup.CaptureTypes.KEY_DOWN));
            ScriptsSetup.AddScript(new ScriptsSetup.ScriptInfo("Void", _data.ScriptsBinds.Void, Scripts.Void, ScriptsSetup.CaptureTypes.KEY_DOWN));
            ScriptsSetup.AddScript(new ScriptsSetup.ScriptInfo("Deposit", _data.ScriptsBinds.Deposit, Scripts.Deposit, ScriptsSetup.CaptureTypes.KEY_DOWN));
            ScriptsSetup.AddScript(new ScriptsSetup.ScriptInfo("Armor1", _data.ScriptsBinds.Armor1, Scripts.Armor1, ScriptsSetup.CaptureTypes.KEY_DOWN));
            ScriptsSetup.AddScript(new ScriptsSetup.ScriptInfo("Armor2", _data.ScriptsBinds.Armor2, Scripts.Armor2, ScriptsSetup.CaptureTypes.KEY_DOWN));
            ScriptsSetup.AddScript(new ScriptsSetup.ScriptInfo("Armor3", _data.ScriptsBinds.Armor3, Scripts.Armor3, ScriptsSetup.CaptureTypes.KEY_DOWN));

            ScriptsSetup.AddScript(new ScriptsSetup.ScriptInfo("Snowball", _data.ScriptsBinds.Snowball, Scripts.Snowball, ScriptsSetup.CaptureTypes.KEY_DOWN));
            ScriptsSetup.GetScriptByName("Snowball")!.CanCancelByKey = false;

            ScriptsSetup.AddScript(new ScriptsSetup.ScriptInfo("FishingRod", _data.ScriptsBinds.FishingRod, Scripts.FishingRod, ScriptsSetup.CaptureTypes.KEY_DOWN));
            ScriptsSetup.GetScriptByName("FishingRod")!.CanCancelByKey = false;

            ScriptsSetup.CaptureTypes captureTypeRight = ScriptsSetup.CaptureTypes.KEY_DOWN;
            if (_data.Macro.RightType == 1)
                captureTypeRight = ScriptsSetup.CaptureTypes.KEY_DOWN;
            else if (_data.Macro.RightType == 2)
                captureTypeRight = ScriptsSetup.CaptureTypes.KEYSTROKE_PRESS;
            else if (_data.Macro.RightType == 3)
                captureTypeRight = ScriptsSetup.CaptureTypes.KEY_PRESS;
            ScriptsSetup.AddScript(new ScriptsSetup.ScriptInfo("RightMacro", _data.ScriptsBinds.RightMacro, Scripts.RightClicker, captureTypeRight));
            ScriptsSetup.GetScriptByName("RightMacro")!.SecondKey = Keys.RButton; //For DH

            ScriptsSetup.CaptureTypes captureTypeLeft = ScriptsSetup.CaptureTypes.KEY_DOWN;
            if (_data.Macro.LeftType == 1)
                captureTypeLeft = ScriptsSetup.CaptureTypes.KEY_DOWN;
            else if (_data.Macro.LeftType == 2)
                captureTypeLeft = ScriptsSetup.CaptureTypes.KEYSTROKE_PRESS;
            else if (_data.Macro.LeftType == 3)
                captureTypeLeft = ScriptsSetup.CaptureTypes.KEY_PRESS;
            ScriptsSetup.AddScript(new ScriptsSetup.ScriptInfo("LeftMacro", _data.ScriptsBinds.LeftMacro, Scripts.LeftClicker, captureTypeLeft));
            ScriptsSetup.GetScriptByName("LeftMacro")!.SecondKey = Keys.LButton; //For DH
        }

        //Changes form when Others form was closed
        private void ChangeForm(object? sender, FormClosedEventArgs e)
        {
            if (ScriptsSetup.IsExited)
                return;

            switch (_data.CurrentFormType)
            {
                case FormType.Mining:
                    MiningForm mining = new()
                    {
                        TopLevel = false
                    };
                    mining.FormClosed += ChangeForm;

                    mainPanel.Controls.Clear();
                    mainPanel.Controls.Add(mining);
                    mining.Show();
                    break;
                case FormType.Others:
                    OthersForm others = new()
                    {
                        TopLevel = false
                    };
                    others.FormClosed += ChangeForm;

                    mainPanel.Controls.Clear();
                    mainPanel.Controls.Add(others);
                    others.Show();
                    break;
                case FormType.PvP:
                    PvPForm pvp = new()
                    {
                        TopLevel = false
                    };
                    pvp.FormClosed += ChangeForm;

                    mainPanel.Controls.Clear();
                    mainPanel.Controls.Add(pvp);
                    pvp.Show();
                    break;
                case FormType.Settings:
                    SettingsForm settings = new()
                    {
                        TopLevel = false
                    };
                    settings.FormClosed += ChangeForm;

                    mainPanel.Controls.Clear();
                    mainPanel.Controls.Add(settings);
                    settings.Show();
                    break;
                case FormType.Binds:
                    BindsForm binds = new()
                    {
                        TopLevel = false
                    };
                    binds.FormClosed += ChangeForm;

                    mainPanel.Controls.Clear();
                    mainPanel.Controls.Add(binds);
                    binds.Show();
                    break;
            }
        }

        //Closes scripts and threads belonging to them
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) => ScriptsSetup.Exit();
    }
}
