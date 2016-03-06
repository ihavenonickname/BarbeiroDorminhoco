using System;
using System.Threading;

namespace Sleepyhead
{
    public class TimerHelper
    {
        public static Timer Create(Action callback, int delay)
        {
            return new Timer(new TimerCallback((o) => callback()), null, 10, delay);
        }

        public static void Destroy(ref Timer timer)
        {
            timer.Change(Timeout.Infinite, Timeout.Infinite);
        }
    }
}
