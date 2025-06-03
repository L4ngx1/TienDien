using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private string GetCellValue(DataGridViewRow row, string columnName, int fallbackIndex)
        {
            if (dataGridView1.Columns.Contains(columnName))
                return row.Cells[columnName].Value?.ToString() ?? "";
            return row.Cells.Count > fallbackIndex ? row.Cells[fallbackIndex].Value?.ToString() ?? "" : "";
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
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dataGridView1.SelectedRows[0];
            string tentk = GetCellValue(selectedRow, "TenTaiKhoan", 0);
            if (string.IsNullOrEmpty(tentk))
            {
                MessageBox.Show("Dòng được chọn không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtUsername.Text = tentk;
            txtPassword.Text = GetCellValue(selectedRow, "MatKhau", 1);
            txtEmail.Text = GetCellValue(selectedRow, "Email", 2);
            txtHoTen.Text = GetCellValue(selectedRow, "HoTen", 3);
            txtSoDienThoai.Text = GetCellValue(selectedRow, "SoDienThoai", 4);
            txtDiaChi.Text = GetCellValue(selectedRow, "DiaChi", 5);

            btnHandleSuaTK.Visible = true;
            btnThem.Visible = false;
            btnThoat.Visible = true;
        }
        private void btnHandleSuaTK_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tentk = GetCellValue(dataGridView1.SelectedRows[0], "TenTaiKhoan", 0);
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
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tentk = GetCellValue(dataGridView1.SelectedRows[0], "TenTaiKhoan", 0);
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
