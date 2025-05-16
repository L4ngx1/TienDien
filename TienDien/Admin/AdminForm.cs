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
using Org.BouncyCastle.Asn1.BC;
using TienDien.Admin;

namespace TienDien
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btnSignout_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnQLHD_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnQLHD.Height;
            pnlNav.Top = btnQLHD.Top;
            userCtrlQuanLyHD1.Visible = true;
            userCtrlQuanLyTK1.Visible = false;
        }

        private void btnQLTK_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnQLTK.Height;
            pnlNav.Top = btnQLTK.Top;
            userCtrlQuanLyHD1.Visible = false;
            userCtrlQuanLyTK1.Visible = true;
        }
    }
}
