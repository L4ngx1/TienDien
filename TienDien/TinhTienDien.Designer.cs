using System.Windows.Forms;

namespace TienDien
{
    partial class TinhTienDien
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
            this.lblTinhTienDien = new System.Windows.Forms.Label();
            this.btnXuatHoaDon = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupThongTinKH = new System.Windows.Forms.GroupBox();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupThongTinKH.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTinhTienDien
            // 
            this.lblTinhTienDien.AutoSize = true;
            this.lblTinhTienDien.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTinhTienDien.Location = new System.Drawing.Point(4, 0);
            this.lblTinhTienDien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTinhTienDien.Name = "lblTinhTienDien";
            this.lblTinhTienDien.Size = new System.Drawing.Size(160, 32);
            this.lblTinhTienDien.TabIndex = 1;
            this.lblTinhTienDien.Text = "Tính Tiền Điện";
            // 
            // btnXuatHoaDon
            // 
            this.btnXuatHoaDon.BackColor = System.Drawing.Color.Navy;
            this.btnXuatHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuatHoaDon.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnXuatHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatHoaDon.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnXuatHoaDon.Location = new System.Drawing.Point(53, 687);
            this.btnXuatHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.btnXuatHoaDon.Name = "btnXuatHoaDon";
            this.btnXuatHoaDon.Size = new System.Drawing.Size(191, 37);
            this.btnXuatHoaDon.TabIndex = 14;
            this.btnXuatHoaDon.Text = "Xuất hóa đơn";
            this.btnXuatHoaDon.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(252, 687);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 37);
            this.button1.TabIndex = 15;
            this.button1.Text = "Thanh toán";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TongTien});
            this.dataGridView1.Location = new System.Drawing.Point(53, 329);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1067, 323);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupThongTinKH
            // 
            this.groupThongTinKH.Controls.Add(this.lblMaKH);
            this.groupThongTinKH.Controls.Add(this.txtMaKH);
            this.groupThongTinKH.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupThongTinKH.Location = new System.Drawing.Point(53, 58);
            this.groupThongTinKH.Margin = new System.Windows.Forms.Padding(4);
            this.groupThongTinKH.Name = "groupThongTinKH";
            this.groupThongTinKH.Padding = new System.Windows.Forms.Padding(4);
            this.groupThongTinKH.Size = new System.Drawing.Size(733, 263);
            this.groupThongTinKH.TabIndex = 18;
            this.groupThongTinKH.TabStop = false;
            this.groupThongTinKH.Text = "Thông Tin Khách Hàng";
            // 
            // lblMaKH
            // 
            this.lblMaKH.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKH.Location = new System.Drawing.Point(13, 49);
            this.lblMaKH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(145, 28);
            this.lblMaKH.TabIndex = 1;
            this.lblMaKH.Text = "TenTK";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.Location = new System.Drawing.Point(167, 49);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(532, 27);
            this.txtMaKH.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Navy;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(813, 153);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 37);
            this.button2.TabIndex = 19;
            this.button2.Text = "Tải thông tin hóa đơn";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // TongTien
            // 
            this.TongTien.HeaderText = "TongTien";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            this.TongTien.Width = 125;
            // 
            // TinhTienDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupThongTinKH);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnXuatHoaDon);
            this.Controls.Add(this.lblTinhTienDien);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TinhTienDien";
            this.Size = new System.Drawing.Size(1173, 827);
            this.Load += new System.EventHandler(this.TinhTienDien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupThongTinKH.ResumeLayout(false);
            this.groupThongTinKH.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTinhTienDien;
        private System.Windows.Forms.Button btnXuatHoaDon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupThongTinKH;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private Button button2;
        private DataGridViewTextBoxColumn TongTien;
    }
}
