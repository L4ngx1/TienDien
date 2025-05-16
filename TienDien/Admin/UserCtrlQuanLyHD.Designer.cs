namespace TienDien.Admin
{
    partial class UserCtrlQuanLyHD
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupThongTinKH = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupTaiKhoan = new System.Windows.Forms.GroupBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblMaHoaDon = new System.Windows.Forms.Label();
            this.lblSoDien = new System.Windows.Forms.Label();
            this.lblTentk = new System.Windows.Forms.Label();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.lblTongSoDien = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numThang = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnChuaThanhToan = new System.Windows.Forms.Button();
            this.lblChuthich = new System.Windows.Forms.Label();
            this.groupThongTinKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupTaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numThang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupThongTinKH
            // 
            this.groupThongTinKH.Controls.Add(this.chart1);
            this.groupThongTinKH.Controls.Add(this.groupTaiKhoan);
            this.groupThongTinKH.Controls.Add(this.btnThongKe);
            this.groupThongTinKH.Controls.Add(this.lblTongSoDien);
            this.groupThongTinKH.Controls.Add(this.label1);
            this.groupThongTinKH.Controls.Add(this.numThang);
            this.groupThongTinKH.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupThongTinKH.Location = new System.Drawing.Point(28, 28);
            this.groupThongTinKH.Name = "groupThongTinKH";
            this.groupThongTinKH.Size = new System.Drawing.Size(1010, 252);
            this.groupThongTinKH.TabIndex = 37;
            this.groupThongTinKH.TabStop = false;
            this.groupThongTinKH.Text = "Thống Kê Lượng Điện Tiêu Thụ";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(453, 28);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Số Điện";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(526, 210);
            this.chart1.TabIndex = 33;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // groupTaiKhoan
            // 
            this.groupTaiKhoan.Controls.Add(this.lblHoTen);
            this.groupTaiKhoan.Controls.Add(this.lblMaHoaDon);
            this.groupTaiKhoan.Controls.Add(this.lblSoDien);
            this.groupTaiKhoan.Controls.Add(this.lblTentk);
            this.groupTaiKhoan.Location = new System.Drawing.Point(35, 69);
            this.groupTaiKhoan.Name = "groupTaiKhoan";
            this.groupTaiKhoan.Size = new System.Drawing.Size(398, 130);
            this.groupTaiKhoan.TabIndex = 32;
            this.groupTaiKhoan.TabStop = false;
            this.groupTaiKhoan.Text = "Hóa Đơn có số điện tiêu thụ lớn nhất";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(14, 70);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(57, 20);
            this.lblHoTen.TabIndex = 39;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // lblMaHoaDon
            // 
            this.lblMaHoaDon.AutoSize = true;
            this.lblMaHoaDon.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHoaDon.Location = new System.Drawing.Point(14, 30);
            this.lblMaHoaDon.Name = "lblMaHoaDon";
            this.lblMaHoaDon.Size = new System.Drawing.Size(92, 20);
            this.lblMaHoaDon.TabIndex = 38;
            this.lblMaHoaDon.Text = "Mã hóa đơn:";
            // 
            // lblSoDien
            // 
            this.lblSoDien.AutoSize = true;
            this.lblSoDien.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoDien.Location = new System.Drawing.Point(14, 90);
            this.lblSoDien.Name = "lblSoDien";
            this.lblSoDien.Size = new System.Drawing.Size(116, 20);
            this.lblSoDien.TabIndex = 37;
            this.lblSoDien.Text = "Số điện tiêu thụ:";
            // 
            // lblTentk
            // 
            this.lblTentk.AutoSize = true;
            this.lblTentk.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTentk.Location = new System.Drawing.Point(14, 50);
            this.lblTentk.Name = "lblTentk";
            this.lblTentk.Size = new System.Drawing.Size(100, 20);
            this.lblTentk.TabIndex = 33;
            this.lblTentk.Text = "Tên tài khoản:";
            // 
            // btnThongKe
            // 
            this.btnThongKe.AutoSize = true;
            this.btnThongKe.BackColor = System.Drawing.Color.Navy;
            this.btnThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKe.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Location = new System.Drawing.Point(297, 38);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(113, 25);
            this.btnThongKe.TabIndex = 28;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // lblTongSoDien
            // 
            this.lblTongSoDien.AutoSize = true;
            this.lblTongSoDien.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongSoDien.ForeColor = System.Drawing.Color.Firebrick;
            this.lblTongSoDien.Location = new System.Drawing.Point(10, 211);
            this.lblTongSoDien.Name = "lblTongSoDien";
            this.lblTongSoDien.Size = new System.Drawing.Size(322, 25);
            this.lblTongSoDien.TabIndex = 2;
            this.lblTongSoDien.Text = "Tổng số điện tiêu thụ trong tháng 0:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn tháng cần thống kê:\r\n";
            // 
            // numThang
            // 
            this.numThang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numThang.Location = new System.Drawing.Point(223, 38);
            this.numThang.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numThang.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numThang.Name = "numThang";
            this.numThang.Size = new System.Drawing.Size(64, 25);
            this.numThang.TabIndex = 0;
            this.numThang.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(28, 303);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(1010, 293);
            this.dataGridView1.TabIndex = 36;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Navy;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(419, 602);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(152, 40);
            this.btnRefresh.TabIndex = 40;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnChuaThanhToan
            // 
            this.btnChuaThanhToan.BackColor = System.Drawing.Color.Navy;
            this.btnChuaThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChuaThanhToan.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnChuaThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChuaThanhToan.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuaThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnChuaThanhToan.Location = new System.Drawing.Point(28, 602);
            this.btnChuaThanhToan.Name = "btnChuaThanhToan";
            this.btnChuaThanhToan.Size = new System.Drawing.Size(385, 40);
            this.btnChuaThanhToan.TabIndex = 38;
            this.btnChuaThanhToan.Text = "Hiển thị thông tin tài khoản chưa thanh toán hóa đơn";
            this.btnChuaThanhToan.UseVisualStyleBackColor = false;
            this.btnChuaThanhToan.Click += new System.EventHandler(this.btnChuaThanhToan_Click);
            // 
            // lblChuthich
            // 
            this.lblChuthich.AutoSize = true;
            this.lblChuthich.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChuthich.Location = new System.Drawing.Point(680, 602);
            this.lblChuthich.Name = "lblChuthich";
            this.lblChuthich.Size = new System.Drawing.Size(358, 17);
            this.lblChuthich.TabIndex = 39;
            this.lblChuthich.Text = "Chú thích trạng thái: 1-Đã thanh toán  0-Chưa thanh toán";
            // 
            // UserCtrlQuanLyHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblChuthich);
            this.Controls.Add(this.btnChuaThanhToan);
            this.Controls.Add(this.groupThongTinKH);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserCtrlQuanLyHD";
            this.Size = new System.Drawing.Size(1064, 661);
            this.Load += new System.EventHandler(this.UserCtrlQuanLyHD_Load);
            this.groupThongTinKH.ResumeLayout(false);
            this.groupThongTinKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupTaiKhoan.ResumeLayout(false);
            this.groupTaiKhoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numThang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupThongTinKH;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown numThang;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnChuaThanhToan;
        private System.Windows.Forms.Label lblChuthich;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupTaiKhoan;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblMaHoaDon;
        private System.Windows.Forms.Label lblSoDien;
        private System.Windows.Forms.Label lblTentk;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Label lblTongSoDien;
        private System.Windows.Forms.Label label1;
    }
}
