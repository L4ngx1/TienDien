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
            this.SuspendLayout();
            // 
            // lblTinhTienDien
            // 
            this.lblTinhTienDien.AutoSize = true;
            this.lblTinhTienDien.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTinhTienDien.Location = new System.Drawing.Point(3, 0);
            this.lblTinhTienDien.Name = "lblTinhTienDien";
            this.lblTinhTienDien.Size = new System.Drawing.Size(127, 25);
            this.lblTinhTienDien.TabIndex = 1;
            this.lblTinhTienDien.Text = "Tính Tiền Điện";
            // 
            // TinhTienDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTinhTienDien);
            this.Name = "TinhTienDien";
            this.Size = new System.Drawing.Size(780, 573);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTinhTienDien;
    }
}
