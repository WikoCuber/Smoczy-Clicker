using SC_Data;
using SC_UI.Forms;

namespace SC_UI
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Create save file and load it
            SaveFile.Init();

            //Adds all scripts
            ScriptsInitalizer.Init();

            Application.Run(new MainForm());
        }
    }
}
