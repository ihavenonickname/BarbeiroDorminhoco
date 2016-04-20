using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Sleepyhead
{
    public class BarberShop
    {
        private const int MAX_GUYS = 5;

        public event EventHandler<SpawnEventArgs> Spawned;
        public event EventHandler<AttendEventArgs> Attend;

        private Queue<Guy> queue = new Queue<Guy>();
        private Timer timer;
        private Barber barber;

        public class SpawnEventArgs : EventArgs
        {
            public int QueueLength;
            public bool Entered;
            public int SecondsToNextSpawn;
        }

        public class AttendEventArgs : EventArgs
        {
            public int QueueLength;
        }

        public Barber Barber
        {
            get
            {
                return barber;
            }
        }

        public BarberShop()
        {
            barber = new Barber(this);

            barber.AttendStarted += (sender, e) =>
            {
                AttendEventArgs args = new AttendEventArgs
                {
                    QueueLength = queue.Count
                };

                Attend?.Invoke(this, args);
            };
        }

        public void Open()
        {
            timer = TimerHelper.Create(spawnGuys, 1);
        }

        public void Close()
        {
            barber.Stop();
            TimerHelper.Destroy(ref timer);
        }

        public Guy GetNextGuy()
        {
            return queue.Any() ? queue.Dequeue() : null;
        }

        private void spawnGuys()
        {
            int msToNext = new Random().Next(500, 12000);
            bool entered = queue.Count < MAX_GUYS;

            if (entered)
            {
                queue.Enqueue(new Guy());

                if (barber.Sleeping)
                    barber.Attend(queue.Dequeue());
            }

            SpawnEventArgs args = new SpawnEventArgs
            {
                QueueLength = queue.Count,
                Entered = entered,
                SecondsToNextSpawn = msToNext / 1000
            };

            Spawned?.Invoke(this, args);

            timer.Change(msToNext, Timeout.Infinite);
        }
    }
}
