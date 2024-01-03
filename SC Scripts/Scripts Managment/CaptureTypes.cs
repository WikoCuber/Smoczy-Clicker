namespace SC_Scripts.Scripts_Managment
{
    public enum CaptureTypes
    {
        KEY_UP, //If key was relesed
        KEY_DOWN, //If key was in down 
        KEY_PRESS, //Turn on script when key was in down, and turn off when key was relesed
        KEYSTROKE, //If Key and SecondKey was in down
        KEYSTROKE_PRESS //Turn on script when Key and SecondKey was in down and turn off when SecondKey was relesed
    }
}
