using SC_Scripts.Scripts_Managment;
using SC_UI.Forms;

namespace SC_UI
{
    //Types of forms in GUI
    public enum FormType
    {
        Mining,
        Others,
        PvP,
        Settings,
        Binds
    }

    public static class Navigation
    {
        public static FormType CurrentFormType { get; set; }

        public static void ChangeForm(FormType formType, Form form)
        {
            CurrentFormType = formType;
            form.Close();
        }

        public static void SwitchForm(Panel mainPanel, FormClosedEventHandler closeMethod)
        {
            if (ScriptsHotkey.IsExited)
                return;

            switch (CurrentFormType)
            {
                case FormType.Mining:
                    MiningForm mining = new()
                    {
                        TopLevel = false
                    };
                    mining.FormClosed += closeMethod;

                    mainPanel.Controls.Clear();
                    mainPanel.Controls.Add(mining);
                    mining.Show();
                    break;
                case FormType.Others:
                    OthersForm others = new()
                    {
                        TopLevel = false
                    };
                    others.FormClosed += closeMethod;

                    mainPanel.Controls.Clear();
                    mainPanel.Controls.Add(others);
                    others.Show();
                    break;
                case FormType.PvP:
                    PvPForm pvp = new()
                    {
                        TopLevel = false
                    };
                    pvp.FormClosed += closeMethod;

                    mainPanel.Controls.Clear();
                    mainPanel.Controls.Add(pvp);
                    pvp.Show();
                    break;
                case FormType.Settings:
                    SettingsForm settings = new()
                    {
                        TopLevel = false
                    };
                    settings.FormClosed += closeMethod;

                    mainPanel.Controls.Clear();
                    mainPanel.Controls.Add(settings);
                    settings.Show();
                    break;
                case FormType.Binds:
                    BindsForm binds = new()
                    {
                        TopLevel = false
                    };
                    binds.FormClosed += closeMethod;

                    mainPanel.Controls.Clear();
                    mainPanel.Controls.Add(binds);
                    binds.Show();
                    break;
            }
        }
    }
}
