namespace SC_Scripts.Timer
{
    public static class TimerTick
    {
        private static readonly List<SleepInfo> sleepInfoList = [];
        private static readonly Timer timer;

        static TimerTick()
        {
            timer = new();
            timer.TimerEvent += OnTick;
            timer.Start(1, true); //Starts the timer
        }

        public static void AddSleepInfo(SleepInfo sleepInfo)
        {
            lock (sleepInfoList)
                sleepInfoList.Add(sleepInfo);
        }

        private static void OnTick(object? s, System.EventArgs e)
        {
            lock (sleepInfoList)
            {
                List<SleepInfo> toRemove = [];
                foreach (var sleepInfo in sleepInfoList)
                {
                    sleepInfo.Ticks++;
                    if (sleepInfo.Time <= sleepInfo.Ticks || sleepInfo.ScriptToken.IsCancellationRequested)
                    {
                        sleepInfo.SleepTokenSource.Cancel(); //Cancel the wait task 
                        toRemove.Add(sleepInfo);
                    }
                }

                //Remove after main foreach statement
                foreach (var sleepInfo in toRemove)
                    sleepInfoList.Remove(sleepInfo);
            }
        }
    }
}
