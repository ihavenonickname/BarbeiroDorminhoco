using System;
using System.Windows.Forms;

namespace Sleepyhead
{
    public partial class MainForm : Form
    {
        BarberShop barberShop = new BarberShop();

        public MainForm()
        {
            InitializeComponent();

            barberShop.Spawned += (queueLength, entered, secsToNext) =>
            {
                InvokeAction(() =>
                {
                    lbQueue.Text = now() + queueLength + " in queue.";
                    lbLastSpawn.Text = now() + "A guy entered" + (entered ? "." : "and left out.");
                    lbTime.Text = secsToNext + "s to next guy.";
                });
            };

            barberShop.GuyGotAttended += (queueLength) =>
            {
                InvokeAction(() =>
                {
                    lbQueue.Text = now() + queueLength + " in queue.";
                    lbStatus.Text = "Not sleeping";
                });
            };

            barberShop.Barber.Cutted += (hair) =>
            {
                InvokeAction(() => lbHair.Text = hair + " cuts to finish.");
            };

            barberShop.Barber.AttendFinished += () =>
            {
                InvokeAction(() => lbStatus.Text = "Sleeping");
            };

            FormClosing += (sender, e) => barberShop.Stop();

            barberShop.Start();
        }

        private void InvokeAction(Action a)
        {
            BeginInvoke(new MethodInvoker(a));
        }

        private string now()
        {
            return DateTime.Now.ToString("HH:mm:ss -> ");
        }
    }
}
