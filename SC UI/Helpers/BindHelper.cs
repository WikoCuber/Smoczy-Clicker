using SC_Scripts.Scripts_Helpers;

namespace SC_UI.Helpers
{
    public static class BindHelper
    {
        public static Keys Get(Button button, Form form, string? scriptName = null)
        {
            form.Enabled = false;
            string oldText = button.Text;
            button.Text = "......";
            Keys key = ScriptsSetup.GetKey();

            if (key == Keys.Escape)
                button.Text = oldText;
            else
            {
                if (scriptName != null)
                {
                    ScriptsSetup.ScriptInfo script = ScriptsSetup.GetScriptByName(scriptName)!;
                    script.Key = key;
                }

                button.Text = ConvertHelper.KeysToString(key);
            }

            form.Enabled = true;

            return key;
        }
    }
}
