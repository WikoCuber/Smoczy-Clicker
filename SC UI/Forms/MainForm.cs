using SC_Scripts.Scripts_Helpers;

namespace SC_UI.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            //First form
            Navigation.CurrentFormType = FormType.PvP;
            Navigation.SwitchForm(mainPanel, ChangeForm);
        }

        //Changes form when current displayed was closed
        private void ChangeForm(object? sender, FormClosedEventArgs e) => Navigation.SwitchForm(mainPanel, ChangeForm);

        //Closes scripts and threads belonging to them
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) => ScriptsSetup.Exit();
    }
}
