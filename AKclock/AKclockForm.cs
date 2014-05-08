using System;
using System.Drawing;
using System.Windows.Forms;

namespace AKclock{
    public partial class AKclockForm : Form{
        Settings settings = new Settings();
        ActiveWindowClass activeWindowClass = new ActiveWindowClass();
        ActiveWindowSize activeWindowSize = new ActiveWindowSize();
        AKclockCalendarForm calendarForm = new AKclockCalendarForm();
        private static bool shouldBeTop = true;

        public AKclockForm(){
            InitializeComponent();
        }

        // public property
        public static bool ShouldBeTop {
            set { shouldBeTop = value; }
        }

        // icon located at http://www.iconarchive.com/show/snowish-icons-by-saki/Clock-icon.html
        // initialize form and load settings
        private void AKclockForm_Load(object sender, EventArgs e) {
            SetProgramValues();
        }

        // sets font and form values
        public void SetProgramValues() {
            this.Width = Convert.ToInt32(Settings.GetDictionaryValue("formWidth"));
            this.Height = Convert.ToInt32(Settings.GetDictionaryValue("formHeight"));
            string corner = Settings.GetDictionaryValue("screenCorner");
            switch (corner) {
                case "1":   // top left
                    this.Top = (Screen.PrimaryScreen.Bounds.Top);
                    this.Left = (Screen.PrimaryScreen.Bounds.Left);
                    break;
                case "2":   // top right
                    this.Top = (Screen.PrimaryScreen.Bounds.Top);
                    this.Left = (Screen.PrimaryScreen.Bounds.Right - this.Width);
                    break;
                case "3":   // bottom left
                    this.Top = (Screen.PrimaryScreen.Bounds.Bottom - this.Height);
                    this.Left = (Screen.PrimaryScreen.Bounds.Left);
                    break;
                case "4":   // bottom right
                    this.Top = (Screen.PrimaryScreen.Bounds.Bottom - this.Height);
                    this.Left = (Screen.PrimaryScreen.Bounds.Right - this.Width);
                    break;
            }
            calendarForm.SetCalendarPosition();
            this.timeLabel.Width = this.Width;
            this.timeLabel.Height = this.Height;
            this.timeLabel.Font = new Font(
                Settings.GetDictionaryValue("fontName"),
                float.Parse(Settings.GetDictionaryValue("fontSize")));
            if (Convert.ToBoolean(Settings.GetDictionaryValue("fontBold"))) {
                timeLabel.Font = new Font(timeLabel.Font, timeLabel.Font.Style | FontStyle.Bold);
            }
            if (Convert.ToBoolean(Settings.GetDictionaryValue("fontItalic"))) {
                timeLabel.Font = new Font(timeLabel.Font, timeLabel.Font.Style | FontStyle.Italic);
            }
            if (Convert.ToBoolean(Settings.GetDictionaryValue("fontStrikeout"))) {
                timeLabel.Font = new Font(timeLabel.Font, timeLabel.Font.Style | FontStyle.Strikeout);
            }
            if (Convert.ToBoolean(Settings.GetDictionaryValue("fontUnderline"))) {
                timeLabel.Font = new Font(timeLabel.Font, timeLabel.Font.Style | FontStyle.Underline);
            }
            this.timeLabel.ForeColor = Color.FromArgb(
                Convert.ToInt32(Settings.GetDictionaryValue("fontColorRed")),
                Convert.ToInt32(Settings.GetDictionaryValue("fontColorGreen")),
                Convert.ToInt32(Settings.GetDictionaryValue("fontColorBlue")));
            this.BackColor = Color.FromArgb(
                Convert.ToInt32(Settings.GetDictionaryValue("formColorRed")),
                Convert.ToInt32(Settings.GetDictionaryValue("formColorGreen")),
                Convert.ToInt32(Settings.GetDictionaryValue("formColorBlue")));
        }

        // checks to see if any other app is fullscreen such as youtube video
        private void DetectFullScreenApps() {
            activeWindowSize.IsFullScreen = ActiveWindowSize.IsForegroundFullScreen();
            if (activeWindowSize.IsFullScreen) {
                activeWindowClass.GetActiveWindow();    // see if desktop is the fullscreen app
                if (!activeWindowClass.IsDesktopActive) {
                    // hide form to allow other app the entire screen
                    // unless the other app is the desktop
                    this.Visible = false;
                }
            } else {    // make form visible
                this.Visible = true;
            }
        }

        // displays time and date on label
        private void SetTimeLabel(){
            string dateFormat = DateTime.Now.ToString(Settings.GetDictionaryValue("dateFormat"));
            string timeFormat = DateTime.Now.ToString(Settings.GetDictionaryValue("timeFormat")).ToLower();
            if (Convert.ToBoolean(Settings.GetDictionaryValue("dateOnTop"))) {
                this.timeLabel.Text = dateFormat + "\n" + timeFormat;
            } else {
                this.timeLabel.Text = timeFormat + "\n" + dateFormat;
            }
        }

        // sets the form on top unless calendar or settings window are visible
        private void SetFormTopMost() {
            if (shouldBeTop) {
                this.TopMost = true;
            }
        }

        // exit program
        private void toolStripMenuItemExit_Click(object sender, EventArgs e){
            this.Close();
        }

        // show menu on right click
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e){
            shouldBeTop = false;
            using (AKclockSettingsForm settingsForm = new AKclockSettingsForm()) {
                settingsForm.ShowDialog(this);
            }
        }

        // show calendar on left click
        // TODO set date to today, if possible
        private void timeLabel_MouseClick(object sender, MouseEventArgs e){
            if (e.Button == MouseButtons.Left){
                shouldBeTop = false;
                calendarForm.Show();
            }
        }

        // update time and visibility every second
        private void timer_Tick(object sender, EventArgs e) {
            DetectFullScreenApps();
            SetFormTopMost();
            SetTimeLabel();
        }

        // hides borderless form from alt-tab menu
        // taken from http://www.csharp411.com/hide-form-from-alttab/
        protected override CreateParams CreateParams {
            get {
                CreateParams cp = base.CreateParams;
                // turn on WS_EX_TOOLWINDOW style bit
                cp.ExStyle |= 0x80;
                return cp;
            }
        }
    }
}

//CHANGELOG UPDATED 2014-05-08
//0.2
//initial commit to bitbucket
//settings: removed apply button
//settings: created reset all button
//form now updates labels every 10ms instead of 1000ms
//settings: changed form colors to match Windows 8.1 theme
//
//0.1
//initial version