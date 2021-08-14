using System;
using System.Windows.Forms;

namespace Shutdown_Timer
{
    class TimerManager
    {
        private Timer timer;
        private int timerTime;

        public TimerManager(int time)
        {
            timerTime = time;
            timer = new Timer();
            InitTimer();
        }

        public bool TimerActive()
        {
            if (timer.Enabled)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void StopTimer()
        {
            timer.Stop();
        }

        private void InitTimer()
        {
            timer = new Timer();
            timer.Tick += timer_Tick;
            timer.Interval = 1000;
        }

        public void StartTimer()
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (timerTime == 0)
            {
                timer.Stop();
                ShutdownController.ShutdownPC();
                return;
            }

            timerTime--;
            //log(timerTime.ToString());
        }

    }
}
