namespace SC_Scripts.Scripts_Helpers
{
    public partial class ScriptsUtilities
    {
        //Class with sleep informations to do sleep in multiple threads
        public class SleepInfo(int time, CancellationTokenSource sleepTokenSource, CancellationToken scriptToken)
        {
            public int Tick { get; set; } //How many ticks (miliseconds) this have to wait
            public int Time { get; set; } = time; //Time to sleep
            public CancellationTokenSource SleepTokenSource { get; set; } = sleepTokenSource;
            public CancellationToken ScriptToken { get; set; } = scriptToken;
        }

        public void Sleep(int time)
        {
            token.ThrowIfCancellationRequested(); //Abort script

            if (time <= 0)
                return;

            CancellationTokenSource sleepTokenSource = new();
            CancellationToken sleepToken = sleepTokenSource.Token;

            Task task = new(() =>
            {
                CancellationToken ct = sleepToken; //Do copy to send only value, not reference
                ct.WaitHandle.WaitOne(); //Wait to cancel
            });
            task.Start();

            FastTimerTick.AddSleepInfo(new SleepInfo(time, sleepTokenSource, token));
            task.Wait(int.MaxValue); //Wait to end the wait task with maximum timeout
        }
    }
}
