using System;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupQLHD = new System.Windows.Forms.GroupBox();
            this.lblTienDien = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lblSoDien = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtChiSoMoi = new System.Windows.Forms.TextBox();
            this.txtChiSoCu = new System.Windows.Forms.TextBox();
            this.cbbChonTK = new System.Windows.Forms.ComboBox();
            this.dateThangNam = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupQLHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupQLHD
            // 
            this.groupQLHD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupQLHD.Controls.Add(this.lblTienDien);
            this.groupQLHD.Controls.Add(this.btnLuu);
            this.groupQLHD.Controls.Add(this.lblSoDien);
            this.groupQLHD.Controls.Add(this.label4);
            this.groupQLHD.Controls.Add(this.label3);
            this.groupQLHD.Controls.Add(this.label2);
            this.groupQLHD.Controls.Add(this.txtChiSoMoi);
            this.groupQLHD.Controls.Add(this.txtChiSoCu);
            this.groupQLHD.Controls.Add(this.cbbChonTK);
            this.groupQLHD.Controls.Add(this.dateThangNam);
            this.groupQLHD.Controls.Add(this.label1);
            this.groupQLHD.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupQLHD.Location = new System.Drawing.Point(36, 36);
            this.groupQLHD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupQLHD.Name = "groupQLHD";
            this.groupQLHD.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupQLHD.Size = new System.Drawing.Size(1347, 310);
            this.groupQLHD.TabIndex = 51;
            this.groupQLHD.TabStop = false;
            this.groupQLHD.Text = "Quản Lý Hóa Đơn";
            // 
            // lblTienDien
            // 
            this.lblTienDien.AutoSize = true;
            this.lblTienDien.ForeColor = System.Drawing.Color.Brown;
            this.lblTienDien.Location = new System.Drawing.Point(56, 267);
            this.lblTienDien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTienDien.Name = "lblTienDien";
            this.lblTienDien.Size = new System.Drawing.Size(104, 28);
            this.lblTienDien.TabIndex = 10;
            this.lblTienDien.Text = "Tiền Điện:";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(557, 39);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 38);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lblSoDien
            // 
            this.lblSoDien.AutoSize = true;
            this.lblSoDien.ForeColor = System.Drawing.Color.Brown;
            this.lblSoDien.Location = new System.Drawing.Point(56, 239);
            this.lblSoDien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoDien.Name = "lblSoDien";
            this.lblSoDien.Size = new System.Drawing.Size(174, 28);
            this.lblSoDien.TabIndex = 8;
            this.lblSoDien.Text = "Số Điện Tiêu Thụ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 191);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Chi Số Mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Chỉ Số Cũ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Chọn Tháng/Năm Hóa Đơn";
            // 
            // txtChiSoMoi
            // 
            this.txtChiSoMoi.Location = new System.Drawing.Point(335, 187);
            this.txtChiSoMoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtChiSoMoi.Name = "txtChiSoMoi";
            this.txtChiSoMoi.Size = new System.Drawing.Size(188, 34);
            this.txtChiSoMoi.TabIndex = 4;
            this.txtChiSoMoi.TextChanged += new System.EventHandler(this.txtChiSoMoi_TextChanged);
            // 
            // txtChiSoCu
            // 
            this.txtChiSoCu.Location = new System.Drawing.Point(335, 138);
            this.txtChiSoCu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtChiSoCu.Name = "txtChiSoCu";
            this.txtChiSoCu.ReadOnly = true;
            this.txtChiSoCu.Size = new System.Drawing.Size(188, 34);
            this.txtChiSoCu.TabIndex = 3;
            // 
            // cbbChonTK
            // 
            this.cbbChonTK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChonTK.FormattingEnabled = true;
            this.cbbChonTK.Location = new System.Drawing.Point(229, 39);
            this.cbbChonTK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbChonTK.Name = "cbbChonTK";
            this.cbbChonTK.Size = new System.Drawing.Size(293, 36);
            this.cbbChonTK.TabIndex = 2;
            this.cbbChonTK.SelectedIndexChanged += new System.EventHandler(this.cbbChonTK_SelectedIndexChanged);
            // 
            // dateThangNam
            // 
            this.dateThangNam.CustomFormat = "MM/yyyy";
            this.dateThangNam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateThangNam.Location = new System.Drawing.Point(335, 85);
            this.dateThangNam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateThangNam.MinDate = new System.DateTime(2025, 6, 1, 0, 0, 0, 0);
            this.dateThangNam.Name = "dateThangNam";
            this.dateThangNam.ShowUpDown = true;
            this.dateThangNam.Size = new System.Drawing.Size(188, 34);
            this.dateThangNam.TabIndex = 1;
            this.dateThangNam.Value = new System.DateTime(2025, 7, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn Tài Khoản";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dataGridView1.Location = new System.Drawing.Point(36, 374);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.dataGridView1.Size = new System.Drawing.Size(1347, 361);
            this.dataGridView1.TabIndex = 50;
            this.dataGridView1.TabStop = false;
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSize = true;
            this.btnXoa.BackColor = System.Drawing.Color.Navy;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(36, 742);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(156, 36);
            this.btnXoa.TabIndex = 52;
            this.btnXoa.TabStop = false;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // UserCtrlQuanLyHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.groupQLHD);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserCtrlQuanLyHD";
            this.Size = new System.Drawing.Size(1419, 814);
            this.Load += new System.EventHandler(this.UserCtrlQuanLyHD_Load);
            this.groupQLHD.ResumeLayout(false);
            this.groupQLHD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupQLHD;
        private System.Windows.Forms.Label lblSoDien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtChiSoMoi;
        private System.Windows.Forms.TextBox txtChiSoCu;
        private System.Windows.Forms.ComboBox cbbChonTK;
        private System.Windows.Forms.DateTimePicker dateThangNam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label lblTienDien;
        private System.Windows.Forms.Button btnXoa;
    }
}
