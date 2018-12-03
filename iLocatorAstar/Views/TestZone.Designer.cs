namespace iLocatorAstar
{
    partial class TestZone
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestZone));
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel_SelectUser = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Parents = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_Alumni = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_Guest = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_Student = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_Back = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel_SelectUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 1F;
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
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            this.bunifuTransition1.MaxAnimationTime = 1000;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 425);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.bunifuTransition1.SetDecoration(this.button2, BunifuAnimatorNS.DecorationType.None);
            this.button2.Location = new System.Drawing.Point(29, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.bunifuTransition1.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.button1.Location = new System.Drawing.Point(29, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // panel2
            // 
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(150, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 425);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel_SelectUser
            // 
            this.tableLayoutPanel_SelectUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel_SelectUser.ColumnCount = 9;
            this.tableLayoutPanel_SelectUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.51852F));
            this.tableLayoutPanel_SelectUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.851852F));
            this.tableLayoutPanel_SelectUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.51852F));
            this.tableLayoutPanel_SelectUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.851852F));
            this.tableLayoutPanel_SelectUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.51852F));
            this.tableLayoutPanel_SelectUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.851852F));
            this.tableLayoutPanel_SelectUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.51852F));
            this.tableLayoutPanel_SelectUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.851852F));
            this.tableLayoutPanel_SelectUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.51852F));
            this.tableLayoutPanel_SelectUser.Controls.Add(this.btn_Parents, 8, 0);
            this.tableLayoutPanel_SelectUser.Controls.Add(this.btn_Alumni, 6, 0);
            this.tableLayoutPanel_SelectUser.Controls.Add(this.btn_Guest, 4, 0);
            this.tableLayoutPanel_SelectUser.Controls.Add(this.btn_Student, 2, 0);
            this.tableLayoutPanel_SelectUser.Controls.Add(this.btn_Back, 0, 0);
            this.bunifuTransition1.SetDecoration(this.tableLayoutPanel_SelectUser, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel_SelectUser.Location = new System.Drawing.Point(-94, 81);
            this.tableLayoutPanel_SelectUser.Name = "tableLayoutPanel_SelectUser";
            this.tableLayoutPanel_SelectUser.RowCount = 1;
            this.tableLayoutPanel_SelectUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_SelectUser.Size = new System.Drawing.Size(938, 263);
            this.tableLayoutPanel_SelectUser.TabIndex = 5;
            // 
            // btn_Parents
            // 
            this.btn_Parents.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Parents.color = System.Drawing.Color.RoyalBlue;
            this.btn_Parents.colorActive = System.Drawing.Color.SkyBlue;
            this.btn_Parents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_Parents, BunifuAnimatorNS.DecorationType.None);
            this.btn_Parents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Parents.Font = new System.Drawing.Font("Calibri", 20F);
            this.btn_Parents.ForeColor = System.Drawing.Color.White;
            this.btn_Parents.Image = ((System.Drawing.Image)(resources.GetObject("btn_Parents.Image")));
            this.btn_Parents.ImagePosition = 28;
            this.btn_Parents.ImageZoom = 50;
            this.btn_Parents.LabelPosition = 56;
            this.btn_Parents.LabelText = "Parent/s";
            this.btn_Parents.Location = new System.Drawing.Point(766, 7);
            this.btn_Parents.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btn_Parents.Name = "btn_Parents";
            this.btn_Parents.Size = new System.Drawing.Size(166, 249);
            this.btn_Parents.TabIndex = 2;
            // 
            // btn_Alumni
            // 
            this.btn_Alumni.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Alumni.color = System.Drawing.Color.RoyalBlue;
            this.btn_Alumni.colorActive = System.Drawing.Color.SkyBlue;
            this.btn_Alumni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_Alumni, BunifuAnimatorNS.DecorationType.None);
            this.btn_Alumni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Alumni.Font = new System.Drawing.Font("Calibri", 20F);
            this.btn_Alumni.ForeColor = System.Drawing.Color.White;
            this.btn_Alumni.Image = ((System.Drawing.Image)(resources.GetObject("btn_Alumni.Image")));
            this.btn_Alumni.ImagePosition = 28;
            this.btn_Alumni.ImageZoom = 50;
            this.btn_Alumni.LabelPosition = 56;
            this.btn_Alumni.LabelText = "Alumni";
            this.btn_Alumni.Location = new System.Drawing.Point(576, 7);
            this.btn_Alumni.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btn_Alumni.Name = "btn_Alumni";
            this.btn_Alumni.Size = new System.Drawing.Size(161, 249);
            this.btn_Alumni.TabIndex = 2;
            // 
            // btn_Guest
            // 
            this.btn_Guest.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Guest.color = System.Drawing.Color.RoyalBlue;
            this.btn_Guest.colorActive = System.Drawing.Color.SkyBlue;
            this.btn_Guest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_Guest, BunifuAnimatorNS.DecorationType.None);
            this.btn_Guest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Guest.Font = new System.Drawing.Font("Calibri", 20F);
            this.btn_Guest.ForeColor = System.Drawing.Color.White;
            this.btn_Guest.Image = ((System.Drawing.Image)(resources.GetObject("btn_Guest.Image")));
            this.btn_Guest.ImagePosition = 28;
            this.btn_Guest.ImageZoom = 50;
            this.btn_Guest.LabelPosition = 56;
            this.btn_Guest.LabelText = "Guest";
            this.btn_Guest.Location = new System.Drawing.Point(386, 7);
            this.btn_Guest.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btn_Guest.Name = "btn_Guest";
            this.btn_Guest.Size = new System.Drawing.Size(161, 249);
            this.btn_Guest.TabIndex = 2;
            // 
            // btn_Student
            // 
            this.btn_Student.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Student.color = System.Drawing.Color.RoyalBlue;
            this.btn_Student.colorActive = System.Drawing.Color.SkyBlue;
            this.btn_Student.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_Student, BunifuAnimatorNS.DecorationType.None);
            this.btn_Student.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Student.Font = new System.Drawing.Font("Calibri", 20F);
            this.btn_Student.ForeColor = System.Drawing.Color.White;
            this.btn_Student.Image = ((System.Drawing.Image)(resources.GetObject("btn_Student.Image")));
            this.btn_Student.ImagePosition = 28;
            this.btn_Student.ImageZoom = 50;
            this.btn_Student.LabelPosition = 56;
            this.btn_Student.LabelText = "Student";
            this.btn_Student.Location = new System.Drawing.Point(196, 7);
            this.btn_Student.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btn_Student.Name = "btn_Student";
            this.btn_Student.Size = new System.Drawing.Size(161, 249);
            this.btn_Student.TabIndex = 2;
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.Khaki;
            this.btn_Back.color = System.Drawing.Color.Khaki;
            this.btn_Back.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(193)))), ((int)(((byte)(0)))));
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_Back, BunifuAnimatorNS.DecorationType.None);
            this.btn_Back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Back.Font = new System.Drawing.Font("Calibri", 20F);
            this.btn_Back.ForeColor = System.Drawing.Color.Olive;
            this.btn_Back.Image = ((System.Drawing.Image)(resources.GetObject("btn_Back.Image")));
            this.btn_Back.ImagePosition = 28;
            this.btn_Back.ImageZoom = 50;
            this.btn_Back.LabelPosition = 56;
            this.btn_Back.LabelText = "Back";
            this.btn_Back.Location = new System.Drawing.Point(6, 7);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(161, 249);
            this.btn_Back.TabIndex = 2;
            // 
            // TestZone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 425);
            this.Controls.Add(this.tableLayoutPanel_SelectUser);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "TestZone";
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel_SelectUser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_SelectUser;
        private Bunifu.Framework.UI.BunifuTileButton btn_Parents;
        private Bunifu.Framework.UI.BunifuTileButton btn_Alumni;
        private Bunifu.Framework.UI.BunifuTileButton btn_Guest;
        private Bunifu.Framework.UI.BunifuTileButton btn_Student;
        private Bunifu.Framework.UI.BunifuTileButton btn_Back;
    }
}