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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblQuanLiTienDien = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.uocTinh1 = new TienDien.UocTinh();
            this.dashboard1 = new TienDien.Dashboard();
            this.tinhTienDien1 = new TienDien.TinhTienDien();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 834);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Mouse_Move);
            // 
            // btnSignout
            // 
            this.btnSignout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignout.FlatAppearance.BorderSize = 0;
            this.btnSignout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignout.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignout.ForeColor = System.Drawing.Color.Navy;
            this.btnSignout.Image = global::TienDien.Properties.Resources.shutdown_25px;
            this.btnSignout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSignout.Location = new System.Drawing.Point(0, 773);
            this.btnSignout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSignout.Name = "btnSignout";
            this.btnSignout.Size = new System.Drawing.Size(293, 62);
            this.btnSignout.TabIndex = 5;
            this.btnSignout.Text = "Đăng Xuất";
            this.btnSignout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSignout.UseVisualStyleBackColor = true;
            this.btnSignout.Click += new System.EventHandler(this.btnSignout_Click);
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.Navy;
            this.pnlNav.Location = new System.Drawing.Point(0, 342);
            this.pnlNav.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(7, 74);
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
            this.btnTienDien.Location = new System.Drawing.Point(0, 342);
            this.btnTienDien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTienDien.Name = "btnTienDien";
            this.btnTienDien.Size = new System.Drawing.Size(293, 74);
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
            this.btnUocTinh.Location = new System.Drawing.Point(0, 268);
            this.btnUocTinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUocTinh.Name = "btnUocTinh";
            this.btnUocTinh.Size = new System.Drawing.Size(293, 74);
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
            this.btnDashboard.Location = new System.Drawing.Point(0, 194);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDashboard.Size = new System.Drawing.Size(293, 74);
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
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 194);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TienDien.Properties.Resources.electricity_icon_original;
            this.pictureBox1.Location = new System.Drawing.Point(60, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 160);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1433, 4);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnClose.Size = new System.Drawing.Size(29, 27);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.lblQuanLiTienDien);
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1467, 34);
            this.panel3.TabIndex = 7;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Mouse_Move);
            // 
            // lblQuanLiTienDien
            // 
            this.lblQuanLiTienDien.AutoSize = true;
            this.lblQuanLiTienDien.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanLiTienDien.Image = global::TienDien.Properties.Resources.conflict_23px;
            this.lblQuanLiTienDien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblQuanLiTienDien.Location = new System.Drawing.Point(4, 6);
            this.lblQuanLiTienDien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuanLiTienDien.Name = "lblQuanLiTienDien";
            this.lblQuanLiTienDien.Size = new System.Drawing.Size(262, 23);
            this.lblQuanLiTienDien.TabIndex = 7;
            this.lblQuanLiTienDien.Text = "       Hệ Thống Quản Lí Tiền Điện";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(1047, 41);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(404, 30);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // uocTinh1
            // 
            this.uocTinh1.Location = new System.Drawing.Point(293, 36);
            this.uocTinh1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uocTinh1.Name = "uocTinh1";
            this.uocTinh1.Size = new System.Drawing.Size(1173, 827);
            this.uocTinh1.TabIndex = 14;
            // 
            // dashboard1
            // 
            this.dashboard1.Location = new System.Drawing.Point(293, 36);
            this.dashboard1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(1173, 827);
            this.dashboard1.TabIndex = 15;
            // 
            // tinhTienDien1
            // 
            this.tinhTienDien1.Location = new System.Drawing.Point(293, 36);
            this.tinhTienDien1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tinhTienDien1.Name = "tinhTienDien1";
            this.tinhTienDien1.Size = new System.Drawing.Size(1173, 827);
            this.tinhTienDien1.TabIndex = 16;
            this.tinhTienDien1.Load += new System.EventHandler(this.tinhTienDien1_Load);
            // 
            // TienDienApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1467, 862);
            this.Controls.Add(this.tinhTienDien1);
            this.Controls.Add(this.dashboard1);
            this.Controls.Add(this.uocTinh1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TienDienApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TienDienApp";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Mouse_Move);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblQuanLiTienDien;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnSignout;
        private UocTinh uocTinh1;
        private Dashboard dashboard1;
        private TinhTienDien tinhTienDien1;
    }
}