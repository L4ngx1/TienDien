using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TienDien
{
    public partial class TinhTienDien : UserControl
    {
        public TinhTienDien()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        public static string SelectedMahoadon { get; set; }
        public static string SelectedUsername { get; set; }
        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvHoaDon.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn một dòng để xuất hóa đơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string tentk = dgvHoaDon.SelectedRows[0].Cells["TenTaiKhoan"].Value?.ToString();
                string maHoaDon = dgvHoaDon.SelectedRows[0].Cells["MaHoaDon"].Value?.ToString();
                if (string.IsNullOrEmpty(maHoaDon))
                {
                    MessageBox.Show("Dòng được chọn không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                SelectedMahoadon = maHoaDon;
                SelectedUsername = tentk;
                HoaDonForm hoaDonForm = new HoaDonForm();
                hoaDonForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTentk.Text.Trim() == "") { MessageBox.Show("Vui lòng nhập tên tài khoản!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                
                dgvHoaDon.DataSource = modify.getHoaDon(txtTentk.Text);
                if (dgvHoaDon.Rows.Count > 0)
                {
                    dgvHoaDon.CurrentCell = dgvHoaDon.Rows[0].Cells[0];
                    dgvHoaDon.Rows[0].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi!!" + ex.Message, "Lỗi!!");
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                string maHoaDon = dgvHoaDon.SelectedRows[0].Cells["MaHoaDon"].Value?.ToString();
                if (dgvHoaDon.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn một dòng để xuất hóa đơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(maHoaDon))
                {
                    MessageBox.Show("Dòng được chọn không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                object checkTrangThai = modify.GetFieldValue("TrangThai", "HoaDon", "MaHoaDon", maHoaDon);
                if (checkTrangThai == null || checkTrangThai.ToString() == "")
                {
                    MessageBox.Show("Không tìm thấy hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (checkTrangThai.ToString() == "1")
                {
                    MessageBox.Show("Hóa đơn đã được thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string query = "UPDATE HoaDon SET TrangThai = 1 WHERE MaHoaDon = '" + maHoaDon + "'";
                modify.Command(query);
                MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TinhTienDien_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thanh toán! " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TinhTienDien_Load(object sender, EventArgs e)
        {
            try
            {
                dgvHoaDon.DataSource = modify.getHoaDon(txtTentk.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi!!" + ex.Message, "Lỗi!!");
            }
        }

      

        private void txtTentk_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLoadHoaDon.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
