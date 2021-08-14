
namespace Shutdown_Timer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timeInput = new System.Windows.Forms.TextBox();
            this.customPicker = new System.Windows.Forms.ComboBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.logTB = new System.Windows.Forms.TextBox();
            this.hoursPicker = new System.Windows.Forms.ComboBox();
            this.minutesPicker = new System.Windows.Forms.ComboBox();
            this.timeRadioBtn = new System.Windows.Forms.RadioButton();
            this.customTimeRadioBtn = new System.Windows.Forms.RadioButton();
            this.stopBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timeInput
            // 
            this.timeInput.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeInput.Location = new System.Drawing.Point(132, 60);
            this.timeInput.MaxLength = 5;
            this.timeInput.Multiline = true;
            this.timeInput.Name = "timeInput";
            this.timeInput.Size = new System.Drawing.Size(70, 32);
            this.timeInput.TabIndex = 0;
            this.timeInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timeInput.Validating += new System.ComponentModel.CancelEventHandler(this.timeInput_Validating);
            // 
            // customPicker
            // 
            this.customPicker.BackColor = System.Drawing.Color.White;
            this.customPicker.DropDownHeight = 125;
            this.customPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customPicker.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.customPicker.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customPicker.FormattingEnabled = true;
            this.customPicker.IntegralHeight = false;
            this.customPicker.Items.AddRange(new object[] {
            "hh",
            "mm",
            "ss"});
            this.customPicker.Location = new System.Drawing.Point(56, 62);
            this.customPicker.Name = "customPicker";
            this.customPicker.Size = new System.Drawing.Size(70, 30);
            this.customPicker.TabIndex = 1;
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.SystemColors.Control;
            this.startBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.startBtn.FlatAppearance.BorderSize = 0;
            this.startBtn.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startBtn.ForeColor = System.Drawing.Color.Black;
            this.startBtn.Location = new System.Drawing.Point(220, 17);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 75);
            this.startBtn.TabIndex = 2;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // logTB
            // 
            this.logTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logTB.Location = new System.Drawing.Point(12, 107);
            this.logTB.Multiline = true;
            this.logTB.Name = "logTB";
            this.logTB.ReadOnly = true;
            this.logTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTB.Size = new System.Drawing.Size(294, 84);
            this.logTB.TabIndex = 3;
            // 
            // hoursPicker
            // 
            this.hoursPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hoursPicker.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hoursPicker.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hoursPicker.FormattingEnabled = true;
            this.hoursPicker.IntegralHeight = false;
            this.hoursPicker.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.hoursPicker.Location = new System.Drawing.Point(56, 17);
            this.hoursPicker.Margin = new System.Windows.Forms.Padding(2);
            this.hoursPicker.MaxDropDownItems = 7;
            this.hoursPicker.Name = "hoursPicker";
            this.hoursPicker.Size = new System.Drawing.Size(70, 30);
            this.hoursPicker.TabIndex = 4;
            // 
            // minutesPicker
            // 
            this.minutesPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.minutesPicker.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minutesPicker.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minutesPicker.FormattingEnabled = true;
            this.minutesPicker.IntegralHeight = false;
            this.minutesPicker.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.minutesPicker.Location = new System.Drawing.Point(132, 17);
            this.minutesPicker.Margin = new System.Windows.Forms.Padding(2);
            this.minutesPicker.MaxDropDownItems = 7;
            this.minutesPicker.Name = "minutesPicker";
            this.minutesPicker.Size = new System.Drawing.Size(70, 30);
            this.minutesPicker.TabIndex = 5;
            // 
            // timeRadioBtn
            // 
            this.timeRadioBtn.AutoSize = true;
            this.timeRadioBtn.Location = new System.Drawing.Point(30, 27);
            this.timeRadioBtn.Margin = new System.Windows.Forms.Padding(2);
            this.timeRadioBtn.Name = "timeRadioBtn";
            this.timeRadioBtn.Size = new System.Drawing.Size(14, 13);
            this.timeRadioBtn.TabIndex = 6;
            this.timeRadioBtn.TabStop = true;
            this.timeRadioBtn.UseVisualStyleBackColor = true;
            this.timeRadioBtn.CheckedChanged += new System.EventHandler(this.timeRadioBtn_CheckedChanged);
            // 
            // customTimeRadioBtn
            // 
            this.customTimeRadioBtn.AutoSize = true;
            this.customTimeRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customTimeRadioBtn.Location = new System.Drawing.Point(30, 66);
            this.customTimeRadioBtn.Margin = new System.Windows.Forms.Padding(2);
            this.customTimeRadioBtn.Name = "customTimeRadioBtn";
            this.customTimeRadioBtn.Size = new System.Drawing.Size(14, 13);
            this.customTimeRadioBtn.TabIndex = 7;
            this.customTimeRadioBtn.TabStop = true;
            this.customTimeRadioBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.customTimeRadioBtn.UseVisualStyleBackColor = true;
            this.customTimeRadioBtn.CheckedChanged += new System.EventHandler(this.customTimeRadioBtn_CheckedChanged);
            // 
            // stopBtn
            // 
            this.stopBtn.BackColor = System.Drawing.Color.Transparent;
            this.stopBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stopBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stopBtn.Location = new System.Drawing.Point(220, 17);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(75, 75);
            this.stopBtn.TabIndex = 8;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = false;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(318, 203);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.customTimeRadioBtn);
            this.Controls.Add(this.timeRadioBtn);
            this.Controls.Add(this.minutesPicker);
            this.Controls.Add(this.hoursPicker);
            this.Controls.Add(this.logTB);
            this.Controls.Add(this.customPicker);
            this.Controls.Add(this.timeInput);
            this.Controls.Add(this.stopBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shutdown Timer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox logTB;
        private System.Windows.Forms.RadioButton timeRadioBtn;
        private System.Windows.Forms.RadioButton customTimeRadioBtn;
        private System.Windows.Forms.Button stopBtn;
        public System.Windows.Forms.TextBox timeInput;
        public System.Windows.Forms.ComboBox customPicker;
        public System.Windows.Forms.Button startBtn;
        public System.Windows.Forms.ComboBox hoursPicker;
        public System.Windows.Forms.ComboBox minutesPicker;
    }
}

