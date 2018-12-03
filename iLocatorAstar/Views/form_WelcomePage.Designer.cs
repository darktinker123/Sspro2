﻿namespace iLocatorAstar
{
    partial class form_WelcomePage
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_WelcomePage));
            this.panel_ContainerWelcome = new System.Windows.Forms.Panel();
            this.panel_SystemStatus = new System.Windows.Forms.Panel();
            this.lbl_VarSysCurrentFloor = new System.Windows.Forms.Label();
            this.lbl_SysCurrentFloor = new System.Windows.Forms.Label();
            this.lbl_TimeToday = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_Next = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tableLayoutPanel_SocialMedia = new System.Windows.Forms.TableLayoutPanel();
            this.pb_Settings = new System.Windows.Forms.PictureBox();
            this.panel_LogoTitle = new System.Windows.Forms.Panel();
            this.lbl_WelcomeDescription = new System.Windows.Forms.Label();
            this.lbl_iLocatorWelcomePage = new System.Windows.Forms.Label();
            this.pb_ACTIco = new System.Windows.Forms.PictureBox();
            this.panel_ControlBox = new System.Windows.Forms.Panel();
            this.pb_iLocatorLogo = new System.Windows.Forms.PictureBox();
            this.lbl_FormTitle = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.PictureBox();
            this.bunifuTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.Time_Timer = new System.Windows.Forms.Timer(this.components);
            this.panel_ContainerWelcome.SuspendLayout();
            this.panel_SystemStatus.SuspendLayout();
            this.tableLayoutPanel_SocialMedia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Settings)).BeginInit();
            this.panel_LogoTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ACTIco)).BeginInit();
            this.panel_ControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_iLocatorLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_ContainerWelcome
            // 
            this.panel_ContainerWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_ContainerWelcome.Controls.Add(this.panel_SystemStatus);
            this.panel_ContainerWelcome.Controls.Add(this.lbl_TimeToday);
            this.panel_ContainerWelcome.Controls.Add(this.btn_Next);
            this.panel_ContainerWelcome.Controls.Add(this.tableLayoutPanel_SocialMedia);
            this.panel_ContainerWelcome.Controls.Add(this.panel_LogoTitle);
            this.bunifuTransition.SetDecoration(this.panel_ContainerWelcome, BunifuAnimatorNS.DecorationType.None);
            this.panel_ContainerWelcome.Location = new System.Drawing.Point(12, 53);
            this.panel_ContainerWelcome.Name = "panel_ContainerWelcome";
            this.panel_ContainerWelcome.Size = new System.Drawing.Size(812, 549);
            this.panel_ContainerWelcome.TabIndex = 0;
            this.panel_ContainerWelcome.Visible = false;
            // 
            // panel_SystemStatus
            // 
            this.panel_SystemStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_SystemStatus.Controls.Add(this.lbl_VarSysCurrentFloor);
            this.panel_SystemStatus.Controls.Add(this.lbl_SysCurrentFloor);
            this.bunifuTransition.SetDecoration(this.panel_SystemStatus, BunifuAnimatorNS.DecorationType.None);
            this.panel_SystemStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_SystemStatus.Location = new System.Drawing.Point(606, 3);
            this.panel_SystemStatus.Name = "panel_SystemStatus";
            this.panel_SystemStatus.Size = new System.Drawing.Size(218, 61);
            this.panel_SystemStatus.TabIndex = 7;
            // 
            // lbl_VarSysCurrentFloor
            // 
            this.lbl_VarSysCurrentFloor.AutoSize = true;
            this.bunifuTransition.SetDecoration(this.lbl_VarSysCurrentFloor, BunifuAnimatorNS.DecorationType.None);
            this.lbl_VarSysCurrentFloor.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VarSysCurrentFloor.ForeColor = System.Drawing.Color.Black;
            this.lbl_VarSysCurrentFloor.Location = new System.Drawing.Point(14, 28);
            this.lbl_VarSysCurrentFloor.Name = "lbl_VarSysCurrentFloor";
            this.lbl_VarSysCurrentFloor.Size = new System.Drawing.Size(21, 22);
            this.lbl_VarSysCurrentFloor.TabIndex = 2;
            this.lbl_VarSysCurrentFloor.Text = "$";
            // 
            // lbl_SysCurrentFloor
            // 
            this.lbl_SysCurrentFloor.AutoSize = true;
            this.bunifuTransition.SetDecoration(this.lbl_SysCurrentFloor, BunifuAnimatorNS.DecorationType.None);
            this.lbl_SysCurrentFloor.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SysCurrentFloor.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_SysCurrentFloor.Location = new System.Drawing.Point(14, 3);
            this.lbl_SysCurrentFloor.Name = "lbl_SysCurrentFloor";
            this.lbl_SysCurrentFloor.Size = new System.Drawing.Size(133, 22);
            this.lbl_SysCurrentFloor.TabIndex = 2;
            this.lbl_SysCurrentFloor.Text = "Current Floor:";
            // 
            // lbl_TimeToday
            // 
            this.lbl_TimeToday.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_TimeToday.AutoSize = true;
            this.bunifuTransition.SetDecoration(this.lbl_TimeToday, BunifuAnimatorNS.DecorationType.None);
            this.lbl_TimeToday.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TimeToday.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_TimeToday.Location = new System.Drawing.Point(343, 512);
            this.lbl_TimeToday.Name = "lbl_TimeToday";
            this.lbl_TimeToday.Size = new System.Drawing.Size(16, 24);
            this.lbl_TimeToday.TabIndex = 6;
            this.lbl_TimeToday.Text = " ";
            this.lbl_TimeToday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_TimeToday.Visible = false;
            // 
            // btn_Next
            // 
            this.btn_Next.Activecolor = System.Drawing.Color.SkyBlue;
            this.btn_Next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Next.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Next.BorderRadius = 0;
            this.btn_Next.ButtonText = "Next";
            this.btn_Next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition.SetDecoration(this.btn_Next, BunifuAnimatorNS.DecorationType.None);
            this.btn_Next.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Next.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Next.Iconimage = null;
            this.btn_Next.Iconimage_right = null;
            this.btn_Next.Iconimage_right_Selected = null;
            this.btn_Next.Iconimage_Selected = null;
            this.btn_Next.IconMarginLeft = 0;
            this.btn_Next.IconMarginRight = 0;
            this.btn_Next.IconRightVisible = true;
            this.btn_Next.IconRightZoom = 0D;
            this.btn_Next.IconVisible = true;
            this.btn_Next.IconZoom = 90D;
            this.btn_Next.IsTab = false;
            this.btn_Next.Location = new System.Drawing.Point(629, 482);
            this.btn_Next.Margin = new System.Windows.Forms.Padding(1);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.btn_Next.OnHovercolor = System.Drawing.Color.SkyBlue;
            this.btn_Next.OnHoverTextColor = System.Drawing.Color.Black;
            this.btn_Next.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Next.selected = false;
            this.btn_Next.Size = new System.Drawing.Size(167, 53);
            this.btn_Next.TabIndex = 4;
            this.btn_Next.Text = "Next";
            this.btn_Next.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Next.Textcolor = System.Drawing.Color.White;
            this.btn_Next.TextFont = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // tableLayoutPanel_SocialMedia
            // 
            this.tableLayoutPanel_SocialMedia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel_SocialMedia.ColumnCount = 5;
            this.tableLayoutPanel_SocialMedia.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.0212F));
            this.tableLayoutPanel_SocialMedia.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.14134F));
            this.tableLayoutPanel_SocialMedia.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.08127F));
            this.tableLayoutPanel_SocialMedia.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.90813F));
            this.tableLayoutPanel_SocialMedia.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_SocialMedia.Controls.Add(this.pb_Settings, 0, 0);
            this.bunifuTransition.SetDecoration(this.tableLayoutPanel_SocialMedia, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel_SocialMedia.Location = new System.Drawing.Point(12, 496);
            this.tableLayoutPanel_SocialMedia.Name = "tableLayoutPanel_SocialMedia";
            this.tableLayoutPanel_SocialMedia.RowCount = 1;
            this.tableLayoutPanel_SocialMedia.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_SocialMedia.Size = new System.Drawing.Size(283, 42);
            this.tableLayoutPanel_SocialMedia.TabIndex = 2;
            // 
            // pb_Settings
            // 
            this.pb_Settings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_Settings.BackgroundImage")));
            this.pb_Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition.SetDecoration(this.pb_Settings, BunifuAnimatorNS.DecorationType.None);
            this.pb_Settings.Location = new System.Drawing.Point(3, 3);
            this.pb_Settings.Name = "pb_Settings";
            this.pb_Settings.Size = new System.Drawing.Size(45, 36);
            this.pb_Settings.TabIndex = 4;
            this.pb_Settings.TabStop = false;
            this.pb_Settings.Click += new System.EventHandler(this.pb_Settings_Click);
            // 
            // panel_LogoTitle
            // 
            this.panel_LogoTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_LogoTitle.BackColor = System.Drawing.SystemColors.Control;
            this.panel_LogoTitle.Controls.Add(this.lbl_WelcomeDescription);
            this.panel_LogoTitle.Controls.Add(this.lbl_iLocatorWelcomePage);
            this.panel_LogoTitle.Controls.Add(this.pb_ACTIco);
            this.bunifuTransition.SetDecoration(this.panel_LogoTitle, BunifuAnimatorNS.DecorationType.None);
            this.panel_LogoTitle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_LogoTitle.ForeColor = System.Drawing.Color.Transparent;
            this.panel_LogoTitle.Location = new System.Drawing.Point(90, 41);
            this.panel_LogoTitle.Name = "panel_LogoTitle";
            this.panel_LogoTitle.Size = new System.Drawing.Size(658, 419);
            this.panel_LogoTitle.TabIndex = 0;
            // 
            // lbl_WelcomeDescription
            // 
            this.lbl_WelcomeDescription.AutoSize = true;
            this.bunifuTransition.SetDecoration(this.lbl_WelcomeDescription, BunifuAnimatorNS.DecorationType.None);
            this.lbl_WelcomeDescription.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WelcomeDescription.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_WelcomeDescription.Location = new System.Drawing.Point(145, 324);
            this.lbl_WelcomeDescription.Name = "lbl_WelcomeDescription";
            this.lbl_WelcomeDescription.Size = new System.Drawing.Size(397, 42);
            this.lbl_WelcomeDescription.TabIndex = 2;
            this.lbl_WelcomeDescription.Text = "Need help with directions?";
            // 
            // lbl_iLocatorWelcomePage
            // 
            this.lbl_iLocatorWelcomePage.AutoSize = true;
            this.bunifuTransition.SetDecoration(this.lbl_iLocatorWelcomePage, BunifuAnimatorNS.DecorationType.None);
            this.lbl_iLocatorWelcomePage.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_iLocatorWelcomePage.ForeColor = System.Drawing.Color.Black;
            this.lbl_iLocatorWelcomePage.Location = new System.Drawing.Point(23, 267);
            this.lbl_iLocatorWelcomePage.Name = "lbl_iLocatorWelcomePage";
            this.lbl_iLocatorWelcomePage.Size = new System.Drawing.Size(616, 57);
            this.lbl_iLocatorWelcomePage.TabIndex = 1;
            this.lbl_iLocatorWelcomePage.Text = "Welcome to the iLocator!";
            // 
            // pb_ACTIco
            // 
            this.pb_ACTIco.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_ACTIco.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_ACTIco.BackgroundImage")));
            this.pb_ACTIco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuTransition.SetDecoration(this.pb_ACTIco, BunifuAnimatorNS.DecorationType.None);
            this.pb_ACTIco.Location = new System.Drawing.Point(93, 25);
            this.pb_ACTIco.Name = "pb_ACTIco";
            this.pb_ACTIco.Size = new System.Drawing.Size(493, 234);
            this.pb_ACTIco.TabIndex = 0;
            this.pb_ACTIco.TabStop = false;
            // 
            // panel_ControlBox
            // 
            this.panel_ControlBox.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel_ControlBox.Controls.Add(this.pb_iLocatorLogo);
            this.panel_ControlBox.Controls.Add(this.lbl_FormTitle);
            this.panel_ControlBox.Controls.Add(this.btn_Close);
            this.bunifuTransition.SetDecoration(this.panel_ControlBox, BunifuAnimatorNS.DecorationType.None);
            this.panel_ControlBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ControlBox.Location = new System.Drawing.Point(0, 0);
            this.panel_ControlBox.Name = "panel_ControlBox";
            this.panel_ControlBox.Size = new System.Drawing.Size(836, 34);
            this.panel_ControlBox.TabIndex = 1;
            // 
            // pb_iLocatorLogo
            // 
            this.pb_iLocatorLogo.BackColor = System.Drawing.Color.Transparent;
            this.pb_iLocatorLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_iLocatorLogo.BackgroundImage")));
            this.pb_iLocatorLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuTransition.SetDecoration(this.pb_iLocatorLogo, BunifuAnimatorNS.DecorationType.None);
            this.pb_iLocatorLogo.Location = new System.Drawing.Point(9, 5);
            this.pb_iLocatorLogo.Name = "pb_iLocatorLogo";
            this.pb_iLocatorLogo.Size = new System.Drawing.Size(25, 25);
            this.pb_iLocatorLogo.TabIndex = 3;
            this.pb_iLocatorLogo.TabStop = false;
            // 
            // lbl_FormTitle
            // 
            this.lbl_FormTitle.AutoSize = true;
            this.bunifuTransition.SetDecoration(this.lbl_FormTitle, BunifuAnimatorNS.DecorationType.None);
            this.lbl_FormTitle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FormTitle.ForeColor = System.Drawing.Color.White;
            this.lbl_FormTitle.Location = new System.Drawing.Point(37, 10);
            this.lbl_FormTitle.Name = "lbl_FormTitle";
            this.lbl_FormTitle.Size = new System.Drawing.Size(159, 16);
            this.lbl_FormTitle.TabIndex = 2;
            this.lbl_FormTitle.Text = "iLocator | Welcome Page";
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Close.BackgroundImage")));
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition.SetDecoration(this.btn_Close, BunifuAnimatorNS.DecorationType.None);
            this.btn_Close.Location = new System.Drawing.Point(809, 4);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(19, 27);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.TabStop = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // bunifuTransition
            // 
            this.bunifuTransition.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.bunifuTransition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.bunifuTransition.DefaultAnimation = animation1;
            this.bunifuTransition.TimeStep = 0.1F;
            // 
            // Time_Timer
            // 
            this.Time_Timer.Enabled = true;
            this.Time_Timer.Interval = 1000;
            this.Time_Timer.Tick += new System.EventHandler(this.timerTick);
            // 
            // form_WelcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 614);
            this.Controls.Add(this.panel_ControlBox);
            this.Controls.Add(this.panel_ContainerWelcome);
            this.bunifuTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "form_WelcomePage";
            this.Text = "iLocator | Welcome Page";
            this.Load += new System.EventHandler(this.form_WelcomePage_Load);
            this.panel_ContainerWelcome.ResumeLayout(false);
            this.panel_ContainerWelcome.PerformLayout();
            this.panel_SystemStatus.ResumeLayout(false);
            this.panel_SystemStatus.PerformLayout();
            this.tableLayoutPanel_SocialMedia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Settings)).EndInit();
            this.panel_LogoTitle.ResumeLayout(false);
            this.panel_LogoTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ACTIco)).EndInit();
            this.panel_ControlBox.ResumeLayout(false);
            this.panel_ControlBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_iLocatorLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_ContainerWelcome;
        private System.Windows.Forms.Panel panel_LogoTitle;
        private System.Windows.Forms.Label lbl_iLocatorWelcomePage;
        private System.Windows.Forms.PictureBox pb_ACTIco;
        private System.Windows.Forms.Panel panel_ControlBox;
        private System.Windows.Forms.PictureBox btn_Close;
        private System.Windows.Forms.Label lbl_FormTitle;
        private System.Windows.Forms.Label lbl_WelcomeDescription;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_SocialMedia;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Next;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_TimeToday;
        private System.Windows.Forms.Timer Time_Timer;
        private System.Windows.Forms.PictureBox pb_iLocatorLogo;
        private System.Windows.Forms.Panel panel_SystemStatus;
        private System.Windows.Forms.Label lbl_SysCurrentFloor;
        private System.Windows.Forms.Label lbl_VarSysCurrentFloor;
        private System.Windows.Forms.PictureBox pb_Settings;
    }
}

