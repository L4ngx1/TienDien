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
        Modify modify = new Modify();
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string tentk=txtUsername.Text;
            string matkhau = txtPassword.Text;
            string email = txtEmail.Text;
            if (tentk.Trim() == "") { MessageBox.Show("Vui lòng nhập tên tài khoản!"); }
            else if (matkhau.Trim() == "") { MessageBox.Show("Vui lòng nhập mật khẩu!"); }
            else if (email.Trim() == "") { MessageBox.Show("Vui lòng nhập Email!"); }
            else if (modify.TaiKhoans("Select * from TaiKhoan where Email = '" + email + "'").Count() != 0)
            {

                MessageBox.Show("Email này đã được đăng ký!", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                try
                {
                    string query = "Insert into TaiKhoan values ('" + tentk + "','" + matkhau + "','" + email + "')";
                    modify.Command(query);
                    MessageBox.Show("Đăng ký thành công!");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Tên tài khoản này đã được đăng ký!");
                }
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
