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
            this.components = new System.ComponentModel.Container();
            this.lblTinhTienDien = new System.Windows.Forms.Label();
            this.btnXuatHoaDon = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.btnLoadHoaDon = new System.Windows.Forms.Button();
            this.lblChuthich = new System.Windows.Forms.Label();
            this.txtTentk = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblTentk = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
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
            this.btnXuatHoaDon.Click += new System.EventHandler(this.btnXuatHoaDon_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.Navy;
            this.btnThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThanhToan.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(252, 687);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(4);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(191, 37);
            this.btnThanhToan.TabIndex = 15;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Location = new System.Drawing.Point(53, 302);
            this.dgvHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.Size = new System.Drawing.Size(1067, 351);
            this.dgvHoaDon.TabIndex = 16;
            // 
            // btnLoadHoaDon
            // 
            this.btnLoadHoaDon.BackColor = System.Drawing.Color.Navy;
            this.btnLoadHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadHoaDon.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLoadHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadHoaDon.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnLoadHoaDon.Location = new System.Drawing.Point(692, 156);
            this.btnLoadHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadHoaDon.Name = "btnLoadHoaDon";
            this.btnLoadHoaDon.Size = new System.Drawing.Size(428, 36);
            this.btnLoadHoaDon.TabIndex = 17;
            this.btnLoadHoaDon.Text = "Tải thông tin hóa đơn";
            this.btnLoadHoaDon.UseVisualStyleBackColor = false;
            this.btnLoadHoaDon.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblChuthich
            // 
            this.lblChuthich.AutoSize = true;
            this.lblChuthich.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChuthich.Location = new System.Drawing.Point(643, 277);
            this.lblChuthich.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChuthich.Name = "lblChuthich";
            this.lblChuthich.Size = new System.Drawing.Size(455, 23);
            this.lblChuthich.TabIndex = 18;
            this.lblChuthich.Text = "Chú thích trạng thái: 1-Đã thanh toán  0-Chưa thanh toán";
            // 
            // txtTentk
            // 
            this.txtTentk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTentk.Location = new System.Drawing.Point(53, 156);
            this.txtTentk.Margin = new System.Windows.Forms.Padding(4);
            this.txtTentk.Name = "txtTentk";
            this.txtTentk.Size = new System.Drawing.Size(629, 34);
            this.txtTentk.TabIndex = 19;
            this.txtTentk.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTentk_KeyDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblTentk
            // 
            this.lblTentk.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTentk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTentk.Location = new System.Drawing.Point(48, 127);
            this.lblTentk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTentk.Name = "lblTentk";
            this.lblTentk.Size = new System.Drawing.Size(571, 28);
            this.lblTentk.TabIndex = 21;
            this.lblTentk.Text = "Nhập tên tài khoản cần xuất hóa đơn";
            this.lblTentk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TinhTienDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTentk);
            this.Controls.Add(this.txtTentk);
            this.Controls.Add(this.lblChuthich);
            this.Controls.Add(this.btnLoadHoaDon);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnXuatHoaDon);
            this.Controls.Add(this.lblTinhTienDien);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TinhTienDien";
            this.Size = new System.Drawing.Size(1173, 827);
            this.Load += new System.EventHandler(this.TinhTienDien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTinhTienDien;
        private System.Windows.Forms.Button btnXuatHoaDon;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private Button btnLoadHoaDon;
        private Label lblChuthich;
        private TextBox txtTentk;
        private ContextMenuStrip contextMenuStrip1;
        private Label lblTentk;
    }
}
