﻿namespace TienDien
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
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnTienDien = new System.Windows.Forms.Button();
            this.btnUocTinh = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblQuanLiTienDien = new System.Windows.Forms.Label();
            this.uocTinh1 = new TienDien.UocTinh();
            this.tinhTienDien1 = new TienDien.TinhTienDien();
            this.dashboard1 = new TienDien.Dashboard();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.btnTienDien);
            this.panel1.Controls.Add(this.btnUocTinh);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 577);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Mouse_Move);
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.Navy;
            this.pnlNav.Location = new System.Drawing.Point(0, 170);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(5, 60);
            this.pnlNav.TabIndex = 4;
            // 
            // btnTienDien
            // 
            this.btnTienDien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnTienDien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTienDien.FlatAppearance.BorderSize = 0;
            this.btnTienDien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTienDien.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTienDien.ForeColor = System.Drawing.Color.Navy;
            this.btnTienDien.Image = global::TienDien.Properties.Resources.lightning_bolt_23px;
            this.btnTienDien.Location = new System.Drawing.Point(0, 278);
            this.btnTienDien.Name = "btnTienDien";
            this.btnTienDien.Size = new System.Drawing.Size(220, 60);
            this.btnTienDien.TabIndex = 3;
            this.btnTienDien.Text = "Tiền Điện ";
            this.btnTienDien.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTienDien.UseVisualStyleBackColor = false;
            this.btnTienDien.Click += new System.EventHandler(this.btnTienDien_Click);
            this.btnTienDien.Leave += new System.EventHandler(this.btnTienDien_Leave);
            // 
            // btnUocTinh
            // 
            this.btnUocTinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnUocTinh.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUocTinh.FlatAppearance.BorderSize = 0;
            this.btnUocTinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUocTinh.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUocTinh.ForeColor = System.Drawing.Color.Navy;
            this.btnUocTinh.Image = global::TienDien.Properties.Resources.estimate_23px;
            this.btnUocTinh.Location = new System.Drawing.Point(0, 218);
            this.btnUocTinh.Name = "btnUocTinh";
            this.btnUocTinh.Size = new System.Drawing.Size(220, 60);
            this.btnUocTinh.TabIndex = 2;
            this.btnUocTinh.Text = "Ước Tính   ";
            this.btnUocTinh.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUocTinh.UseVisualStyleBackColor = false;
            this.btnUocTinh.Click += new System.EventHandler(this.btnUocTinh_Click);
            this.btnUocTinh.Leave += new System.EventHandler(this.btnUocTinh_Leave);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.Navy;
            this.btnDashboard.Image = global::TienDien.Properties.Resources.Home_23px;
            this.btnDashboard.Location = new System.Drawing.Point(0, 158);
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
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 158);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TienDien.Properties.Resources.electricity_icon_original;
            this.pictureBox1.Location = new System.Drawing.Point(45, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 130);
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
            this.btnClose.Location = new System.Drawing.Point(975, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnClose.Size = new System.Drawing.Size(22, 22);
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
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1000, 27);
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
            this.lblQuanLiTienDien.Location = new System.Drawing.Point(3, 5);
            this.lblQuanLiTienDien.Name = "lblQuanLiTienDien";
            this.lblQuanLiTienDien.Size = new System.Drawing.Size(206, 17);
            this.lblQuanLiTienDien.TabIndex = 7;
            this.lblQuanLiTienDien.Text = "       Hệ Thống Quản Lí Tiền Điện";
            // 
            // uocTinh1
            // 
            this.uocTinh1.Location = new System.Drawing.Point(220, 27);
            this.uocTinh1.Name = "uocTinh1";
            this.uocTinh1.Size = new System.Drawing.Size(780, 573);
            this.uocTinh1.TabIndex = 8;
            // 
            // tinhTienDien1
            // 
            this.tinhTienDien1.Location = new System.Drawing.Point(220, 27);
            this.tinhTienDien1.Name = "tinhTienDien1";
            this.tinhTienDien1.Size = new System.Drawing.Size(780, 573);
            this.tinhTienDien1.TabIndex = 9;
            // 
            // dashboard1
            // 
            this.dashboard1.Location = new System.Drawing.Point(220, 27);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(780, 573);
            this.dashboard1.TabIndex = 10;
            // 
            // TienDienApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.dashboard1);
            this.Controls.Add(this.tinhTienDien1);
            this.Controls.Add(this.uocTinh1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private UocTinh uocTinh1;
        private TinhTienDien tinhTienDien1;
        private Dashboard dashboard1;
    }
}