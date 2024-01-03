using SC_Data;
using SC_Scripts.Scripts;
using SC_Scripts.Scripts_Managment;

namespace SC_Scripts
{
    public static class ScriptsInitalizer
    {
        public static void Init()
        {
            Data data = DataProvider.Get();

            ScriptsManager.AddScript(new ScriptInfo("Alting", data.ScriptsBinds.Alting, AltingScript.Alting, CaptureTypes.KEY_DOWN));
            ScriptsManager.AddScript(new ScriptInfo("Dabing", data.ScriptsBinds.Dabing, DabingScript.Dabing, CaptureTypes.KEY_DOWN));
            ScriptsManager.AddScript(new ScriptInfo("Drawing", data.ScriptsBinds.Drawing, DrawingScript.Drawing, CaptureTypes.KEY_DOWN));
            ScriptsManager.AddScript(new ScriptInfo("Effects", data.ScriptsBinds.Effects, EffectsScript.Effects, CaptureTypes.KEY_DOWN));
            ScriptsManager.AddScript(new ScriptInfo("Mining", data.ScriptsBinds.Mining, MiningScript.Mining, CaptureTypes.KEY_DOWN));
            ScriptsManager.AddScript(new ScriptInfo("Mathew", data.ScriptsBinds.Mathew, MathewScript.Mathew, CaptureTypes.KEY_DOWN));
            ScriptsManager.AddScript(new ScriptInfo("Void", data.ScriptsBinds.Void, VoidScript.Void, CaptureTypes.KEY_DOWN));
            ScriptsManager.AddScript(new ScriptInfo("Deposit", data.ScriptsBinds.Deposit, DepositScript.Deposit, CaptureTypes.KEY_DOWN));
            ScriptsManager.AddScript(new ScriptInfo("Armor1", data.ScriptsBinds.Armor1, Armor1Script.Armor1, CaptureTypes.KEY_DOWN));
            ScriptsManager.AddScript(new ScriptInfo("Armor2", data.ScriptsBinds.Armor2, Armor2Script.Armor2, CaptureTypes.KEY_DOWN));
            ScriptsManager.AddScript(new ScriptInfo("Armor3", data.ScriptsBinds.Armor3, Armor3Script.Armor3, CaptureTypes.KEY_DOWN));

            ScriptsManager.AddScript(new ScriptInfo("Snowball", data.ScriptsBinds.Snowball, SnowballScript.Snowball, CaptureTypes.KEY_DOWN));
            ScriptsManager.GetScriptByName("Snowball")!.CanCancelByKey = false;

            ScriptsManager.AddScript(new ScriptInfo("FishingRod", data.ScriptsBinds.FishingRod, FishingRodScript.FishingRod, CaptureTypes.KEY_DOWN));
            ScriptsManager.GetScriptByName("FishingRod")!.CanCancelByKey = false;

            CaptureTypes captureTypeRight = CaptureTypes.KEY_PRESS;
            if (data.Clicker.RightType == 1)
                captureTypeRight = CaptureTypes.KEY_PRESS;
            else if (data.Clicker.RightType == 2)
                captureTypeRight = CaptureTypes.KEY_DOWN;
            else if (data.Clicker.RightType == 3)
                captureTypeRight = CaptureTypes.KEYSTROKE_PRESS;
            ScriptsManager.AddScript(new ScriptInfo("RightClicker", data.ScriptsBinds.RightClicker, RightClickerScript.RightClicker, captureTypeRight));
            ScriptsManager.GetScriptByName("RightClicker")!.SecondKey = Keys.RButton; //For DH

            CaptureTypes captureTypeLeft = CaptureTypes.KEY_PRESS;
            if (data.Clicker.LeftType == 1)
                captureTypeLeft = CaptureTypes.KEY_PRESS;
            else if (data.Clicker.LeftType == 2)
                captureTypeLeft = CaptureTypes.KEY_DOWN;
            else if (data.Clicker.LeftType == 3)
                captureTypeLeft = CaptureTypes.KEYSTROKE_PRESS;
            ScriptsManager.AddScript(new ScriptInfo("LeftClicker", data.ScriptsBinds.LeftClicker, LeftClickerScript.LeftClicker, captureTypeLeft));
            ScriptsManager.GetScriptByName("LeftClicker")!.SecondKey = Keys.LButton; //For DH
        }
    }
}
