namespace BatterySaver_Prototype1
{
    partial class BatterySaverForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BatterySaverForm));
            this.batteryTextLabel = new System.Windows.Forms.Label();
            this.checkTimer = new System.Windows.Forms.Timer(this.components);
            this.batteryPercentLabel = new System.Windows.Forms.Label();
            this.batteryNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.powerStatusLabel = new System.Windows.Forms.Label();
            this.powerStatusTextLabel = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.minimizePictureBox = new System.Windows.Forms.PictureBox();
            this.closePictureBox = new System.Windows.Forms.PictureBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.mainPage = new System.Windows.Forms.TabPage();
            this.settingsPage = new System.Windows.Forms.TabPage();
            this.maxLevelLabel = new System.Windows.Forms.Label();
            this.logoLabel = new System.Windows.Forms.Label();
            this.batteryLogo = new System.Windows.Forms.PictureBox();
            this.teamLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).BeginInit();
            this.tabControl.SuspendLayout();
            this.mainPage.SuspendLayout();
            this.settingsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batteryLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // batteryTextLabel
            // 
            this.batteryTextLabel.AutoSize = true;
            this.batteryTextLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batteryTextLabel.Location = new System.Drawing.Point(15, 19);
            this.batteryTextLabel.Name = "batteryTextLabel";
            this.batteryTextLabel.Size = new System.Drawing.Size(174, 37);
            this.batteryTextLabel.TabIndex = 0;
            this.batteryTextLabel.Text = "Battery Level:";
            // 
            // checkTimer
            // 
            this.checkTimer.Enabled = true;
            this.checkTimer.Interval = 1000;
            this.checkTimer.Tick += new System.EventHandler(this.checkTimer_Tick);
            // 
            // batteryPercentLabel
            // 
            this.batteryPercentLabel.AutoSize = true;
            this.batteryPercentLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.batteryPercentLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batteryPercentLabel.Location = new System.Drawing.Point(207, 26);
            this.batteryPercentLabel.Name = "batteryPercentLabel";
            this.batteryPercentLabel.Size = new System.Drawing.Size(14, 30);
            this.batteryPercentLabel.TabIndex = 1;
            this.batteryPercentLabel.Text = "\r\n";
            this.toolTip.SetToolTip(this.batteryPercentLabel, "Shows your battery level");
            // 
            // batteryNotifyIcon
            // 
            this.batteryNotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.batteryNotifyIcon.BalloonTipText = "Battery Saver";
            this.batteryNotifyIcon.BalloonTipTitle = "Your battery succesfully charged. ";
            this.batteryNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("batteryNotifyIcon.Icon")));
            this.batteryNotifyIcon.Text = "BatterySaver";
            this.batteryNotifyIcon.Visible = true;
            this.batteryNotifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.batteryNotifyIcon_MouseClick);
            // 
            // powerStatusLabel
            // 
            this.powerStatusLabel.AutoSize = true;
            this.powerStatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.powerStatusLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerStatusLabel.Location = new System.Drawing.Point(207, 75);
            this.powerStatusLabel.Name = "powerStatusLabel";
            this.powerStatusLabel.Size = new System.Drawing.Size(14, 30);
            this.powerStatusLabel.TabIndex = 6;
            this.powerStatusLabel.Text = "\r\n";
            this.toolTip.SetToolTip(this.powerStatusLabel, "Shows your adapter status");
            // 
            // powerStatusTextLabel
            // 
            this.powerStatusTextLabel.AutoSize = true;
            this.powerStatusTextLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerStatusTextLabel.Location = new System.Drawing.Point(15, 68);
            this.powerStatusTextLabel.Name = "powerStatusTextLabel";
            this.powerStatusTextLabel.Size = new System.Drawing.Size(174, 37);
            this.powerStatusTextLabel.TabIndex = 5;
            this.powerStatusTextLabel.Text = "Power Status:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(120, 18);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(120, 30);
            this.numericUpDown1.TabIndex = 0;
            this.toolTip.SetToolTip(this.numericUpDown1, "80% Is recommended");
            this.numericUpDown1.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // minimizePictureBox
            // 
            this.minimizePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizePictureBox.Image = global::BatterySaver_Prototype1.Properties.Resources.minimizeIcon;
            this.minimizePictureBox.Location = new System.Drawing.Point(516, 12);
            this.minimizePictureBox.Name = "minimizePictureBox";
            this.minimizePictureBox.Size = new System.Drawing.Size(23, 21);
            this.minimizePictureBox.TabIndex = 8;
            this.minimizePictureBox.TabStop = false;
            this.toolTip.SetToolTip(this.minimizePictureBox, "Click to minimize");
            this.minimizePictureBox.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // closePictureBox
            // 
            this.closePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("closePictureBox.Image")));
            this.closePictureBox.Location = new System.Drawing.Point(554, 12);
            this.closePictureBox.Name = "closePictureBox";
            this.closePictureBox.Size = new System.Drawing.Size(23, 21);
            this.closePictureBox.TabIndex = 7;
            this.closePictureBox.TabStop = false;
            this.toolTip.SetToolTip(this.closePictureBox, "Click to close");
            this.closePictureBox.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.mainPage);
            this.tabControl.Controls.Add(this.settingsPage);
            this.tabControl.Location = new System.Drawing.Point(12, 74);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(569, 176);
            this.tabControl.TabIndex = 5;
            // 
            // mainPage
            // 
            this.mainPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mainPage.Controls.Add(this.powerStatusLabel);
            this.mainPage.Controls.Add(this.batteryTextLabel);
            this.mainPage.Controls.Add(this.powerStatusTextLabel);
            this.mainPage.Controls.Add(this.batteryPercentLabel);
            this.mainPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainPage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mainPage.Location = new System.Drawing.Point(4, 22);
            this.mainPage.Name = "mainPage";
            this.mainPage.Padding = new System.Windows.Forms.Padding(3);
            this.mainPage.Size = new System.Drawing.Size(561, 150);
            this.mainPage.TabIndex = 0;
            this.mainPage.Text = "Main";
            // 
            // settingsPage
            // 
            this.settingsPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.settingsPage.Controls.Add(this.maxLevelLabel);
            this.settingsPage.Controls.Add(this.numericUpDown1);
            this.settingsPage.Location = new System.Drawing.Point(4, 22);
            this.settingsPage.Name = "settingsPage";
            this.settingsPage.Padding = new System.Windows.Forms.Padding(3);
            this.settingsPage.Size = new System.Drawing.Size(561, 150);
            this.settingsPage.TabIndex = 1;
            this.settingsPage.Text = "Settings";
            // 
            // maxLevelLabel
            // 
            this.maxLevelLabel.AutoSize = true;
            this.maxLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLevelLabel.Location = new System.Drawing.Point(17, 20);
            this.maxLevelLabel.Name = "maxLevelLabel";
            this.maxLevelLabel.Size = new System.Drawing.Size(97, 25);
            this.maxLevelLabel.TabIndex = 1;
            this.maxLevelLabel.Text = "MaxLevel";
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoLabel.Location = new System.Drawing.Point(74, 23);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(193, 36);
            this.logoLabel.TabIndex = 10;
            this.logoLabel.Text = "Battery Saver";
            // 
            // batteryLogo
            // 
            this.batteryLogo.Image = global::BatterySaver_Prototype1.Properties.Resources.Webp_net_resizeimage__1_;
            this.batteryLogo.Location = new System.Drawing.Point(16, 12);
            this.batteryLogo.Name = "batteryLogo";
            this.batteryLogo.Size = new System.Drawing.Size(52, 56);
            this.batteryLogo.TabIndex = 9;
            this.batteryLogo.TabStop = false;
            // 
            // teamLabel
            // 
            this.teamLabel.AutoSize = true;
            this.teamLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamLabel.Location = new System.Drawing.Point(9, 256);
            this.teamLabel.Name = "teamLabel";
            this.teamLabel.Size = new System.Drawing.Size(77, 14);
            this.teamLabel.TabIndex = 11;
            this.teamLabel.Text = "By RicoTeam";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(551, 257);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(39, 13);
            this.versionLabel.TabIndex = 12;
            this.versionLabel.Text = "v1.2.0";
            // 
            // BatterySaverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 278);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.teamLabel);
            this.Controls.Add(this.logoLabel);
            this.Controls.Add(this.batteryLogo);
            this.Controls.Add(this.minimizePictureBox);
            this.Controls.Add(this.closePictureBox);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BatterySaverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BatterySaver";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BatterySaverForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BatterySaverForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.mainPage.ResumeLayout(false);
            this.mainPage.PerformLayout();
            this.settingsPage.ResumeLayout(false);
            this.settingsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batteryLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label batteryTextLabel;
        private System.Windows.Forms.Timer checkTimer;
        private System.Windows.Forms.Label batteryPercentLabel;
        private System.Windows.Forms.NotifyIcon batteryNotifyIcon;
        private System.Windows.Forms.Label powerStatusLabel;
        private System.Windows.Forms.Label powerStatusTextLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage mainPage;
        private System.Windows.Forms.TabPage settingsPage;
        private System.Windows.Forms.Label maxLevelLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.PictureBox closePictureBox;
        private System.Windows.Forms.PictureBox minimizePictureBox;
        private System.Windows.Forms.PictureBox batteryLogo;
        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.Label teamLabel;
        private System.Windows.Forms.Label versionLabel;







    }
}

