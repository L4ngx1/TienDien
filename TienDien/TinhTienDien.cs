using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            HoaDonForm hdform = new HoaDonForm();
            hdform.ShowDialog();
        }
        public string gettenTK()
        {
            Login login = new Login();
            string tentk = Login.CurrentUsername;
            return tentk;
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            Modify modify = new Modify();
            try
            {
                string query = "Update HoaDon Set ThanhTien =  SoDien * 1000  where TenTaiKhoan = '" + gettenTK() + "'";
                modify.Command(query);
                dataGridView1.DataSource = modify.getHoaDon(gettenTK());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi!!" + ex.Message, "Lỗi!!");
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            Modify modify = new Modify();
            string query = "Update HoaDon Set TrangThai = 1 where TenTaiKhoan = '" + gettenTK() + "'";
            try
            {
                modify.Command(query);
                MessageBox.Show("Thanh toán thành công!!");
                TinhTienDien_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thanh toán!" + ex);
            }
        }

        private void TinhTienDien_Load(object sender, EventArgs e)
        {
            Modify modify = new Modify();
            try
            {
                dataGridView1.DataSource = modify.getHoaDon(gettenTK());

            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi!!" + ex.Message, "Lỗi!!");
            }
        }
    }
}
