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
    public partial class QuenMatKhau : Form
    {
        public QuenMatKhau()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();

        private void btnQuenMK_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            if (email.Trim() == "") { MessageBox.Show("Vui lòng nhập Email!"); }
            else
            {
                string query = "Select * from TaiKhoan where Email ='" + email + "'";
                if (modify.TaiKhoans(query).Count != 0)
                {
                    MessageBox.Show("Mật khẩu của bạn là: " + modify.TaiKhoans(query)[0].MatKhau);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Email chưa được đăng ký!!");
                }

            }
        }

        private void QuenMatKhau_Load(object sender, EventArgs e)
        {

        }
      
        private void textBoxEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnQuenMK.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
