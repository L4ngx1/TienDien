﻿using System;
using System.Windows.Forms;

namespace TienDien
{
    public partial class QuenMatKhau : Form
    {
        public QuenMatKhau()
        {
            InitializeComponent();
        }

        private void btnQuenMK_Click(object sender, EventArgs e)
        {
            Modify modify = new Modify();
            string email = txtEmail.Text;
            if (email.Trim() == "") { MessageBox.Show("Vui lòng nhập Email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                string query = "Select * from TaiKhoan where Email ='" + email + "'";
                if (modify.TaiKhoans(query).Count != 0)
                {
                    MessageBox.Show("Mật khẩu của bạn là: " + modify.TaiKhoans(query)[0].MatKhau, "Restore", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Email chưa được đăng ký!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }





        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnQuenMK.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
