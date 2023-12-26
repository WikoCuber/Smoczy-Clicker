using System.Runtime.InteropServices;

namespace SC_Scripts.Scripts_Helpers
{
    public class FastTimer
    {
        #region Imports DLLs
        [DllImport("Winmm.dll")]
        private static extern uint timeSetEvent(uint uDelay, uint uResolution, TimerCallback lpTimeProc, UIntPtr dwUser, uint fuEvent);

        [DllImport("Winmm.dll")]
        private static extern uint timeKillEvent(uint uTimerID);
        #endregion

        public FastTimer() => thisCB = CBFunc; //Setup the callback delegate

        ~FastTimer() => Dispose(false);

        public event EventHandler? Timer;

        private delegate void TimerCallback(uint uTimerID, uint uMsg, UIntPtr dwUser, UIntPtr dw1, UIntPtr dw2); //Callback delegate

        private bool disposed = false;
        private uint id = 0;
        private readonly TimerCallback thisCB;

        [Flags]
        private enum FuEvent : uint
        {
            TIME_PERIODIC = 1,
            TIME_CALLBACK_FUNCTION = 0x0000,
        }

        //Stops timer
        public void Stop()
        {
            lock (this)
            {
                if (id != 0)
                {
                    _ = timeKillEvent(id);
                    id = 0;
                }
            }
        }

        //Starts timer with interval
        public void Start(uint ms, bool repeat)
        {
            Stop();

            FuEvent f = FuEvent.TIME_CALLBACK_FUNCTION | (repeat ? FuEvent.TIME_PERIODIC : FuEvent.TIME_CALLBACK_FUNCTION);

            lock (this)
            {
                id = timeSetEvent(ms, 0, thisCB, UIntPtr.Zero, (uint)f);
                if (id == 0)
                    throw new Exception("timeSetEvent error");
            }
        }

        private void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                    Stop();
            }
            disposed = true;
        }

        //When windows call tick, this calls event
        private void CBFunc(uint uTimerID, uint uMsg, UIntPtr dwUser, UIntPtr dw1, UIntPtr dw2) =>
            Timer?.Invoke(this, new EventArgs());

    }
}
