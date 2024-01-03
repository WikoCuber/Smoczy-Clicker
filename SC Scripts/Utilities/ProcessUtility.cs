using System.Diagnostics;
using System.Runtime.InteropServices;

namespace SC_Scripts.Utilities
{
    public static class ProcessUtility
    {
        #region DLLs Imports
        [DllImport("kernel32.dll")]
        private static extern IntPtr OpenThread(int dwDesiredAccess, bool bInheritHandle, int dwThreadId);
        [DllImport("kernel32.dll")]
        private static extern int SuspendThread(IntPtr hThread);
        [DllImport("kernel32.dll")]
        private static extern int ResumeThread(IntPtr hThread);
        #endregion

        private const int SUSPEND_RESUME = 0x0002;

        //Suspends given process
        public static void Suspend(Process process)
        {
            foreach (ProcessThread thread in process.Threads)
            {
                IntPtr pOpenThread = OpenThread(SUSPEND_RESUME, false, (int)thread.Id);

                if (pOpenThread == IntPtr.Zero)
                    break;

                _ = SuspendThread(pOpenThread);
            }
        }

        //Resumes given process
        public static void Resume(Process process)
        {
            foreach (ProcessThread thread in process.Threads)
            {
                IntPtr pOpenThread = OpenThread(SUSPEND_RESUME, false, (int)thread.Id);

                if (pOpenThread == IntPtr.Zero)
                    break;

                _ = ResumeThread(pOpenThread);
            }
        }
    }
}
