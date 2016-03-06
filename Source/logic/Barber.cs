using System.Threading;

namespace Sleepyhead
{
    public class Barber
    {
        public delegate void AttendStartedHandler();
        public event AttendStartedHandler AttendStarted;

        public delegate void AttendFinihhedHandler();
        public event AttendFinihhedHandler AttendFinished;

        public delegate void CuttedHandler(int hair);
        public event CuttedHandler Cutted;

        private Timer timer;
        private BarberShop barberShop;

        public bool Sleeping = true;

        public Barber(BarberShop barberShop)
        {
            this.barberShop = barberShop;
        }

        public void Attend(Guy guy)
        {
            Sleeping = false;
            AttendStarted();
            timer = TimerHelper.Create(() => cutHair(guy), 20);
        }

        public void Stop()
        {
            TimerHelper.Destroy(ref timer);
        }

        private void cutHair(Guy guy)
        {
            guy.Hair -= 1;
            Cutted?.Invoke(guy.Hair);
            
            if (guy.Hair <= 0)
            {
                Stop();
                AttendFinished();
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
