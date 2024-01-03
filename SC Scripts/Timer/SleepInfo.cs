namespace SC_Scripts.Timer
{
    //Class with informations to do sleep in multiple threads
    public class SleepInfo(int time, CancellationTokenSource sleepTokenSource, CancellationToken scriptToken)
    {
        public int Ticks { get; set; } //How many ticks (milliseconds) this already waited 
        public int Time { get; set; } = time; //Time to sleep
        public CancellationTokenSource SleepTokenSource { get; set; } = sleepTokenSource;
        public CancellationToken ScriptToken { get; set; } = scriptToken;
    }
}
