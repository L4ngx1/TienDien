﻿using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace TienDien
{
    public partial class HoaDonForm : Form
    {
        public Point mouseLocation;
        private void Mouse_Down(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseLocation = new Point(e.X, e.Y);
            }
        }
        private void Mouse_Move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + (e.X - mouseLocation.X), this.Location.Y + (e.Y - mouseLocation.Y));
            }
        }
        public HoaDonForm()
        {
            InitializeComponent();
        }

        private void HoaDonForm_Load(object sender, EventArgs e)
        {
            string mahoadon = TinhTienDien.SelectedMahoadon;
            string tentk = TinhTienDien.SelectedUsername;
            Modify modify = new Modify();
            reportViewer1.LocalReport.ReportEmbeddedResource = "TienDien.MainApp.HoaDon.Report1.rdlc";
            ReportDataSource reportDataSource1 = new ReportDataSource();
            ReportDataSource reportDataSource2 = new ReportDataSource();
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = modify.HoaDon(mahoadon);
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = modify.HoaDon_TaiKhoan(tentk);
            reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.RefreshReport();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
