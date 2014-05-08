using System;
using System.Windows.Forms;
using System.Drawing;

namespace AKclock{
    public partial class AKclockSettingsForm : Form {
        public AKclockSettingsForm(){
            InitializeComponent();
        }

        private void AKclockSettingsForm_Load(object sender, EventArgs e) {
            LoadDataFromSettings();
        }

        // set preview label from settings values
        private void LoadDataFromSettings() {
            formWidth.Value = Convert.ToInt32(Settings.GetDictionaryValue("formWidth"));
            formHeight.Value = Convert.ToInt32(Settings.GetDictionaryValue("formHeight"));
            string corner = Settings.GetDictionaryValue("screenCorner");
            switch (corner) {
                case "1":   // top left
                    screenCorner1.Checked = true;
                    break;
                case "2":   // top right
                    screenCorner2.Checked = true;
                    break;
                case "3":   // bottom left
                    screenCorner3.Checked = true;
                    break;
                case "4":   // bottom right
                    screenCorner4.Checked = true;
                    break;
            }
            previewLabel.Font = new Font(
                Settings.GetDictionaryValue("fontName"),
                float.Parse(Settings.GetDictionaryValue("fontSize")));
            if (Convert.ToBoolean(Settings.GetDictionaryValue("fontBold"))) {
                previewLabel.Font = new Font(previewLabel.Font, previewLabel.Font.Style | FontStyle.Bold);
            }
            if (Convert.ToBoolean(Settings.GetDictionaryValue("fontItalic"))) {
                previewLabel.Font = new Font(previewLabel.Font, previewLabel.Font.Style | FontStyle.Italic);
            }
            if (Convert.ToBoolean(Settings.GetDictionaryValue("fontStrikeout"))) {
                previewLabel.Font = new Font(previewLabel.Font, previewLabel.Font.Style | FontStyle.Strikeout);
            }
            if (Convert.ToBoolean(Settings.GetDictionaryValue("fontUnderline"))) {
                previewLabel.Font = new Font(previewLabel.Font, previewLabel.Font.Style | FontStyle.Underline);
            }
            previewLabel.ForeColor = Color.FromArgb(
                Convert.ToInt32(Settings.GetDictionaryValue("fontColorRed")),
                Convert.ToInt32(Settings.GetDictionaryValue("fontColorGreen")),
                Convert.ToInt32(Settings.GetDictionaryValue("fontColorBlue")));
            previewLabel.BackColor = Color.FromArgb(
                Convert.ToInt32(Settings.GetDictionaryValue("formColorRed")),
                Convert.ToInt32(Settings.GetDictionaryValue("formColorGreen")),
                Convert.ToInt32(Settings.GetDictionaryValue("formColorBlue")));
            dateFormat.Text = Settings.GetDictionaryValue("dateFormat");
            timeFormat.Text = Settings.GetDictionaryValue("timeFormat");
            if (Convert.ToBoolean(Settings.GetDictionaryValue("dateOnTop"))) {
                DateOnTopTrue.Checked = true;
            } else {
                DateOnTopFalse.Checked = true;
            }
        }
        
        // save settings and close form
        private void okButton_Click(object sender, EventArgs e) {
            SaveUserSettings();
            this.Close();            
        }

        // TODO create button for startup location shortcut, low priority

