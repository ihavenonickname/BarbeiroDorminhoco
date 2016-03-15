using System;
using System.Threading;

namespace Sleepyhead
{
    public class Barber
    {
        public event EventHandler<HairCuttedEventArgs> HairCutted;
        public event EventHandler AttendStarted;
        public event EventHandler AttendFinished;

        private Timer timer;
        private BarberShop barberShop;

        public bool Sleeping = true;

        public class HairCuttedEventArgs : EventArgs
        {
            public int Hair;
        }

        public Barber(BarberShop barberShop)
        {
            this.barberShop = barberShop;
        }

        public void Attend(Guy guy)
        {
            Sleeping = false;
            AttendStarted(this, new EventArgs());
            timer = TimerHelper.Create(() => cutHair(guy), 20);
        }

        public void Stop()
        {
            TimerHelper.Destroy(ref timer);
        }

        private void cutHair(Guy guy)
        {
            guy.Hair -= 1;

            HairCuttedEventArgs args = new HairCuttedEventArgs
            {
                Hair = guy.Hair
            };

            HairCutted?.Invoke(this, args);
            
            if (guy.Hair <= 0)
            {
                Stop();
                AttendFinished(this, new EventArgs());
                tryNextGuy();
            }
        }

        private void tryNextGuy()
        {
            Guy guy = barberShop.GetNextGuy();

            if (guy != null)
                Attend(guy);
            else
                Sleeping = true;
        }
    }
}
