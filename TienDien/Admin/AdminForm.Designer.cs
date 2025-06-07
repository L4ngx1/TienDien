namespace TienDien
{
    partial class AdminForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHello = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSignout = new System.Windows.Forms.Button();
            this.btnQLTK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnTKHD = new System.Windows.Forms.Button();
            this.btnQLHD = new System.Windows.Forms.Button();
            this.userCtrlQuanLyHD1 = new TienDien.Admin.UserCtrlQuanLyHD();
            this.userCtrlThongKeHD1 = new TienDien.Admin.UserCtrlThongKeHD();
            this.userCtrlQuanLyTK1 = new TienDien.Admin.UserCtrlQuanLyTK();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel2.Controls.Add(this.btnHello);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 204);
            this.panel2.TabIndex = 0;
            // 
            // btnHello
            // 
            this.btnHello.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnHello.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHello.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnHello.Enabled = false;
            this.btnHello.FlatAppearance.BorderSize = 0;
            this.btnHello.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHello.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHello.ForeColor = System.Drawing.Color.Navy;
            this.btnHello.Location = new System.Drawing.Point(0, 144);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(220, 60);
            this.btnHello.TabIndex = 7;
            this.btnHello.Text = "Welcome, ADMIN!";
            this.btnHello.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnHello.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TienDien.Properties.Resources.electricity_icon_original;
            this.pictureBox1.Location = new System.Drawing.Point(45, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 130);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.icon_click);
            // 
            // btnSignout
            // 
            this.btnSignout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSignout.FlatAppearance.BorderSize = 0;
            this.btnSignout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignout.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignout.ForeColor = System.Drawing.Color.Navy;
            this.btnSignout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSignout.Location = new System.Drawing.Point(0, 628);
            this.btnSignout.Name = "btnSignout";
            this.btnSignout.Size = new System.Drawing.Size(220, 33);
            this.btnSignout.TabIndex = 34;
            this.btnSignout.TabStop = false;
            this.btnSignout.Text = "Đăng Xuất";
            this.btnSignout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSignout.UseVisualStyleBackColor = true;
            this.btnSignout.Click += new System.EventHandler(this.btnSignout_Click);
            // 
            // btnQLTK
            // 
            this.btnQLTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnQLTK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLTK.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLTK.FlatAppearance.BorderSize = 0;
            this.btnQLTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLTK.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLTK.ForeColor = System.Drawing.Color.Navy;
            this.btnQLTK.Location = new System.Drawing.Point(0, 204);
            this.btnQLTK.Name = "btnQLTK";
            this.btnQLTK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnQLTK.Size = new System.Drawing.Size(220, 60);
            this.btnQLTK.TabIndex = 1;
            this.btnQLTK.TabStop = false;
            this.btnQLTK.Text = "Quản Lý Tài Khoản";
            this.btnQLTK.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnQLTK.UseVisualStyleBackColor = false;
            this.btnQLTK.Click += new System.EventHandler(this.btnQLTK_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.btnTKHD);
            this.panel1.Controls.Add(this.btnQLHD);
            this.panel1.Controls.Add(this.btnQLTK);
            this.panel1.Controls.Add(this.btnSignout);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 661);
            this.panel1.TabIndex = 37;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.Navy;
            this.pnlNav.Location = new System.Drawing.Point(0, 278);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(5, 60);
            this.pnlNav.TabIndex = 37;
            // 
            // btnTKHD
            // 
            this.btnTKHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnTKHD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTKHD.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTKHD.FlatAppearance.BorderSize = 0;
            this.btnTKHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTKHD.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTKHD.ForeColor = System.Drawing.Color.Navy;
            this.btnTKHD.Location = new System.Drawing.Point(0, 324);
            this.btnTKHD.Name = "btnTKHD";
            this.btnTKHD.Size = new System.Drawing.Size(220, 60);
            this.btnTKHD.TabIndex = 36;
            this.btnTKHD.TabStop = false;
            this.btnTKHD.Text = "Thống Kê Hóa Đơn";
            this.btnTKHD.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTKHD.UseVisualStyleBackColor = false;
            this.btnTKHD.Click += new System.EventHandler(this.btnTKHD_Click);
            // 
            // btnQLHD
            // 
            this.btnQLHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnQLHD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLHD.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLHD.FlatAppearance.BorderSize = 0;
            this.btnQLHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLHD.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLHD.ForeColor = System.Drawing.Color.Navy;
            this.btnQLHD.Location = new System.Drawing.Point(0, 264);
            this.btnQLHD.Name = "btnQLHD";
            this.btnQLHD.Size = new System.Drawing.Size(220, 60);
            this.btnQLHD.TabIndex = 35;
            this.btnQLHD.TabStop = false;
            this.btnQLHD.Text = "Quản Lý Hóa Đơn";
            this.btnQLHD.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnQLHD.UseVisualStyleBackColor = false;
            this.btnQLHD.Click += new System.EventHandler(this.btnQLHD_Click);
            // 
            // userCtrlQuanLyHD1
            // 
            this.userCtrlQuanLyHD1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userCtrlQuanLyHD1.Location = new System.Drawing.Point(220, 0);
            this.userCtrlQuanLyHD1.Name = "userCtrlQuanLyHD1";
            this.userCtrlQuanLyHD1.Size = new System.Drawing.Size(1064, 661);
            this.userCtrlQuanLyHD1.TabIndex = 40;
            this.userCtrlQuanLyHD1.Load += new System.EventHandler(this.userCtrlQuanLyHD1_Load);
            // 
            // userCtrlThongKeHD1
            // 
            this.userCtrlThongKeHD1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userCtrlThongKeHD1.Location = new System.Drawing.Point(220, 0);
            this.userCtrlThongKeHD1.Name = "userCtrlThongKeHD1";
            this.userCtrlThongKeHD1.Size = new System.Drawing.Size(1064, 661);
            this.userCtrlThongKeHD1.TabIndex = 39;
            // 
            // userCtrlQuanLyTK1
            // 
            this.userCtrlQuanLyTK1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userCtrlQuanLyTK1.Location = new System.Drawing.Point(220, 0);
            this.userCtrlQuanLyTK1.Margin = new System.Windows.Forms.Padding(4);
            this.userCtrlQuanLyTK1.Name = "userCtrlQuanLyTK1";
            this.userCtrlQuanLyTK1.Size = new System.Drawing.Size(1064, 661);
            this.userCtrlQuanLyTK1.TabIndex = 38;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.userCtrlQuanLyHD1);
            this.Controls.Add(this.userCtrlThongKeHD1);
            this.Controls.Add(this.userCtrlQuanLyTK1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMIN";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSignout;
        private System.Windows.Forms.Button btnQLTK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnTKHD;
        private System.Windows.Forms.Button btnQLHD;
        private Admin.UserCtrlQuanLyTK userCtrlQuanLyTK1;
        private Admin.UserCtrlThongKeHD userCtrlThongKeHD1;
        private Admin.UserCtrlQuanLyHD userCtrlQuanLyHD1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnHello;
    }
}