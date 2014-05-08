namespace AKclock
{
    partial class AKclockCalendarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AKclockCalendarForm));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.windowsDateTimeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(13, 13);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // windowsDateTimeButton
            // 
            this.windowsDateTimeButton.Location = new System.Drawing.Point(13, 187);
            this.windowsDateTimeButton.Name = "windowsDateTimeButton";
            this.windowsDateTimeButton.Size = new System.Drawing.Size(227, 23);
            this.windowsDateTimeButton.TabIndex = 1;
            this.windowsDateTimeButton.Text = "Computer date and time settings";
            this.windowsDateTimeButton.UseVisualStyleBackColor = true;
            this.windowsDateTimeButton.Click += new System.EventHandler(this.windowsDateTimeButton_Click);
            // 
            // AKclockCalendarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 222);
            this.Controls.Add(this.windowsDateTimeButton);
            this.Controls.Add(this.monthCalendar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AKclockCalendarForm";
            this.ShowInTaskbar = false;
            this.Text = "AKclockCalendarForm";
            this.Deactivate += new System.EventHandler(this.AKclockCalendarForm_Deactivate);
            this.Load += new System.EventHandler(this.AKclockCalendarForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button windowsDateTimeButton;
    }
}