using System;
using System.Windows.Forms;

namespace TienDien.Admin
{
    public partial class UserCtrlQuanLyTK : UserControl
    {
        public UserCtrlQuanLyTK()
        {
            InitializeComponent();
        }

        private void UserCtrlQuanLyTK_Load(object sender, EventArgs e)
        {
            ReloadData();
        }
        private void ReloadData()
        {
            try
            {
                var modify = new Modify();
                dataGridView1.DataSource = modify.getTaiKhoan_ADMIN();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi!!" + ex.Message, "Lỗi!!");
            }
        }
        public void reset()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtEmail.Text = "";
            txtHoTen.Text = "";
            txtSoDienThoai.Text = "";
            txtDiaChi.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                var modify = new Modify();
                modify.addAccount(txtUsername.Text, txtPassword.Text, txtEmail.Text, txtHoTen.Text, txtSoDienThoai.Text, txtDiaChi.Text);
                ReloadData();
                reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index != -1)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows.Count > 0 ? dataGridView1.SelectedRows[0] : null;
                if (selectedRow == null)
                {
                    MessageBox.Show("Vui lòng chọn một dòng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string tentk = selectedRow.Cells["TenTaiKhoan"].Value.ToString();
                string mk = selectedRow.Cells["MatKhau"].Value.ToString();
                string email = selectedRow.Cells["Email"].Value.ToString();
                string hoten = selectedRow.Cells["HoTen"].Value.ToString();
                string sdt = selectedRow.Cells["SoDienThoai"].Value.ToString();
                string diachi = selectedRow.Cells["DiaChi"].Value.ToString();

                txtUsername.Text = tentk;
                txtPassword.Text = mk;
                txtEmail.Text = email;
                txtHoTen.Text = hoten;
                txtSoDienThoai.Text = sdt;
                txtDiaChi.Text = diachi;

                btnHandleSuaTK.Visible = true;
                btnThem.Visible = false;
                btnThoat.Visible = true;
            }
        }
        private void btnHandleSuaTK_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.SelectedRows.Count > 0 ? dataGridView1.SelectedRows[0] : null;
            if (selectedRow == null)
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string tentk = selectedRow.Cells["TenTaiKhoan"].Value.ToString();
            if (string.IsNullOrEmpty(tentk))
            {
                MessageBox.Show("Dòng được chọn không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var modify = new Modify();
                modify.editAccount(tentk, txtUsername.Text, txtPassword.Text, txtEmail.Text, txtHoTen.Text, txtSoDienThoai.Text, txtDiaChi.Text);
                ReloadData();
                btnThoat.Visible = false;
                btnHandleSuaTK.Visible = false;
                btnThem.Visible = true;
                reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.SelectedRows.Count > 0 ? dataGridView1.SelectedRows[0] : null;
            if (selectedRow == null)
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string tentk = selectedRow.Cells["TenTaiKhoan"].Value.ToString();
            if (string.IsNullOrEmpty(tentk))
            {
                MessageBox.Show("Dòng được chọn không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var modify = new Modify();
                modify.deleteAccount(tentk);

                ReloadData();
                reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            btnThoat.Visible = false;
            btnHandleSuaTK.Visible = false;
            btnThem.Visible = true;
            reset();
        }

    }
}