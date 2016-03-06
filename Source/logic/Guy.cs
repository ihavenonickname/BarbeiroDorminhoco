using System;

namespace Sleepyhead
{
    public class Guy
    {
        public int Hair;

        public Guy()
        {
            Hair = new Random().Next(100, 300);
        }
    }
}
