using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace TienDien
{
    public partial class TinhTienDien : UserControl
    {
        public TinhTienDien()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();   

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        Modify Modify = new Modify();
        private void TinhTienDien_Load(object sender, EventArgs e)
        {
       
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = modify.getHoaDon(txtMaKH.Text);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi!!" + ex.Message, "Lỗi!!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
