namespace QuanLyNhanSu.VIEW
{
    partial class frmThongTinTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongTinTaiKhoan));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTTTK = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhanQuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTTK)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTTTK);
            this.groupBox1.Location = new System.Drawing.Point(4, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(729, 279);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Tài Khoản ";
            // 
            // dgvTTTK
            // 
            this.dgvTTTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTTTK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TaiKhoan,
            this.MatKhau,
            this.NhanVien,
            this.PhanQuyen});
            this.dgvTTTK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTTTK.Location = new System.Drawing.Point(3, 21);
            this.dgvTTTK.Name = "dgvTTTK";
            this.dgvTTTK.Size = new System.Drawing.Size(723, 255);
            this.dgvTTTK.TabIndex = 0;
            this.dgvTTTK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTTTK_CellClick);
            this.dgvTTTK.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvTTTK_RowPrePaint);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThoat.Location = new System.Drawing.Point(625, 45);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(83, 51);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoa.Location = new System.Drawing.Point(519, 45);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(82, 51);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa ";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThem.Location = new System.Drawing.Point(413, 45);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(83, 51);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Đăng Ký ";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(99, 15);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(168, 25);
            this.txtTK.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tài Khoản : ";
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // TaiKhoan
            // 
            this.TaiKhoan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TaiKhoan.DataPropertyName = "TaiKhoan";
            this.TaiKhoan.HeaderText = "Tài Khoản";
            this.TaiKhoan.Name = "TaiKhoan";
            // 
            // MatKhau
            // 
            this.MatKhau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.HeaderText = "Mật Khẩu";
            this.MatKhau.Name = "MatKhau";
            // 
            // NhanVien
            // 
            this.NhanVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NhanVien.DataPropertyName = "HoTen";
            this.NhanVien.HeaderText = "Nhân Viên";
            this.NhanVien.Name = "NhanVien";
            // 
            // PhanQuyen
            // 
            this.PhanQuyen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PhanQuyen.DataPropertyName = "PhanQuyen";
            this.PhanQuyen.HeaderText = "Phân Quyền";
            this.PhanQuyen.Name = "PhanQuyen";
            // 
            // frmThongTinTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(735, 379);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmThongTinTaiKhoan";
            this.Text = "frmThongTinTaiKhoan";
            this.Load += new System.EventHandler(this.frmThongTinTaiKhoan_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTTK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTTTK;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhanQuyen;
    }
}