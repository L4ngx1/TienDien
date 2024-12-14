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
        public static string SelectedUsername { get; set; }
        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            SelectedUsername = txtTentk.Text;
            if (dataGridView1.SelectedRows.Count == 0 || dataGridView1.SelectedRows[0].Cells["TenTaiKhoan"].Value == null)
            {
                MessageBox.Show("Vui lòng chọn một dòng hợp lệ để xuất hóa đơn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dataGridView1.SelectedRows[0].Cells["TenTaiKhoan"].Value.ToString() == txtTentk.Text)
            {
                HoaDonForm form = new HoaDonForm();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tên tài khoản không khớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            Modify modify = new Modify();
            try
            {
                string query = "Update HoaDon Set ThanhTien =  SoDien * 1000  where TenTaiKhoan = '" + txtTentk.Text + "'";
                modify.Command(query);
                dataGridView1.DataSource = modify.getHoaDon(txtTentk.Text);
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
                Modify modify = new Modify();
                object checkTrangThai = modify.GetFieldValue("TrangThai", "HoaDon", "TenTaiKhoan", txtTentk.Text);
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
                string query = "UPDATE HoaDon SET TrangThai = 1 WHERE TenTaiKhoan = '" + txtTentk.Text + "'";
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
            Modify modify = new Modify();
            try
            {
                dataGridView1.DataSource = modify.getHoaDon(txtTentk.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi!!" + ex.Message, "Lỗi!!");
            }
        }

        private void txtTentk_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
