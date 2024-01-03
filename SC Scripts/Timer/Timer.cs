using System.Runtime.InteropServices;

namespace SC_Scripts.Timer
{
    public class Timer
    {
        #region DLLs Imports
        [DllImport("Winmm.dll")]
        private static extern int timeSetEvent(int uDelay, int uResolution, TimerCallback lpTimeProc, IntPtr dwUser, int fuEvent);

        [DllImport("Winmm.dll")]
        private static extern int timeKillEvent(int uTimerID);
        #endregion

        public Timer() => timerCallback = CallbackFunc;

        ~Timer() => Stop();

        public event EventHandler? TimerEvent;

        private delegate void TimerCallback(int uTimerID, int uMsg, IntPtr dwUser, IntPtr dw1, IntPtr dw2); 

        private readonly TimerCallback timerCallback;
        private int id = 0;

        //Stops timer
        public void Stop()
        {
            if (id != 0)
            {
                _ = timeKillEvent(id);
                id = 0;
            }
        }

        //Starts timer with interval
        public void Start(int ms, bool repeat)
        {
            int fu = 0 | (repeat ? 1 : 0);

            id = timeSetEvent(ms, 0, timerCallback, IntPtr.Zero, fu);

            if (id == 0)
                throw new Exception("timeSetEvent error");
        }

        //When windows call tick, this calls event
        private void CallbackFunc(int uTimerID, int uMsg, IntPtr dwUser, IntPtr dw1, IntPtr dw2) => TimerEvent?.Invoke(this, new System.EventArgs());

    }
}
