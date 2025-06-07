namespace TienDien
{
    partial class TienDienApp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSignout = new System.Windows.Forms.Button();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnTienDien = new System.Windows.Forms.Button();
            this.btnUocTinh = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHello = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tinhTienDien1 = new TienDien.TinhTienDien();
            this.dashboard1 = new TienDien.Dashboard();
            this.uocTinh1 = new TienDien.UocTinh();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.btnSignout);
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.btnTienDien);
            this.panel1.Controls.Add(this.btnUocTinh);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 700);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Mouse_Move);
            // 
            // btnSignout
            // 
            this.btnSignout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSignout.FlatAppearance.BorderSize = 0;
            this.btnSignout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignout.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignout.ForeColor = System.Drawing.Color.Navy;
            this.btnSignout.Image = global::TienDien.Properties.Resources.shutdown_25px;
            this.btnSignout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSignout.Location = new System.Drawing.Point(0, 650);
            this.btnSignout.Name = "btnSignout";
            this.btnSignout.Size = new System.Drawing.Size(220, 50);
            this.btnSignout.TabIndex = 5;
            this.btnSignout.Text = "Đăng Xuất";
            this.btnSignout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSignout.UseVisualStyleBackColor = true;
            this.btnSignout.Click += new System.EventHandler(this.btnSignout_Click);
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.Navy;
            this.pnlNav.Location = new System.Drawing.Point(0, 278);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(5, 60);
            this.pnlNav.TabIndex = 4;
            // 
            // btnTienDien
            // 
            this.btnTienDien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnTienDien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTienDien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTienDien.FlatAppearance.BorderSize = 0;
            this.btnTienDien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTienDien.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTienDien.ForeColor = System.Drawing.Color.Navy;
            this.btnTienDien.Image = global::TienDien.Properties.Resources.lightning_bolt_23px;
            this.btnTienDien.Location = new System.Drawing.Point(0, 301);
            this.btnTienDien.Name = "btnTienDien";
            this.btnTienDien.Size = new System.Drawing.Size(220, 60);
            this.btnTienDien.TabIndex = 3;
            this.btnTienDien.Text = "Thanh Toán\r\nvà Hóa Đơn";
            this.btnTienDien.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTienDien.UseVisualStyleBackColor = false;
            this.btnTienDien.Click += new System.EventHandler(this.btnTienDien_Click);
            this.btnTienDien.Leave += new System.EventHandler(this.btnTienDien_Leave);
            // 
            // btnUocTinh
            // 
            this.btnUocTinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnUocTinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUocTinh.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUocTinh.FlatAppearance.BorderSize = 0;
            this.btnUocTinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUocTinh.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUocTinh.ForeColor = System.Drawing.Color.Navy;
            this.btnUocTinh.Image = global::TienDien.Properties.Resources.estimate_23px;
            this.btnUocTinh.Location = new System.Drawing.Point(0, 241);
            this.btnUocTinh.Name = "btnUocTinh";
            this.btnUocTinh.Size = new System.Drawing.Size(220, 60);
            this.btnUocTinh.TabIndex = 2;
            this.btnUocTinh.Text = "Ước Tính \r\nĐiện Năng";
            this.btnUocTinh.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUocTinh.UseVisualStyleBackColor = false;
            this.btnUocTinh.Click += new System.EventHandler(this.btnUocTinh_Click);
            this.btnUocTinh.Leave += new System.EventHandler(this.btnUocTinh_Leave);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.Navy;
            this.btnDashboard.Image = global::TienDien.Properties.Resources.Home_23px;
            this.btnDashboard.Location = new System.Drawing.Point(0, 181);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDashboard.Size = new System.Drawing.Size(220, 60);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            this.btnDashboard.Leave += new System.EventHandler(this.btnDashboard_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel2.Controls.Add(this.btnHello);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 181);
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
            this.btnHello.Location = new System.Drawing.Point(0, 121);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(220, 60);
            this.btnHello.TabIndex = 6;
            this.btnHello.Text = "Welcome, User!";
            this.btnHello.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnHello.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::TienDien.Properties.Resources.test_account_100px;
            this.pictureBox1.Location = new System.Drawing.Point(60, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tinhTienDien1
            // 
            this.tinhTienDien1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tinhTienDien1.Location = new System.Drawing.Point(220, 0);
            this.tinhTienDien1.Margin = new System.Windows.Forms.Padding(4);
            this.tinhTienDien1.Name = "tinhTienDien1";
            this.tinhTienDien1.Size = new System.Drawing.Size(880, 700);
            this.tinhTienDien1.TabIndex = 16;
            this.tinhTienDien1.Load += new System.EventHandler(this.tinhTienDien1_Load);
            // 
            // dashboard1
            // 
            this.dashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboard1.Location = new System.Drawing.Point(220, 0);
            this.dashboard1.Margin = new System.Windows.Forms.Padding(4);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(880, 700);
            this.dashboard1.TabIndex = 15;
            // 
            // uocTinh1
            // 
            this.uocTinh1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uocTinh1.Location = new System.Drawing.Point(220, 0);
            this.uocTinh1.Margin = new System.Windows.Forms.Padding(4);
            this.uocTinh1.Name = "uocTinh1";
            this.uocTinh1.Size = new System.Drawing.Size(880, 700);
            this.uocTinh1.TabIndex = 14;
            // 
            // TienDienApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.tinhTienDien1);
            this.Controls.Add(this.dashboard1);
            this.Controls.Add(this.uocTinh1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TienDienApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TienDienApp";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Mouse_Move);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnTienDien;
        private System.Windows.Forms.Button btnUocTinh;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnSignout;
        private UocTinh uocTinh1;
        private Dashboard dashboard1;
        private TinhTienDien tinhTienDien1;
        private System.Windows.Forms.Button btnHello;
    }
}