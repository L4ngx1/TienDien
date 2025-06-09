using System;
using System.Windows.Forms;

namespace TienDien.Admin
{
    public partial class UserCtrlQuanLyHD : UserControl
    {
        public UserCtrlQuanLyHD()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                Modify modify = new Modify();
                string tentk = cbbChonTK.Text;
                int thang = dateThangNam.Value.Month;
                int nam = dateThangNam.Value.Year;
                var existed = Modify.CheckExistHD(tentk, thang, nam);
                if (existed)
                {
                    MessageBox.Show("Hóa đơn đã tồn tại cho kỳ này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int chiSoCu;
                int chiSoMoi;
                if (!int.TryParse(txtChiSoCu.Text, out chiSoCu) || !int.TryParse(txtChiSoMoi.Text, out chiSoMoi))
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng chỉ số!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (chiSoMoi < chiSoCu)
                {
                    MessageBox.Show("Chỉ số mới phải lớn hơn hoặc bằng chỉ số cũ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                double soDien = chiSoMoi - chiSoCu;
                DienBacThang dienBacThang = new DienBacThang();
                double tienDien = dienBacThang.dienBacThang(soDien);
                modify.addChiSoDien(tentk, thang, nam, chiSoCu, chiSoMoi);
                modify.AddHoaDon(tentk, soDien, thang, nam, tienDien);
                dataGridView1.DataSource = modify.GetHoaDon_QLHD();
                MessageBox.Show("Lưu hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtChiSoMoi.Clear();
                txtChiSoCu.Clear();
                cbbChonTK.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UNIQUE KEY constraint") && ex.Message.Contains("ChiSoDien"))
                {
                    MessageBox.Show("Chỉ số điện đã tồn tại cho kỳ này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void cbbChonTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbbChonTK.Text))
            {
                Modify modify = new Modify();
                var chiSoCu = modify.LayChiSoCuGanNhat(cbbChonTK.Text);
                // Nếu không có chỉ số cũ, gán giá trị mặc định là 0
                txtChiSoCu.Text = chiSoCu >= 0 ? chiSoCu.ToString() : "0";
            }
            else
            {
                txtChiSoCu.Text = "0";
            }
        }

        private void txtChiSoMoi_TextChanged(object sender, EventArgs e)
        {
            int chiSoCu, chiSoMoi;
            bool isChiSoCuValid = int.TryParse(txtChiSoCu.Text, out chiSoCu);
            bool isChiSoMoiValid = int.TryParse(txtChiSoMoi.Text, out chiSoMoi);
            double soDien = 0;
            double tienDien = 0;
            if (isChiSoCuValid && isChiSoMoiValid && chiSoMoi >= chiSoCu)
            {
                soDien = chiSoMoi - chiSoCu;
                DienBacThang dienBacThang = new DienBacThang();
                tienDien = dienBacThang.dienBacThang(soDien);
                lblSoDien.Text = $"Số điện tiêu thụ: {soDien} kWh";
                lblTienDien.Text = $"Tiền điện: {tienDien.ToString("N0")} VNĐ";
            }
            else
            {
                lblSoDien.Text = "Số điện tiêu thụ: 0 kWh";
                lblTienDien.Text = "Tiền điện: 0 VNĐ";
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dataGridView1.SelectedRows[0];
            int maHoaDon = Convert.ToInt32(selectedRow.Cells["MaHoaDon"].Value);
            string tentk = selectedRow.Cells["TenTaiKhoan"].Value.ToString();
            int thang = Convert.ToInt32(selectedRow.Cells["ThangHoaDon"].Value);
            int nam = Convert.ToInt32(selectedRow.Cells["NamHoaDon"].Value);

            var confirmResult = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa hóa đơn này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmResult != DialogResult.Yes)
            {
                return;
            }

            try
            {
                Modify modify = new Modify();
                modify.deleteHoaDon_ChiSoDien(maHoaDon, thang, nam, tentk);
                dataGridView1.DataSource = modify.GetHoaDon_QLHD();
                MessageBox.Show("Xóa hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UserCtrlQuanLyHD_Load(object sender, EventArgs e)
        {
            Modify modify = new Modify();
            dataGridView1.DataSource = modify.GetHoaDon_QLHD();
            if (cbbChonTK != null)
            {
                modify.LoadComboboxKhachHang(cbbChonTK);
            }
        }
    }
}
