using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TienDien.Login_Register;

namespace TienDien
{
    public partial class LoginForm : Form
    {
        //Di chuyen Form khong can border
        public Point mouseLocation;
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
        public LoginForm()
        {
            InitializeComponent();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            registerForm.ShowDialog();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Modify modify = new Modify();
            string tentk = txtUsername.Text;
            string matkhau = txtPassword.Text;
            if (tentk == "admin" && matkhau == "admin")
            {
                Season.CurrentUsername = tentk;
                AdminForm form = new AdminForm();
                form.ShowDialog();
                txtPassword.Text = "";
                txtUsername.Text = "";
            }
            else if (matkhau.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string query = "Select * from TaiKhoan where TenTaiKhoan = '" + tentk + "' and MatKhau = '" + matkhau + "'";
                if (modify.TaiKhoans(query).Count != 0)
                {
                    Season.CurrentUsername = tentk;
                    TienDienApp appForm = new TienDienApp();
                    appForm.ShowDialog();
                    txtPassword.Text = "";
                    txtUsername.Text = "";
                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMatKhau quenMatKhau = new QuenMatKhau();   
            quenMatKhau.ShowDialog();
        }
        bool isPasswordShown = false;

        private void picEye_Click(object sender, EventArgs e)
        {
            isPasswordShown = !isPasswordShown;
            txtPassword.UseSystemPasswordChar = !isPasswordShown;
            picEye.Image = isPasswordShown ? Properties.Resources.eye_20px : Properties.Resources.invisible_20px;
            monkeyIcon.Image = isPasswordShown ? Properties.Resources.see_no_evil_monkey_130px : Properties.Resources.hear_no_evil_monkey_130px;
        }
    }
}
