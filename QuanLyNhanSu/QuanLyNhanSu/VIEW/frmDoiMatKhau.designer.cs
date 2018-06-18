namespace QuanLyNhanSu.VIEW
{
    partial class frmDoiMatKhau
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
            this.check = new System.Windows.Forms.CheckBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.txtNhapLaiMatKhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDoiPass = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatKhauCu = new System.Windows.Forms.TextBox();
            this.lbMatKhauCu = new System.Windows.Forms.Label();
            this.lbMatKhauMoi = new System.Windows.Forms.Label();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // check
            // 
            this.check.AutoSize = true;
            this.check.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check.Location = new System.Drawing.Point(317, 252);
            this.check.Margin = new System.Windows.Forms.Padding(4);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(98, 23);
            this.check.TabIndex = 20;
            this.check.Text = "Show Pass";
            this.check.UseVisualStyleBackColor = true;
            this.check.CheckedChanged += new System.EventHandler(this.check_CheckedChanged);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(300, 283);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(91, 42);
            this.btnHuy.TabIndex = 19;
            this.btnHuy.Text = "Hủy ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtNhapLaiMatKhau
            // 
            this.txtNhapLaiMatKhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapLaiMatKhau.Location = new System.Drawing.Point(186, 196);
            this.txtNhapLaiMatKhau.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtNhapLaiMatKhau.Name = "txtNhapLaiMatKhau";
            this.txtNhapLaiMatKhau.Size = new System.Drawing.Size(229, 26);
            this.txtNhapLaiMatKhau.TabIndex = 17;
            this.txtNhapLaiMatKhau.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 199);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nhập lại mật khẩu:";
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhauMoi.Location = new System.Drawing.Point(186, 131);
            this.txtMatKhauMoi.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.Size = new System.Drawing.Size(229, 26);
            this.txtMatKhauMoi.TabIndex = 15;
            this.txtMatKhauMoi.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mật Khẩu Mới:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(143, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "ĐỔI MẬT KHẨU ";
            // 
            // btnDoiPass
            // 
            this.btnDoiPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiPass.Location = new System.Drawing.Point(170, 283);
            this.btnDoiPass.Margin = new System.Windows.Forms.Padding(4);
            this.btnDoiPass.Name = "btnDoiPass";
            this.btnDoiPass.Size = new System.Drawing.Size(88, 42);
            this.btnDoiPass.TabIndex = 19;
            this.btnDoiPass.Text = "Lưu";
            this.btnDoiPass.UseVisualStyleBackColor = true;
            this.btnDoiPass.Click += new System.EventHandler(this.btnDoiPass_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mật Khẩu Cũ:";
            // 
            // txtMatKhauCu
            // 
            this.txtMatKhauCu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhauCu.Location = new System.Drawing.Point(186, 70);
            this.txtMatKhauCu.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtMatKhauCu.Name = "txtMatKhauCu";
            this.txtMatKhauCu.Size = new System.Drawing.Size(229, 26);
            this.txtMatKhauCu.TabIndex = 15;
            this.txtMatKhauCu.UseSystemPasswordChar = true;
            // 
            // lbMatKhauCu
            // 
            this.lbMatKhauCu.AutoSize = true;
            this.lbMatKhauCu.ForeColor = System.Drawing.Color.DarkRed;
            this.lbMatKhauCu.Location = new System.Drawing.Point(211, 103);
            this.lbMatKhauCu.Name = "lbMatKhauCu";
            this.lbMatKhauCu.Size = new System.Drawing.Size(0, 17);
            this.lbMatKhauCu.TabIndex = 21;
            // 
            // lbMatKhauMoi
            // 
            this.lbMatKhauMoi.AutoSize = true;
            this.lbMatKhauMoi.ForeColor = System.Drawing.Color.DarkRed;
            this.lbMatKhauMoi.Location = new System.Drawing.Point(211, 164);
            this.lbMatKhauMoi.Name = "lbMatKhauMoi";
            this.lbMatKhauMoi.Size = new System.Drawing.Size(0, 17);
            this.lbMatKhauMoi.TabIndex = 21;
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.ForeColor = System.Drawing.Color.DarkRed;
            this.lbMatKhau.Location = new System.Drawing.Point(211, 229);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(0, 17);
            this.lbMatKhau.TabIndex = 21;
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(454, 338);
            this.Controls.Add(this.lbMatKhau);
            this.Controls.Add(this.lbMatKhauMoi);
            this.Controls.Add(this.lbMatKhauCu);
            this.Controls.Add(this.check);
            this.Controls.Add(this.btnDoiPass);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.txtNhapLaiMatKhau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMatKhauCu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMatKhauMoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "frmDoiMatKhau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox check;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TextBox txtNhapLaiMatKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDoiPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatKhauCu;
        private System.Windows.Forms.Label lbMatKhauCu;
        private System.Windows.Forms.Label lbMatKhauMoi;
        private System.Windows.Forms.Label lbMatKhau;
    }
}