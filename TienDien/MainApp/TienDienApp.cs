﻿using System;
using System.Drawing;
using System.Windows.Forms;
using TienDien.Admin;
using TienDien.Login_Register;

namespace TienDien
{
    public partial class TienDienApp : Form
    {
        public Point mouseLocation;
        public TienDienApp()
        {
            InitializeComponent();
            pnlNav.Height = btnTienDien.Height;
            pnlNav.Top = btnTienDien.Top;
            pnlNav.Left = btnTienDien.Left;
            btnTienDien.BackColor = Color.FromArgb(50, 153, 222);
            dashboard1.Visible = false;
            uocTinh1.Visible = false;
            tinhTienDien1.Visible = true;
        }
        private void Mouse_Down(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseLocation = new Point(e.X, e.Y);
            }
        }
        private void Mouse_Move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + (e.X - mouseLocation.X), this.Location.Y + (e.Y - mouseLocation.Y));
            }
        }
        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(42, 128, 185);
        }
        private void btnTienDien_Leave(object sender, EventArgs e)
        {
            btnTienDien.BackColor = Color.FromArgb(42, 128, 185);
        }
        private void btnUocTinh_Leave(object sender, EventArgs e)
        {
            btnUocTinh.BackColor = Color.FromArgb(42, 128, 185);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(50, 153, 222);
            dashboard1.Visible = true;
            uocTinh1.Visible = false;
            tinhTienDien1.Visible = false;

        }
        private void btnTienDien_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnTienDien.Height;
            pnlNav.Top = btnTienDien.Top;
            btnTienDien.BackColor = Color.FromArgb(50, 153, 222);
            dashboard1.Visible = false;
            uocTinh1.Visible = false;
            tinhTienDien1.Visible = true;
        }
        private void btnUocTinh_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnUocTinh.Height;
            pnlNav.Top = btnUocTinh.Top;
            btnUocTinh.BackColor = Color.FromArgb(50, 153, 222);
            dashboard1.Visible = false;
            uocTinh1.Visible = true;
            tinhTienDien1.Visible = false;
        }
        private void btnSignout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tinhTienDien1_Load(object sender, EventArgs e)
        {
            btnHello.Text = "Welcome, " + Season.CurrentUsername.ToUpper() + "!";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            QLTKCaNhan appForm = new QLTKCaNhan();
            appForm.ShowDialog();
        }
    }
}
