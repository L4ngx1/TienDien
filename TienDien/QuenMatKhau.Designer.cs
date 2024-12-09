namespace TienDien
{
    partial class QuenMatKhau
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblQuenMK = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.btnQuenMK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuenMK
            // 
            this.lblQuenMK.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuenMK.ForeColor = System.Drawing.Color.Navy;
            this.lblQuenMK.Location = new System.Drawing.Point(4, 31);
            this.lblQuenMK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuenMK.Name = "lblQuenMK";
            this.lblQuenMK.Size = new System.Drawing.Size(773, 49);
            this.lblQuenMK.TabIndex = 13;
            this.lblQuenMK.Text = " Nhập Email đăng ký để lấy lại mật khẩu";
            this.lblQuenMK.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(115, 106);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(553, 47);
            this.textBoxEmail.TabIndex = 14;
            this.textBoxEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxEmail_KeyDown);
            // 
            // btnQuenMK
            // 
            this.btnQuenMK.BackColor = System.Drawing.Color.Navy;
            this.btnQuenMK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuenMK.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnQuenMK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuenMK.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuenMK.ForeColor = System.Drawing.Color.White;
            this.btnQuenMK.Location = new System.Drawing.Point(241, 202);
            this.btnQuenMK.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuenMK.Name = "btnQuenMK";
            this.btnQuenMK.Size = new System.Drawing.Size(267, 37);
            this.btnQuenMK.TabIndex = 15;
            this.btnQuenMK.Text = "Lấy lại mật khẩu";
            this.btnQuenMK.UseVisualStyleBackColor = false;
            this.btnQuenMK.Click += new System.EventHandler(this.btnQuenMK_Click);
            // 
            // QuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQuenMK);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.lblQuenMK);
            this.Name = "QuenMatKhau";
            this.Text = "QuenMatKhau";
            this.Load += new System.EventHandler(this.QuenMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuenMK;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button btnQuenMK;
    }
}