using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Sleepyhead
{
    public class BarberShop
    {
        private const int MAX_GUYS = 5;

        public delegate void SpawnedHandler(int queueLength, bool entered, double secsToNext);
        public event SpawnedHandler Spawned;

        public delegate void GuyGotAttendedHandler(int queueLength);
        public event GuyGotAttendedHandler GuyGotAttended;

        private Queue<Guy> queue = new Queue<Guy>();
        private Timer timer;
        private Barber barber;

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
            barber.AttendStarted += () => GuyGotAttended?.Invoke(queue.Count);
        }

        public void Start()
        {
            timer = TimerHelper.Create(spawnGuys, 1);
        }

        public void Stop()
        {
            if (!barber.Sleeping)
                barber.Stop();

            if (timer != null)
                TimerHelper.Destroy(ref timer);
        }

        public Guy GetNextGuy()
        {
            return queue.Any() ? queue.Dequeue() : null;
        }

        private void spawnGuys()
        {
            int msToNext = new Random().Next(500, 12000);

            if (queue.Count < MAX_GUYS)
            {
                queue.Enqueue(new Guy());
                Spawned?.Invoke(queue.Count, true, msToNext / 1000);

                if (barber.Sleeping)
                    barber.Attend(queue.Dequeue());
            }
            else
                Spawned?.Invoke(queue.Count, false, msToNext / 1000);

            timer.Change(msToNext, Timeout.Infinite);
        }
    }
}