        // close form
        private void cancelButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        // saves settings and applies them to main form
        private void SaveUserSettings(){
            // TODO value validation for time and date formatting, medium priority
            Settings.SetDictionaryValue("formWidth", formWidth.Value.ToString());
            Settings.SetDictionaryValue("formHeight", formHeight.Value.ToString());
            string screenCorner;
            if (screenCorner1.Checked)
                screenCorner = "1";
            else if (screenCorner2.Checked)
                screenCorner = "2";
            else if (screenCorner3.Checked)
                screenCorner = "3";
            else
                screenCorner = "4";
            Settings.SetDictionaryValue("screenCorner", screenCorner);
            Settings.SetDictionaryValue("fontName", previewLabel.Font.Name);
            Settings.SetDictionaryValue("fontSize", previewLabel.Font.Size.ToString());
            Settings.SetDictionaryValue("fontBold", previewLabel.Font.Bold.ToString());
            Settings.SetDictionaryValue("fontItalic", previewLabel.Font.Italic.ToString());
            Settings.SetDictionaryValue("fontStrikeout", previewLabel.Font.Strikeout.ToString());
            Settings.SetDictionaryValue("fontUnderline", previewLabel.Font.Underline.ToString());
            Settings.SetDictionaryValue("fontColorRed", previewLabel.ForeColor.R.ToString());
            Settings.SetDictionaryValue("fontColorGreen", previewLabel.ForeColor.G.ToString());
            Settings.SetDictionaryValue("fontColorBlue", previewLabel.ForeColor.B.ToString());
            Settings.SetDictionaryValue("formColorRed", previewLabel.BackColor.R.ToString());
            Settings.SetDictionaryValue("formColorGreen", previewLabel.BackColor.G.ToString());
            Settings.SetDictionaryValue("formColorBlue", previewLabel.BackColor.B.ToString());
            Settings.SetDictionaryValue("dateFormat", dateFormat.Text);
            Settings.SetDictionaryValue("timeFormat", timeFormat.Text);
            string dateOnTop;
            if (DateOnTopTrue.Checked)
                dateOnTop = "true";
            else
                dateOnTop = "false";
            Settings.SetDictionaryValue("dateOnTop", dateOnTop);
            Settings.WriteToFile();
            AKclockForm parent = (AKclockForm)this.Owner;
            parent.SetProgramValues();  // apply saved settings to main form
        }

        // allow main form to be topmost
        private void AKclockSettingsForm_FormClosed(object sender, FormClosedEventArgs e) {
            AKclockForm.ShouldBeTop = true;
        }

        // set name, size, and style of clock font
        private void fontStyleButton_Click(object sender, EventArgs e) {
            fontStyleDialog.Font = previewLabel.Font;   // load current font
            if (fontStyleDialog.ShowDialog() == DialogResult.OK) {
                previewLabel.Font = fontStyleDialog.Font;
            }
        }

        // set font color of clock
        private void fontColorButton_Click(object sender, EventArgs e) {
            fontColorDialog.Color = previewLabel.ForeColor; // load current color
            if (fontColorDialog.ShowDialog() == DialogResult.OK) {
                previewLabel.ForeColor = fontColorDialog.Color;
            }
        }

        // set background color of clock
        private void formColor_Click_1(object sender, EventArgs e) {
            formColorDialog.Color = previewLabel.BackColor; // load current color
            if (formColorDialog.ShowDialog() == DialogResult.OK) {
                previewLabel.BackColor = formColorDialog.Color;
            }
        }

        // set date and time formats to original values
        private void setDefaultFormatsButton_Click(object sender, EventArgs e) {
            dateFormat.Text = "ddd MMM d";
            timeFormat.Text = "h:mm:ss tt";
        }

        // TODO use timer to apply date/time fomat changes as they happen, medium priority
        // update preview label in real time
        private void previewTimer_Tick(object sender, EventArgs e) {
            SetPreviewLabel();
        }

        // updates the preview label
        private void SetPreviewLabel() {
            string dateFormat = DateTime.Now.ToString(Settings.GetDictionaryValue("dateFormat"));
            string timeFormat = DateTime.Now.ToString(Settings.GetDictionaryValue("timeFormat")).ToLower();
            if (Convert.ToBoolean(Settings.GetDictionaryValue("dateOnTop"))) {
                previewLabel.Text = dateFormat + "\n" + timeFormat;
            } else {
                previewLabel.Text = timeFormat + "\n" + dateFormat;
            }
        }

        // reset everything to undo big mistakes
        private void resetButton_Click(object sender, EventArgs e) {
            Settings.CreateDefaultValues();
            Settings.WriteToFile();
            LoadDataFromSettings();
            SetPreviewLabel();
            AKclockForm parent = (AKclockForm)this.Owner;
            parent.SetProgramValues();  // apply saved settings to main form
        }
    }
}
