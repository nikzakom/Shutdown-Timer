using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Shutdown_Timer
{
    public partial class MainForm : Form
    {
        private NotifyIcon notifyIcon;
        private ContextMenu contextMenu;
        private MenuItem[] menuItems;

        private TimerManager timerManager;

        public MainForm()
        {
            InitializeComponent();
            FormInit();
        }

        private void TooltipsInit()
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 2500;
            toolTip1.InitialDelay = 500;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(this.timeRadioBtn, "Set the exact time to turn off your PC");
            toolTip1.SetToolTip(this.customTimeRadioBtn, "Set the time after which your PC will be turned off");
        }

        private void FormInit()
        {
            // We show app icon only in system tray so we don't need in task bar
            this.ShowInTaskbar = false;

            stopBtn.Visible = false;

            customTimeRadioBtn.Checked = false;
            timeRadioBtn.Checked = true;
            timeInput.Enabled = false;
            customPicker.SelectedItem = customPicker.Items[0];

            hoursPicker.Enabled = true;
            minutesPicker.Enabled = true;
            hoursPicker.SelectedItem = hoursPicker.Items[0];
            minutesPicker.SelectedItem = minutesPicker.Items[0];

            hoursPicker.MaxLength = 2;
            minutesPicker.MaxLength = 2;
            timeInput.Text = "1";

            TooltipsInit();

            NotifyIconInit();
        }

        private void NotifyIconInit()
        {
            this.components = new Container();
            this.contextMenu = new ContextMenu();
            menuItems = new MenuItem[2];

            menuItems[0] = new MenuItem("Open");
            menuItems[1] = new MenuItem("Close");

            // Initialize contextMenu items
            this.contextMenu.MenuItems.AddRange(menuItems);

            // Set handlers for all context menu items
            menuItems[0].Click += new System.EventHandler(this.openItem_Click);
            menuItems[1].Click += new System.EventHandler(this.closeItem_Click);

            this.notifyIcon = new NotifyIcon(this.components);
            notifyIcon.Icon = new Icon("trayIcon.ico");

            // The ContextMenu property sets the menu that will
            // appear when the systray icon is right clicked.
            notifyIcon.ContextMenu = this.contextMenu;

            notifyIcon.Text = "Shutdown Timer";
            notifyIcon.Visible = true;

            // Handle the DoubleClick event to activate the form.
            notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
        }
        private void notifyIcon_DoubleClick(object Sender, EventArgs e)
        {
            // Show the form when the user double clicks on the notify icon.

            // Set the WindowState to normal if the form is minimized.
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;

            // Activate the form.
            this.Activate();
            this.Show();

            this.WindowState = FormWindowState.Normal;

        }

        private void openItem_Click(object Sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;
            // Activate the form.
            this.Activate();
        }
    
        private void closeItem_Click(object Sender, EventArgs e)
        {
            // Close the form, which closes the application.
            this.Close();
        }

        public void log(string message)
        {
            string fullMessage;

            fullMessage =  message + Environment.NewLine;
            // debug
            //fullMessage = $"[{DateTime.Now}] {message}{Environment.NewLine}";

            logTB.Text += fullMessage;

            logTB.SelectionStart = logTB.TextLength;
            logTB.ScrollToCaret();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            InputController inputController = new InputController(this);
            int time;

            if (customTimeRadioBtn.Checked)
            {
                time = inputController.GetCustomTime();
                timerManager = new TimerManager(time);
            }
            else if (timeRadioBtn.Checked)
            {
                time = inputController.CalculateTime();
                timerManager = new TimerManager(time);
            }

            timerManager.StartTimer();

            startBtn.Visible = false;
            stopBtn.Visible = true;
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            if (timerManager.TimerActive())
            {
                timerManager.StopTimer();
                log("Timer stopped");
            }

            startBtn.Visible = true;
            stopBtn.Visible = false;
        }

        private void timeRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            hoursPicker.Enabled = true;
            minutesPicker.Enabled = true;

            customPicker.Enabled = false;
            timeInput.Enabled = false;
        }

        private void customTimeRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            hoursPicker.Enabled = false;
            minutesPicker.Enabled = false;

            customPicker.Enabled = true;
            timeInput.Enabled = true;
        }

        private void timeInput_Validating(object sender, CancelEventArgs e)
        {
            // TODO         
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (notifyIcon != null)
            {
                notifyIcon.Visible = false;
                notifyIcon.Dispose();
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }
    }
}
