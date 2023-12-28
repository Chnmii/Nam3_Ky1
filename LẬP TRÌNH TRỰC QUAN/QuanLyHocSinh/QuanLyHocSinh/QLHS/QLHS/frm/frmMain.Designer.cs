
namespace QLHS.frm
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.Sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenu = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelHome = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelHocsinh = new System.Windows.Forms.Panel();
            this.btnThongtinhocsinh = new System.Windows.Forms.Button();
            this.panelGiaovien = new System.Windows.Forms.Panel();
            this.btnGiaovien = new System.Windows.Forms.Button();
            this.panelLophoc = new System.Windows.Forms.Panel();
            this.btnLophoc = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHK1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panellogout = new System.Windows.Forms.Panel();
            this.btnDangxuat = new System.Windows.Forms.Button();
            this.Sidebartimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lbXinchao = new System.Windows.Forms.Label();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.Sidebar.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.panelHome.SuspendLayout();
            this.panelHocsinh.SuspendLayout();
            this.panelGiaovien.SuspendLayout();
            this.panelLophoc.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panellogout.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.AnimationInterval = 600;
            this.guna2BorderlessForm1.BorderRadius = 15;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // Sidebar
            // 
            this.Sidebar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Sidebar.Controls.Add(this.MenuPanel);
            this.Sidebar.Controls.Add(this.panelHome);
            this.Sidebar.Controls.Add(this.panelHocsinh);
            this.Sidebar.Controls.Add(this.panelGiaovien);
            this.Sidebar.Controls.Add(this.panelLophoc);
            this.Sidebar.Controls.Add(this.panel2);
            this.Sidebar.Controls.Add(this.panel3);
            this.Sidebar.Controls.Add(this.panellogout);
            this.Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidebar.Location = new System.Drawing.Point(0, 0);
            this.Sidebar.MaximumSize = new System.Drawing.Size(209, 586);
            this.Sidebar.MinimumSize = new System.Drawing.Size(61, 586);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(209, 586);
            this.Sidebar.TabIndex = 0;
            this.Sidebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Sidebar_MouseDown);
            // 
            // MenuPanel
            // 
            this.MenuPanel.Controls.Add(this.label1);
            this.MenuPanel.Controls.Add(this.btnMenu);
            this.MenuPanel.Location = new System.Drawing.Point(3, 3);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(206, 99);
            this.MenuPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý nhà trường";
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageRotate = 0F;
            this.btnMenu.Location = new System.Drawing.Point(3, 31);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(42, 42);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panelHome
            // 
            this.panelHome.Controls.Add(this.btnHome);
            this.panelHome.Location = new System.Drawing.Point(3, 108);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(206, 47);
            this.panelHome.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(-13, -9);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(235, 65);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "                      Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelHocsinh
            // 
            this.panelHocsinh.Controls.Add(this.btnThongtinhocsinh);
            this.panelHocsinh.Location = new System.Drawing.Point(3, 161);
            this.panelHocsinh.Name = "panelHocsinh";
            this.panelHocsinh.Size = new System.Drawing.Size(206, 47);
            this.panelHocsinh.TabIndex = 1;
            // 
            // btnThongtinhocsinh
            // 
            this.btnThongtinhocsinh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThongtinhocsinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongtinhocsinh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThongtinhocsinh.Image = ((System.Drawing.Image)(resources.GetObject("btnThongtinhocsinh.Image")));
            this.btnThongtinhocsinh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongtinhocsinh.Location = new System.Drawing.Point(-13, -9);
            this.btnThongtinhocsinh.Name = "btnThongtinhocsinh";
            this.btnThongtinhocsinh.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnThongtinhocsinh.Size = new System.Drawing.Size(235, 65);
            this.btnThongtinhocsinh.TabIndex = 2;
            this.btnThongtinhocsinh.Text = "                      Thông tin học sinh";
            this.btnThongtinhocsinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongtinhocsinh.UseVisualStyleBackColor = false;
            this.btnThongtinhocsinh.Click += new System.EventHandler(this.btnThongtinhocsinh_Click);
            // 
            // panelGiaovien
            // 
            this.panelGiaovien.Controls.Add(this.btnGiaovien);
            this.panelGiaovien.Location = new System.Drawing.Point(3, 214);
            this.panelGiaovien.Name = "panelGiaovien";
            this.panelGiaovien.Size = new System.Drawing.Size(206, 47);
            this.panelGiaovien.TabIndex = 1;
            // 
            // btnGiaovien
            // 
            this.btnGiaovien.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGiaovien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiaovien.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGiaovien.Image = ((System.Drawing.Image)(resources.GetObject("btnGiaovien.Image")));
            this.btnGiaovien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiaovien.Location = new System.Drawing.Point(-13, -9);
            this.btnGiaovien.Name = "btnGiaovien";
            this.btnGiaovien.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnGiaovien.Size = new System.Drawing.Size(235, 65);
            this.btnGiaovien.TabIndex = 2;
            this.btnGiaovien.Text = "                      Thông tin giáo viên";
            this.btnGiaovien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiaovien.UseVisualStyleBackColor = false;
            this.btnGiaovien.Click += new System.EventHandler(this.btnGiaovien_Click);
            // 
            // panelLophoc
            // 
            this.panelLophoc.Controls.Add(this.btnLophoc);
            this.panelLophoc.Location = new System.Drawing.Point(3, 267);
            this.panelLophoc.Name = "panelLophoc";
            this.panelLophoc.Size = new System.Drawing.Size(206, 47);
            this.panelLophoc.TabIndex = 1;
            // 
            // btnLophoc
            // 
            this.btnLophoc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLophoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLophoc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLophoc.Image = ((System.Drawing.Image)(resources.GetObject("btnLophoc.Image")));
            this.btnLophoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLophoc.Location = new System.Drawing.Point(-13, -9);
            this.btnLophoc.Name = "btnLophoc";
            this.btnLophoc.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnLophoc.Size = new System.Drawing.Size(235, 65);
            this.btnLophoc.TabIndex = 2;
            this.btnLophoc.Text = "                      Lớp học";
            this.btnLophoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLophoc.UseVisualStyleBackColor = false;
            this.btnLophoc.Click += new System.EventHandler(this.btnLophoc_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnHK1);
            this.panel2.Location = new System.Drawing.Point(3, 320);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 47);
            this.panel2.TabIndex = 1;
            // 
            // btnHK1
            // 
            this.btnHK1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHK1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHK1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHK1.Image = ((System.Drawing.Image)(resources.GetObject("btnHK1.Image")));
            this.btnHK1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHK1.Location = new System.Drawing.Point(-13, -9);
            this.btnHK1.Name = "btnHK1";
            this.btnHK1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnHK1.Size = new System.Drawing.Size(235, 65);
            this.btnHK1.TabIndex = 2;
            this.btnHK1.Text = "                      Bảng điểm học kỳ 1";
            this.btnHK1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHK1.UseVisualStyleBackColor = false;
            this.btnHK1.Click += new System.EventHandler(this.btnHK1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Location = new System.Drawing.Point(3, 373);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(206, 47);
            this.panel3.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(-13, -9);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(235, 65);
            this.button2.TabIndex = 2;
            this.button2.Text = "                      Bảng điểm học kỳ 2";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panellogout
            // 
            this.panellogout.Controls.Add(this.btnDangxuat);
            this.panellogout.Location = new System.Drawing.Point(3, 426);
            this.panellogout.Name = "panellogout";
            this.panellogout.Size = new System.Drawing.Size(206, 47);
            this.panellogout.TabIndex = 1;
            // 
            // btnDangxuat
            // 
            this.btnDangxuat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDangxuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangxuat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDangxuat.Image = ((System.Drawing.Image)(resources.GetObject("btnDangxuat.Image")));
            this.btnDangxuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangxuat.Location = new System.Drawing.Point(-13, -9);
            this.btnDangxuat.Name = "btnDangxuat";
            this.btnDangxuat.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnDangxuat.Size = new System.Drawing.Size(235, 65);
            this.btnDangxuat.TabIndex = 2;
            this.btnDangxuat.Text = "                      Thoát";
            this.btnDangxuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangxuat.UseVisualStyleBackColor = false;
            this.btnDangxuat.Click += new System.EventHandler(this.btnDangxuat_Click);
            // 
            // Sidebartimer
            // 
            this.Sidebartimer.Interval = 1;
            this.Sidebartimer.Tick += new System.EventHandler(this.Sidebartimer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.panel1.Controls.Add(this.lbXinchao);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(209, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1109, 37);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(774, 7);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(24, 24);
            this.guna2CirclePictureBox1.TabIndex = 1;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // lbXinchao
            // 
            this.lbXinchao.AutoSize = true;
            this.lbXinchao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbXinchao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbXinchao.Location = new System.Drawing.Point(804, 9);
            this.lbXinchao.Name = "lbXinchao";
            this.lbXinchao.Size = new System.Drawing.Size(0, 20);
            this.lbXinchao.TabIndex = 0;
            this.lbXinchao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mainpanel
            // 
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(209, 37);
            this.mainpanel.MaximumSize = new System.Drawing.Size(1257, 549);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1109, 549);
            this.mainpanel.TabIndex = 2;
            this.mainpanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainpanel_MouseDown);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1318, 586);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Sidebar.ResumeLayout(false);
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.panelHome.ResumeLayout(false);
            this.panelHocsinh.ResumeLayout(false);
            this.panelGiaovien.ResumeLayout(false);
            this.panelLophoc.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panellogout.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.FlowLayoutPanel Sidebar;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panelHocsinh;
        private System.Windows.Forms.Button btnThongtinhocsinh;
        private System.Windows.Forms.Panel panelGiaovien;
        private System.Windows.Forms.Button btnGiaovien;
        private System.Windows.Forms.Panel panelLophoc;
        private System.Windows.Forms.Button btnLophoc;
        private System.Windows.Forms.Panel panellogout;
        private System.Windows.Forms.Button btnDangxuat;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox btnMenu;
        private System.Windows.Forms.Timer Sidebartimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Label lbXinchao;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHK1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
    }
}