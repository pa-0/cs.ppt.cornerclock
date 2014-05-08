using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace AKclock{
    public partial class AKclockCalendarForm : Form{
        private int padding = 10;    // how many pixels to stay away from edge

        public AKclockCalendarForm(){
            InitializeComponent();
        }

        // position form on screen
        private void AKclockCalendarForm_Load(object sender, EventArgs e){
            SetCalendarPosition();
        }

        // open windows time and date settings
        private void windowsDateTimeButton_Click(object sender, EventArgs e){
            Process.Start("timedate.cpl");
        }

        // positions calendar on screen based on corner being used
        public void SetCalendarPosition() {
            string corner = Settings.GetDictionaryValue("screenCorner");
            switch (corner) {
                case "1":   // top left
                    this.Top = (Screen.PrimaryScreen.WorkingArea.Top + padding);
                    this.Left = (Screen.PrimaryScreen.WorkingArea.Left + padding);
                    break;
                case "2":   // top right
                    this.Top = (Screen.PrimaryScreen.WorkingArea.Top + padding);
                    this.Left = (Screen.PrimaryScreen.WorkingArea.Right - (this.Width + padding));
                    break;
                case "3":   // bottom left
                    this.Top = (Screen.PrimaryScreen.WorkingArea.Bottom - (this.Height + padding));
                    this.Left = (Screen.PrimaryScreen.WorkingArea.Left + padding);
                    break;
                case "4":   // bottom right
                    this.Top = (Screen.PrimaryScreen.WorkingArea.Bottom - (this.Height + padding));
                    this.Left = (Screen.PrimaryScreen.WorkingArea.Right - (this.Width + padding));
                    break;
            }
        }

        // hide form when not in focus
        private void AKclockCalendarForm_Deactivate(object sender, EventArgs e){
            this.Hide();
            AKclockForm.ShouldBeTop = true;
        }
    }
}
