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
using TienDien.Login_Register;
using static System.Net.Mime.MediaTypeNames;

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

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dgvHoaDon.SelectedRows.Count > 0 ? dgvHoaDon.SelectedRows[0] : null;
                if (selectedRow == null)
                {
                    MessageBox.Show("Vui lòng chọn một hóa đơn để thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string maHoaDon = selectedRow.Cells["MaHoaDon"].Value?.ToString();
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
                cbbLoc.SelectedIndex = 0;
                if (!string.IsNullOrEmpty(Season.CurrentUsername))
                {
                    dgvHoaDon.DataSource = modify.getHoaDon(Season.CurrentUsername);
                }
                else
                {
                    dgvHoaDon.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi!!" + ex.Message, "Lỗi!!");
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            try
            {
                Modify modify = new Modify();
                var curentItem = cbbLoc.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(curentItem))
                {
                    MessageBox.Show("Vui lòng chọn loại lọc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataTable data = null;

                if (curentItem == "Tất cả")
                {
                    data = modify.getHoaDon(Season.CurrentUsername);
                }
                else if (curentItem == "Chưa thanh toán")
                {
                    string query = "SELECT * FROM HoaDon WHERE TenTaiKhoan = @TenTaiKhoan AND TrangThai = 0";
                    data = modify.GetDataTable(query, new SqlParameter("@TenTaiKhoan", Season.CurrentUsername));
                }
                else if (curentItem == "Đã thanh toán")
                {
                    string query = "SELECT * FROM HoaDon WHERE TenTaiKhoan = @TenTaiKhoan AND TrangThai = 1";
                    data = modify.GetDataTable(query, new SqlParameter("@TenTaiKhoan", Season.CurrentUsername));
                }
                if (data == null || data.Rows.Count == 0)
                {
                    dgvHoaDon.DataSource = null;
                }
                else
                {
                    dgvHoaDon.DataSource = data;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lọc hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
