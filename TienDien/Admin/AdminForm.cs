using System;
using System.Windows.Forms;

namespace TienDien
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            pnlNav.Height = btnQLTK.Height;
            pnlNav.Top = btnQLTK.Top;
            userCtrlQuanLyHD1.Visible = false;
            userCtrlThongKeHD1.Visible = false;
            userCtrlQuanLyTK1.Visible = true;
        }

        private void btnSignout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQLTK_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnQLTK.Height;
            pnlNav.Top = btnQLTK.Top;
            userCtrlQuanLyHD1.Visible = false;
            userCtrlThongKeHD1.Visible = false;
            userCtrlQuanLyTK1.Visible = true;
        }

        private void btnTKHD_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnTKHD.Height;
            pnlNav.Top = btnTKHD.Top;
            userCtrlQuanLyHD1.Visible = false;
            userCtrlThongKeHD1.Visible = true;
            userCtrlQuanLyTK1.Visible = false;
        }

        private void btnQLHD_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnQLHD.Height;
            pnlNav.Top = btnQLHD.Top;
            userCtrlQuanLyHD1.Visible = true;
            userCtrlThongKeHD1.Visible = false;
            userCtrlQuanLyTK1.Visible = false;
        }

        private void userCtrlQuanLyHD1_Load(object sender, EventArgs e)
        {

        }

        private void icon_click(object sender, EventArgs e)
        {

        }
    }
}
