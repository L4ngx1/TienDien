using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TienDien
{
    public partial class Register : Form
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
        public Register()
        {
            InitializeComponent();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            Modify modify = new Modify();
            string tentk = txtUsername.Text;
            string xacnhanMK = txtXacNhanMK.Text;
            string matkhau = txtPassword.Text;
            string email = txtEmail.Text;
            string hoten = txtHoTen.Text;
            string sdt = txtSoDienThoai.Text;
            string diachi = txtDiaChi.Text;
            if(tentk.Trim()=="" ||
               matkhau.Trim()==""||
               xacnhanMK.Trim()=="" ||
               email.Trim()=="" ||
               hoten.Trim()=="" ||
               sdt.Trim()=="" ||
               diachi.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (xacnhanMK != matkhau)
            {
                MessageBox.Show("Mật khẩu xác nhận không trùng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                modify.addAccount(tentk, matkhau, email, hoten, sdt, diachi);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtXacNhanMK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegister.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
