using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TienDien
{
    public partial class AdminForm : Form
    {
        Modify modify = new Modify();
        public AdminForm()
        {
            InitializeComponent();
        }
        public object SoDienThang(int thang)
        {
            string query1 = $@"SELECT SUM(SoDien) FROM HoaDon WHERE ThangHoaDon = {thang}";
            object sodien = modify.CmdGet(query1);
            return sodien;
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = modify.all_ADMIN();
            this.chart1.Series["Số Điện"].Points.AddXY("1", SoDienThang(1));
            this.chart1.Series["Số Điện"].Points.AddXY("2", SoDienThang(2));
            this.chart1.Series["Số Điện"].Points.AddXY("3", SoDienThang(3));
            this.chart1.Series["Số Điện"].Points.AddXY("4", SoDienThang(4));
            this.chart1.Series["Số Điện"].Points.AddXY("5", SoDienThang(5));
            this.chart1.Series["Số Điện"].Points.AddXY("6", SoDienThang(6));
            this.chart1.Series["Số Điện"].Points.AddXY("7", SoDienThang(7));
            this.chart1.Series["Số Điện"].Points.AddXY("8", SoDienThang(8));
            this.chart1.Series["Số Điện"].Points.AddXY("9", SoDienThang(9));
            this.chart1.Series["Số Điện"].Points.AddXY("10", SoDienThang(10));
            this.chart1.Series["Số Điện"].Points.AddXY("11", SoDienThang(11));
            this.chart1.Series["Số Điện"].Points.AddXY("12", SoDienThang(12));

        }
        private void btnChuaThanhToan_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = modify.ChuaThanhToan_ADMIN();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = modify.all_ADMIN();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            int thanghoadon = (int)numThang.Value;
            try
            {
                string query1 = $@"SELECT TOP 1 tk.TenTaiKhoan FROM HoaDon hd INNER JOIN TaiKhoan tk ON hd.TenTaiKhoan = tk.TenTaiKhoan WHERE ThangHoaDon = {thanghoadon} ORDER BY SoDien DESC";
                object tentk = modify.CmdGet(query1);
                lblTentk.Text = $"Tên tài khoản: {tentk}";

                string query2 = $@"SELECT TOP 1 hd.MaHoaDon FROM HoaDon hd INNER JOIN TaiKhoan tk ON hd.TenTaiKhoan = tk.TenTaiKhoan WHERE ThangHoaDon = {thanghoadon} ORDER BY SoDien DESC";
                object mahoadon = modify.CmdGet(query2);
                lblMaHoaDon.Text = $"Mã hóa đơn: {mahoadon}";

                string query3 = $@"SELECT TOP 1 hd.SoDien FROM HoaDon hd INNER JOIN TaiKhoan tk ON hd.TenTaiKhoan = tk.TenTaiKhoan WHERE ThangHoaDon = {thanghoadon} ORDER BY SoDien DESC";
                object sodien = modify.CmdGet(query3);
                lblSoDien.Text = $"Số điện tiêu thụ: {sodien} kWh";

                string query4 = $@"SELECT TOP 1 tk.HoTen FROM HoaDon hd INNER JOIN TaiKhoan tk ON hd.TenTaiKhoan = tk.TenTaiKhoan WHERE ThangHoaDon = {thanghoadon} ORDER BY SoDien DESC";
                object hoten = modify.CmdGet(query4);
                lblHoTen.Text = $"Họ tên: {hoten}";

                string query = $@"SELECT SUM(SoDien) FROM HoaDon WHERE ThangHoaDon = {thanghoadon}";
                object TongSoDien = modify.CmdGet(query);
                lblTongSoDien.Text = $"Tổng số điện tiêu thụ trong tháng {thanghoadon}: {TongSoDien} kWh";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi! " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSignout_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
