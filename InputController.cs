using System;
using System.Windows.Forms;

namespace Shutdown_Timer
{
    class InputController
    {
        private MainForm form;

        public InputController(MainForm f)
        {
            form = f;
        }

        public int CalculateTime()
        {
            DateTime currentDt = DateTime.Now;
            DateTime targetDt = GetTargetDateTime();
            TimeSpan dtDiff = new TimeSpan();
            int time;

            //form.log("current " + currentDt.ToString());
            //form.log("target " + targetDt.ToString());

            if (currentDt == targetDt)
            {
                return time = 0;
            }
            else if (currentDt > targetDt)
            {
                DateTime tmp;
                tmp = targetDt.AddDays(1);
                targetDt = tmp;
                form.Log("PC will be shutdown " + targetDt.ToShortDateString() + " at " + targetDt.ToString("HH:mm"));
                dtDiff = targetDt.Subtract(currentDt);

            }
            else if (currentDt < targetDt)
            {
                dtDiff = targetDt.Subtract(currentDt);
                form.Log("PC will be shutdown today at: " + targetDt.ToString("HH:mm"));
            }

            return time = (int)dtDiff.TotalSeconds;

            //form.log("Diff " + dtDiff.ToString());
            //form.log("Seconds " + time.ToString());
        }

        private DateTime GetTargetDateTime()
        {
            DateTime dt;
            int hours = 0;
            int minutes = 0;

            try
            {
                hours = int.Parse(form.hoursPicker.Text);
                minutes = int.Parse(form.minutesPicker.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                 dt = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day,
                    hours, minutes, 00);
            }

            return dt;
        }

        public int GetCustomTime()
        {
            int time;
            int userInput = 0;

            try
            {
                userInput = int.Parse(form.timeInput.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                switch (form.customPicker.SelectedItem.ToString())
                {
                    case "hh":
                        time = userInput * 60 * 60;
                        break;
                    case "mm":
                        time = userInput * 60;
                        break;
                    case "ss":
                        time = userInput;
                        break;
                    default:
                        time = 0;
                        break;
                }

                form.Log("Timer is set to: " + form.timeInput.Text + " "
                    + form.customPicker.SelectedItem.ToString());
            }

            return time;
        }

    }
}
