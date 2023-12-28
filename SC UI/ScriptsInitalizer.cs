using SC_Data;
using SC_Scripts.Scripts;
using SC_Scripts.Scripts_Helpers;

namespace SC_UI
{
    public static class ScriptsInitalizer
    {
        public static void Init()
        {
            Data data = DataProvider.Get();

            ScriptsSetup.AddScript(new ScriptsSetup.ScriptInfo("Alting", data.ScriptsBinds.Alting, Scripts.Alting, ScriptsSetup.CaptureTypes.KEY_DOWN));
            ScriptsSetup.AddScript(new ScriptsSetup.ScriptInfo("Dabing", data.ScriptsBinds.Dabing, Scripts.Dabing, ScriptsSetup.CaptureTypes.KEY_DOWN));
            ScriptsSetup.AddScript(new ScriptsSetup.ScriptInfo("Drawing", data.ScriptsBinds.Drawing, Scripts.Drawing, ScriptsSetup.CaptureTypes.KEY_DOWN));
            ScriptsSetup.AddScript(new ScriptsSetup.ScriptInfo("Effects", data.ScriptsBinds.Effects, Scripts.Effects, ScriptsSetup.CaptureTypes.KEY_DOWN));
            ScriptsSetup.AddScript(new ScriptsSetup.ScriptInfo("Mining", data.ScriptsBinds.Mining, Scripts.Mining, ScriptsSetup.CaptureTypes.KEY_DOWN));
            ScriptsSetup.AddScript(new ScriptsSetup.ScriptInfo("Mathew", data.ScriptsBinds.Mathew, Scripts.Mathew, ScriptsSetup.CaptureTypes.KEY_DOWN));
            ScriptsSetup.AddScript(new ScriptsSetup.ScriptInfo("Void", data.ScriptsBinds.Void, Scripts.Void, ScriptsSetup.CaptureTypes.KEY_DOWN));
            ScriptsSetup.AddScript(new ScriptsSetup.ScriptInfo("Deposit", data.ScriptsBinds.Deposit, Scripts.Deposit, ScriptsSetup.CaptureTypes.KEY_DOWN));
            ScriptsSetup.AddScript(new ScriptsSetup.ScriptInfo("Armor1", data.ScriptsBinds.Armor1, Scripts.Armor1, ScriptsSetup.CaptureTypes.KEY_DOWN));
            ScriptsSetup.AddScript(new ScriptsSetup.ScriptInfo("Armor2", data.ScriptsBinds.Armor2, Scripts.Armor2, ScriptsSetup.CaptureTypes.KEY_DOWN));
            ScriptsSetup.AddScript(new ScriptsSetup.ScriptInfo("Armor3", data.ScriptsBinds.Armor3, Scripts.Armor3, ScriptsSetup.CaptureTypes.KEY_DOWN));

            ScriptsSetup.AddScript(new ScriptsSetup.ScriptInfo("Snowball", data.ScriptsBinds.Snowball, Scripts.Snowball, ScriptsSetup.CaptureTypes.KEY_DOWN));
            ScriptsSetup.GetScriptByName("Snowball")!.CanCancelByKey = false;

            ScriptsSetup.AddScript(new ScriptsSetup.ScriptInfo("FishingRod", data.ScriptsBinds.FishingRod, Scripts.FishingRod, ScriptsSetup.CaptureTypes.KEY_DOWN));
            ScriptsSetup.GetScriptByName("FishingRod")!.CanCancelByKey = false;

            ScriptsSetup.CaptureTypes captureTypeRight = ScriptsSetup.CaptureTypes.KEY_PRESS;
            if (data.Macro.RightType == 1)
                captureTypeRight = ScriptsSetup.CaptureTypes.KEY_PRESS;
            else if (data.Macro.RightType == 2)
                captureTypeRight = ScriptsSetup.CaptureTypes.KEY_DOWN;
            else if (data.Macro.RightType == 3)
                captureTypeRight = ScriptsSetup.CaptureTypes.KEYSTROKE_PRESS;
            ScriptsSetup.AddScript(new ScriptsSetup.ScriptInfo("RightMacro", data.ScriptsBinds.RightMacro, Scripts.RightClicker, captureTypeRight));
            ScriptsSetup.GetScriptByName("RightMacro")!.SecondKey = Keys.RButton; //For DH

            ScriptsSetup.CaptureTypes captureTypeLeft = ScriptsSetup.CaptureTypes.KEY_PRESS;
            if (data.Macro.LeftType == 1)
                captureTypeLeft = ScriptsSetup.CaptureTypes.KEY_PRESS;
            else if (data.Macro.LeftType == 2)
                captureTypeLeft = ScriptsSetup.CaptureTypes.KEY_DOWN;
            else if (data.Macro.LeftType == 3)
                captureTypeLeft = ScriptsSetup.CaptureTypes.KEYSTROKE_PRESS;
            ScriptsSetup.AddScript(new ScriptsSetup.ScriptInfo("LeftMacro", data.ScriptsBinds.LeftMacro, Scripts.LeftClicker, captureTypeLeft));
            ScriptsSetup.GetScriptByName("LeftMacro")!.SecondKey = Keys.LButton; //For DH
        }
    }
}
