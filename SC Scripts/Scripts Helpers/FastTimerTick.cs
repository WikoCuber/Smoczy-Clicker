namespace SC_Scripts.Scripts_Helpers
{
    public static class FastTimerTick
    {
        private readonly static FastTimer fastTimer = new();
        private static readonly List<ScriptsUtilities.SleepInfo> sleepInfoList = [];
        static FastTimerTick()
        {
            fastTimer.Timer += Tick;
            fastTimer.Start(1, true); //Starts the sleep timer
        }

        public static void AddSleepInfo(ScriptsUtilities.SleepInfo sleepInfo)
        {
            lock (sleepInfoList)
            {
                sleepInfoList.Add(sleepInfo);
            }
        }

        //Tick callback
        static void Tick(object? s, EventArgs e)
        {
            int timesEdited = 0;
            lock (sleepInfoList)
            {
                foreach (var sleepInfo in sleepInfoList)
                {
                    if (sleepInfo.Time > sleepInfo.Tick)
                    {
                        sleepInfo.Tick++;
                        timesEdited++;
                        if (sleepInfo.Time == sleepInfo.Tick || sleepInfo.ScriptToken.IsCancellationRequested)
                            sleepInfo.SleepTokenSource.Cancel(); //Cancel the wait task 
                    }
                }

                //Clear sleeps requests when all is ended
                if (timesEdited == 0)
                    sleepInfoList.Clear();
            }
        }
    }
}
