namespace AKclock
{
    partial class AKclockSettingsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AKclockSettingsForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fontColorButton = new System.Windows.Forms.Button();
            this.fontStyleButton = new System.Windows.Forms.Button();
            this.previewLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.formColor = new System.Windows.Forms.Button();
            this.screenCorner4 = new System.Windows.Forms.RadioButton();
            this.screenCorner3 = new System.Windows.Forms.RadioButton();
            this.screenCorner2 = new System.Windows.Forms.RadioButton();
            this.formWidth = new System.Windows.Forms.NumericUpDown();
            this.screenCorner1 = new System.Windows.Forms.RadioButton();
            this.formWidthLabel = new System.Windows.Forms.Label();
            this.formScreenCornerLabel = new System.Windows.Forms.Label();
            this.formHeight = new System.Windows.Forms.NumericUpDown();
            this.formHeightLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.formColorDialog = new System.Windows.Forms.ColorDialog();
            this.fontColorDialog = new System.Windows.Forms.ColorDialog();
            this.fontStyleDialog = new System.Windows.Forms.FontDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.setDefaultFormatsButton = new System.Windows.Forms.Button();
            this.DateOnTopFalse = new System.Windows.Forms.RadioButton();
            this.DateOnTopTrue = new System.Windows.Forms.RadioButton();
            this.timeFormat = new System.Windows.Forms.TextBox();
            this.dateFormat = new System.Windows.Forms.TextBox();
            this.timeFormatDescriptionLabel = new System.Windows.Forms.Label();
            this.dateFormatDescriptionLabel = new System.Windows.Forms.Label();
            this.previewTimer = new System.Windows.Forms.Timer(this.components);
            this.resetButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formHeight)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fontColorButton);
            this.groupBox1.Controls.Add(this.fontStyleButton);
            this.groupBox1.Controls.Add(this.previewLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 150);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Font Settings and Preview";
            // 
            // fontColorButton
            // 
            this.fontColorButton.Location = new System.Drawing.Point(174, 19);
            this.fontColorButton.Name = "fontColorButton";
            this.fontColorButton.Size = new System.Drawing.Size(100, 23);
            this.fontColorButton.TabIndex = 2;
            this.fontColorButton.Text = "Color";
            this.fontColorButton.UseVisualStyleBackColor = true;
            this.fontColorButton.Click += new System.EventHandler(this.fontColorButton_Click);
            // 
            // fontStyleButton
            // 
            this.fontStyleButton.Location = new System.Drawing.Point(26, 19);
            this.fontStyleButton.Name = "fontStyleButton";
            this.fontStyleButton.Size = new System.Drawing.Size(100, 23);
            this.fontStyleButton.TabIndex = 1;
            this.fontStyleButton.Text = "Style";
            this.fontStyleButton.UseVisualStyleBackColor = true;
            this.fontStyleButton.Click += new System.EventHandler(this.fontStyleButton_Click);
            // 
            // previewLabel
            // 
            this.previewLabel.Location = new System.Drawing.Point(6, 45);
            this.previewLabel.Name = "previewLabel";
            this.previewLabel.Size = new System.Drawing.Size(288, 102);
            this.previewLabel.TabIndex = 0;
            this.previewLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.formColor);
            this.groupBox2.Controls.Add(this.screenCorner4);
            this.groupBox2.Controls.Add(this.screenCorner3);
            this.groupBox2.Controls.Add(this.screenCorner2);
            this.groupBox2.Controls.Add(this.formWidth);
            this.groupBox2.Controls.Add(this.screenCorner1);
            this.groupBox2.Controls.Add(this.formWidthLabel);
            this.groupBox2.Controls.Add(this.formScreenCornerLabel);
            this.groupBox2.Controls.Add(this.formHeight);
            this.groupBox2.Controls.Add(this.formHeightLabel);
            this.groupBox2.Location = new System.Drawing.Point(12, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Window Settings";
            // 
            // formColor
            // 
            this.formColor.Location = new System.Drawing.Point(9, 70);
            this.formColor.Name = "formColor";
            this.formColor.Size = new System.Drawing.Size(93, 23);
            this.formColor.TabIndex = 3;
            this.formColor.Text = "Color";
            this.formColor.UseVisualStyleBackColor = true;
            this.formColor.Click += new System.EventHandler(this.formColor_Click_1);
            // 
            // screenCorner4
            // 
            this.screenCorner4.Location = new System.Drawing.Point(206, 70);
            this.screenCorner4.Name = "screenCorner4";
            this.screenCorner4.Size = new System.Drawing.Size(88, 20);
            this.screenCorner4.TabIndex = 7;
            this.screenCorner4.Text = "Bottom Right";
            this.screenCorner4.UseVisualStyleBackColor = true;
            // 
            // screenCorner3
            // 
            this.screenCorner3.Location = new System.Drawing.Point(112, 70);
            this.screenCorner3.Name = "screenCorner3";
            this.screenCorner3.Size = new System.Drawing.Size(88, 20);
            this.screenCorner3.TabIndex = 6;
            this.screenCorner3.Text = "Bottom Left";
            this.screenCorner3.UseVisualStyleBackColor = true;
            // 
            // screenCorner2
            // 
            this.screenCorner2.Location = new System.Drawing.Point(206, 44);
            this.screenCorner2.Name = "screenCorner2";
            this.screenCorner2.Size = new System.Drawing.Size(88, 20);
            this.screenCorner2.TabIndex = 5;
            this.screenCorner2.Text = "Top Right";
            this.screenCorner2.UseVisualStyleBackColor = true;
            // 
            // formWidth
            // 
            this.formWidth.Location = new System.Drawing.Point(52, 18);
            this.formWidth.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.formWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.formWidth.Name = "formWidth";
            this.formWidth.Size = new System.Drawing.Size(50, 20);
            this.formWidth.TabIndex = 1;
            this.formWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // screenCorner1
            // 
            this.screenCorner1.Checked = true;
            this.screenCorner1.Location = new System.Drawing.Point(112, 44);
            this.screenCorner1.Name = "screenCorner1";
            this.screenCorner1.Size = new System.Drawing.Size(88, 20);
            this.screenCorner1.TabIndex = 4;
            this.screenCorner1.TabStop = true;
            this.screenCorner1.Text = "Top Left";
            this.screenCorner1.UseVisualStyleBackColor = true;
            // 
            // formWidthLabel
            // 
            this.formWidthLabel.Location = new System.Drawing.Point(6, 18);
            this.formWidthLabel.Name = "formWidthLabel";
            this.formWidthLabel.Size = new System.Drawing.Size(40, 20);
            this.formWidthLabel.TabIndex = 0;
            this.formWidthLabel.Text = "Width";
            this.formWidthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // formScreenCornerLabel
            // 
            this.formScreenCornerLabel.Location = new System.Drawing.Point(172, 18);
            this.formScreenCornerLabel.Name = "formScreenCornerLabel";
            this.formScreenCornerLabel.Size = new System.Drawing.Size(60, 20);
            this.formScreenCornerLabel.TabIndex = 0;
            this.formScreenCornerLabel.Text = "Position";
            this.formScreenCornerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formHeight
            // 
            this.formHeight.Location = new System.Drawing.Point(52, 44);
            this.formHeight.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.formHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.formHeight.Name = "formHeight";
            this.formHeight.Size = new System.Drawing.Size(50, 20);
            this.formHeight.TabIndex = 2;
            this.formHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // formHeightLabel
            // 
            this.formHeightLabel.Location = new System.Drawing.Point(6, 44);
            this.formHeightLabel.Name = "formHeightLabel";
            this.formHeightLabel.Size = new System.Drawing.Size(40, 20);
            this.formHeightLabel.TabIndex = 0;
            this.formHeightLabel.Text = "Height";
            this.formHeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(156, 274);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "Save";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.SystemColors.Control;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(237, 274);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // formColorDialog
            // 
            this.formColorDialog.FullOpen = true;
            // 
            // fontColorDialog
            // 
            this.fontColorDialog.FullOpen = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.setDefaultFormatsButton);
            this.groupBox3.Controls.Add(this.DateOnTopFalse);
            this.groupBox3.Controls.Add(this.DateOnTopTrue);
            this.groupBox3.Controls.Add(this.timeFormat);
            this.groupBox3.Controls.Add(this.dateFormat);
            this.groupBox3.Controls.Add(this.timeFormatDescriptionLabel);
            this.groupBox3.Controls.Add(this.dateFormatDescriptionLabel);
            this.groupBox3.Location = new System.Drawing.Point(318, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(222, 256);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Date and Time Format";
            // 
            // setDefaultFormatsButton
            // 
            this.setDefaultFormatsButton.BackColor = System.Drawing.SystemColors.Control;
            this.setDefaultFormatsButton.Location = new System.Drawing.Point(6, 200);
            this.setDefaultFormatsButton.Name = "setDefaultFormatsButton";
            this.setDefaultFormatsButton.Size = new System.Drawing.Size(206, 23);
            this.setDefaultFormatsButton.TabIndex = 3;
            this.setDefaultFormatsButton.Text = "Use default date and time formats";
            this.setDefaultFormatsButton.UseVisualStyleBackColor = false;
            this.setDefaultFormatsButton.Click += new System.EventHandler(this.setDefaultFormatsButton_Click);
            // 
            // DateOnTopFalse
            // 
            this.DateOnTopFalse.Checked = true;
            this.DateOnTopFalse.Location = new System.Drawing.Point(112, 230);
            this.DateOnTopFalse.Name = "DateOnTopFalse";
            this.DateOnTopFalse.Size = new System.Drawing.Size(100, 20);
            this.DateOnTopFalse.TabIndex = 5;
            this.DateOnTopFalse.TabStop = true;
            this.DateOnTopFalse.Text = "Time on top";
            this.DateOnTopFalse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DateOnTopFalse.UseVisualStyleBackColor = true;
            // 
            // DateOnTopTrue
            // 
            this.DateOnTopTrue.Location = new System.Drawing.Point(6, 230);
            this.DateOnTopTrue.Name = "DateOnTopTrue";
            this.DateOnTopTrue.Size = new System.Drawing.Size(100, 20);
            this.DateOnTopTrue.TabIndex = 4;
            this.DateOnTopTrue.Text = "Date on top";
            this.DateOnTopTrue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DateOnTopTrue.UseVisualStyleBackColor = true;
            // 
            // timeFormat
            // 
            this.timeFormat.Location = new System.Drawing.Point(112, 174);
            this.timeFormat.Name = "timeFormat";
            this.timeFormat.Size = new System.Drawing.Size(100, 20);
            this.timeFormat.TabIndex = 2;
            // 
            // dateFormat
            // 
            this.dateFormat.Location = new System.Drawing.Point(6, 174);
            this.dateFormat.Name = "dateFormat";
            this.dateFormat.Size = new System.Drawing.Size(100, 20);
            this.dateFormat.TabIndex = 1;
            // 
            // timeFormatDescriptionLabel
            // 
            this.timeFormatDescriptionLabel.AutoSize = true;
            this.timeFormatDescriptionLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeFormatDescriptionLabel.Location = new System.Drawing.Point(156, 16);
            this.timeFormatDescriptionLabel.Name = "timeFormatDescriptionLabel";
            this.timeFormatDescriptionLabel.Size = new System.Drawing.Size(56, 154);
            this.timeFormatDescriptionLabel.TabIndex = 0;
            this.timeFormatDescriptionLabel.Text = "Time:\r\nh  = 4\r\nhh = 04\r\nH  = 16\r\nHH = 16\r\nm  = 5\r\nmm = 05\r\ns  = 6\r\nss = 06\r\nt  = " +
    "a\r\ntt = am";
            // 
            // dateFormatDescriptionLabel
            // 
            this.dateFormatDescriptionLabel.AutoSize = true;
            this.dateFormatDescriptionLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFormatDescriptionLabel.Location = new System.Drawing.Point(6, 16);
            this.dateFormatDescriptionLabel.Name = "dateFormatDescriptionLabel";
            this.dateFormatDescriptionLabel.Size = new System.Drawing.Size(112, 154);
            this.dateFormatDescriptionLabel.TabIndex = 0;
            this.dateFormatDescriptionLabel.Text = "Date:\r\nd    = 1\r\ndd   = 01\r\nddd  = Sun\r\ndddd = Sunday\r\nM    = 2\r\nMM   = 02\r\nMMM  " +
    "= Feb\r\nMMMM = February\r\nyy   = 03\r\nyyyy = 2003";
            // 
            // previewTimer
            // 
            this.previewTimer.Enabled = true;
            this.previewTimer.Interval = 10;
            this.previewTimer.Tick += new System.EventHandler(this.previewTimer_Tick);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.SystemColors.Control;
            this.resetButton.Location = new System.Drawing.Point(318, 274);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(175, 23);
            this.resetButton.TabIndex = 6;
            this.resetButton.Text = "Reset ALL settings to default";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // AKclockSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(554, 306);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AKclockSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AKclock v0.2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AKclockSettingsForm_FormClosed);
            this.Load += new System.EventHandler(this.AKclockSettingsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.formWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formHeight)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.NumericUpDown formWidth;
        private System.Windows.Forms.Label formWidthLabel;
        private System.Windows.Forms.NumericUpDown formHeight;
        private System.Windows.Forms.Label formHeightLabel;
        private System.Windows.Forms.ColorDialog formColorDialog;
        private System.Windows.Forms.ColorDialog fontColorDialog;
        private System.Windows.Forms.Label formScreenCornerLabel;
        private System.Windows.Forms.RadioButton screenCorner1;
        private System.Windows.Forms.RadioButton screenCorner2;
        private System.Windows.Forms.RadioButton screenCorner3;
        private System.Windows.Forms.RadioButton screenCorner4;
        private System.Windows.Forms.FontDialog fontStyleDialog;
        private System.Windows.Forms.Label previewLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label dateFormatDescriptionLabel;
        private System.Windows.Forms.Label timeFormatDescriptionLabel;
        private System.Windows.Forms.RadioButton DateOnTopFalse;
        private System.Windows.Forms.RadioButton DateOnTopTrue;
        private System.Windows.Forms.TextBox timeFormat;
        private System.Windows.Forms.TextBox dateFormat;
        private System.Windows.Forms.Button fontColorButton;
        private System.Windows.Forms.Button fontStyleButton;
        private System.Windows.Forms.Button formColor;
        private System.Windows.Forms.Button setDefaultFormatsButton;
        private System.Windows.Forms.Timer previewTimer;
        private System.Windows.Forms.Button resetButton;
    }
}