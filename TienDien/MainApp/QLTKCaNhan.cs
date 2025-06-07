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

namespace TienDien.Admin
{
    public partial class QLTKCaNhan : Form
    {
        public QLTKCaNhan()
        {
            InitializeComponent();
            btnLuu.Click += btnThoat_Click;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            txtHoTen.ReadOnly = false;
            txtSDT.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtDiaChi.ReadOnly = false;
            btnCapNhat.Visible = false;
            btnLuu.Visible = true;
            btnThoat.Visible = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            txtHoTen.ReadOnly = true;
            txtSDT.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            btnCapNhat.Visible = true;
            btnLuu.Visible = false;
            btnThoat.Visible = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                Modify modify = new Modify();
                modify.UpdateThongTinCaNhan(
                    Season.CurrentUsername,
                    txtHoTen.Text,
                    txtEmail.Text,
                    txtSDT.Text,
                    txtDiaChi.Text
                );
                MessageBox.Show("Cập nhật thành công.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi cập nhật:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            Modify modify = new Modify();
            if (string.IsNullOrEmpty(txtOld.Text) || string.IsNullOrEmpty(txtNew.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin mật khẩu cũ và mới.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtNew.Text != txtValidateNew.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không đúng.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtOld.Text == txtNew.Text)
            {
                MessageBox.Show("Mật khẩu mới không được trùng với mật khẩu cũ.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtNew.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            modify.updateMatKhau(Season.CurrentUsername, txtOld.Text, txtNew.Text);
            txtValidateNew.Clear();
            txtNew.Clear();
            txtOld.Clear();
        }

        private void QLTKCaNhan_Load(object sender, EventArgs e)
        {
            try
            {
                Modify modify = new Modify();
                string userName = Season.CurrentUsername;
                if (string.IsNullOrEmpty(userName))
                {
                    MessageBox.Show("User is not logged in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                object emailObj = modify.GetFieldValue("Email", "TaiKhoan", "TenTaiKhoan", userName);
                object hotenObj = modify.GetFieldValue("HoTen", "TaiKhoan", "TenTaiKhoan", userName);
                object sdtObj = modify.GetFieldValue("SoDienThoai", "TaiKhoan", "TenTaiKhoan", userName);
                object diachiObj = modify.GetFieldValue("DiaChi", "TaiKhoan", "TenTaiKhoan", userName);

                txtTenTK.Text = userName;
                txtHoTen.Text = hotenObj != null ? hotenObj.ToString() : string.Empty;
                txtEmail.Text = emailObj != null ? emailObj.ToString() : string.Empty;
                txtSDT.Text = sdtObj != null ? sdtObj.ToString() : string.Empty;
                txtDiaChi.Text = diachiObj != null ? diachiObj.ToString() : string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading user data:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
