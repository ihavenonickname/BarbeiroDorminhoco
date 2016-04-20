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

            barberShop.Spawned += (sender, e) =>
            {
                InvokeAction(() =>
                {
                    lbQueue.Text = now() + e.QueueLength + " in queue.";
                    lbLastSpawn.Text = now() + "A guy entered" + (e.Entered ? "." : "and left out.");
                    lbTime.Text = now() +  e.SecondsToNextSpawn + "s to next guy.";
                });
            };

            barberShop.Attend += (sender, e) =>
            {
                InvokeAction(() =>
                {
                    lbQueue.Text = now() + e.QueueLength + " in queue.";
                    lbStatus.Text = "Not sleeping";
                });
            };

            barberShop.Barber.HairCutted += (sender, e) =>
            {
                InvokeAction(() => lbHair.Text = e.Hair + " cuts to finish.");
            };

            barberShop.Barber.AttendFinished += (sender, e) =>
            {
                InvokeAction(() => lbStatus.Text = "Sleeping");
            };

            FormClosing += (sender, e) => barberShop.Close();

            barberShop.Open();
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
