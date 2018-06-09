namespace QuanLyNhanSu.VIEW
{
    partial class frmTGCT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTGCT));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbNhanVien = new System.Windows.Forms.ComboBox();
            this.cmbChucVu = new System.Windows.Forms.ComboBox();
            this.dpNgayNhanChuc = new System.Windows.Forms.DateTimePicker();
            this.lbNgayNhanChuc = new System.Windows.Forms.Label();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.lbMaCV = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvTGCT = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhanChuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoatTime = new System.Windows.Forms.Button();
            this.btnHuyTime = new System.Windows.Forms.Button();
            this.btnLuuTime = new System.Windows.Forms.Button();
            this.btnXoaTime = new System.Windows.Forms.Button();
            this.btnThemTime = new System.Windows.Forms.Button();
            this.btnSuaTime = new System.Windows.Forms.Button();
            this.cmbTimKiem = new System.Windows.Forms.ComboBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTGCT)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cmbNhanVien);
            this.groupBox1.Controls.Add(this.cmbChucVu);
            this.groupBox1.Controls.Add(this.dpNgayNhanChuc);
            this.groupBox1.Controls.Add(this.lbNgayNhanChuc);
            this.groupBox1.Controls.Add(this.lbMaNV);
            this.groupBox1.Controls.Add(this.lbMaCV);
            this.groupBox1.Location = new System.Drawing.Point(13, 45);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(685, 105);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thời gian công tác";
            // 
            // cmbNhanVien
            // 
            this.cmbNhanVien.FormattingEnabled = true;
            this.cmbNhanVien.Location = new System.Drawing.Point(139, 26);
            this.cmbNhanVien.Name = "cmbNhanVien";
            this.cmbNhanVien.Size = new System.Drawing.Size(195, 25);
            this.cmbNhanVien.TabIndex = 21;
            // 
            // cmbChucVu
            // 
            this.cmbChucVu.FormattingEnabled = true;
            this.cmbChucVu.Location = new System.Drawing.Point(442, 26);
            this.cmbChucVu.Name = "cmbChucVu";
            this.cmbChucVu.Size = new System.Drawing.Size(186, 25);
            this.cmbChucVu.TabIndex = 21;
            // 
            // dpNgayNhanChuc
            // 
            this.dpNgayNhanChuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpNgayNhanChuc.Location = new System.Drawing.Point(139, 73);
            this.dpNgayNhanChuc.Margin = new System.Windows.Forms.Padding(4);
            this.dpNgayNhanChuc.Name = "dpNgayNhanChuc";
            this.dpNgayNhanChuc.Size = new System.Drawing.Size(195, 25);
            this.dpNgayNhanChuc.TabIndex = 20;
            // 
            // lbNgayNhanChuc
            // 
            this.lbNgayNhanChuc.AutoSize = true;
            this.lbNgayNhanChuc.Location = new System.Drawing.Point(12, 82);
            this.lbNgayNhanChuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNgayNhanChuc.Name = "lbNgayNhanChuc";
            this.lbNgayNhanChuc.Size = new System.Drawing.Size(112, 17);
            this.lbNgayNhanChuc.TabIndex = 18;
            this.lbNgayNhanChuc.Text = "Ngày Nhận Chức";
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Location = new System.Drawing.Point(12, 34);
            this.lbMaNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(95, 17);
            this.lbMaNV.TabIndex = 18;
            this.lbMaNV.Text = "Mã Nhân Viên";
            // 
            // lbMaCV
            // 
            this.lbMaCV.AutoSize = true;
            this.lbMaCV.Location = new System.Drawing.Point(360, 29);
            this.lbMaCV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaCV.Name = "lbMaCV";
            this.lbMaCV.Size = new System.Drawing.Size(66, 17);
            this.lbMaCV.TabIndex = 18;
            this.lbMaCV.Text = " Chức Vụ";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvTGCT);
            this.groupBox2.Location = new System.Drawing.Point(0, 264);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(698, 279);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách thời gian công tác";
            // 
            // dgvTGCT
            // 
            this.dgvTGCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTGCT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaNV,
            this.HoTen,
            this.TenChucVu,
            this.NgayNhanChuc});
            this.dgvTGCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTGCT.Location = new System.Drawing.Point(4, 22);
            this.dgvTGCT.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTGCT.Name = "dgvTGCT";
            this.dgvTGCT.Size = new System.Drawing.Size(690, 253);
            this.dgvTGCT.TabIndex = 0;
            this.dgvTGCT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTGCT_CellClick);
            this.dgvTGCT.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvTGCT_RowPrePaint);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // MaNV
            // 
            this.MaNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã Nhân Viên";
            this.MaNV.Name = "MaNV";
            // 
            // HoTen
            // 
            this.HoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Tên Nhân Viên";
            this.HoTen.Name = "HoTen";
            // 
            // TenChucVu
            // 
            this.TenChucVu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenChucVu.DataPropertyName = "TenChucVu";
            this.TenChucVu.HeaderText = "Tên Chức Vụ";
            this.TenChucVu.Name = "TenChucVu";
            // 
            // NgayNhanChuc
            // 
            this.NgayNhanChuc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayNhanChuc.DataPropertyName = "NgayNhanChuc";
            this.NgayNhanChuc.HeaderText = "Ngày Nhận Chức";
            this.NgayNhanChuc.Name = "NgayNhanChuc";
            // 
            // btnThoatTime
            // 
            this.btnThoatTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoatTime.Image = ((System.Drawing.Image)(resources.GetObject("btnThoatTime.Image")));
            this.btnThoatTime.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThoatTime.Location = new System.Drawing.Point(548, 218);
            this.btnThoatTime.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoatTime.Name = "btnThoatTime";
            this.btnThoatTime.Size = new System.Drawing.Size(66, 47);
            this.btnThoatTime.TabIndex = 34;
            this.btnThoatTime.Text = "Thoát";
            this.btnThoatTime.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThoatTime.UseVisualStyleBackColor = true;
            this.btnThoatTime.Click += new System.EventHandler(this.btnThoatTime_Click);
            // 
            // btnHuyTime
            // 
            this.btnHuyTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuyTime.Enabled = false;
            this.btnHuyTime.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyTime.Image")));
            this.btnHuyTime.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHuyTime.Location = new System.Drawing.Point(455, 217);
            this.btnHuyTime.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuyTime.Name = "btnHuyTime";
            this.btnHuyTime.Size = new System.Drawing.Size(69, 48);
            this.btnHuyTime.TabIndex = 39;
            this.btnHuyTime.Text = "Hủy";
            this.btnHuyTime.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHuyTime.UseVisualStyleBackColor = true;
            this.btnHuyTime.Click += new System.EventHandler(this.btnHuyTime_Click);
            // 
            // btnLuuTime
            // 
            this.btnLuuTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuuTime.Enabled = false;
            this.btnLuuTime.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuTime.Image")));
            this.btnLuuTime.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLuuTime.Location = new System.Drawing.Point(354, 216);
            this.btnLuuTime.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuuTime.Name = "btnLuuTime";
            this.btnLuuTime.Size = new System.Drawing.Size(67, 48);
            this.btnLuuTime.TabIndex = 38;
            this.btnLuuTime.Text = "Lưu";
            this.btnLuuTime.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLuuTime.UseVisualStyleBackColor = true;
            this.btnLuuTime.Click += new System.EventHandler(this.btnLuuTime_Click);
            // 
            // btnXoaTime
            // 
            this.btnXoaTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaTime.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaTime.Image")));
            this.btnXoaTime.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoaTime.Location = new System.Drawing.Point(254, 216);
            this.btnXoaTime.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaTime.Name = "btnXoaTime";
            this.btnXoaTime.Size = new System.Drawing.Size(69, 49);
            this.btnXoaTime.TabIndex = 37;
            this.btnXoaTime.Text = "Xóa";
            this.btnXoaTime.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoaTime.UseVisualStyleBackColor = true;
            this.btnXoaTime.Click += new System.EventHandler(this.btnXoaTime_Click);
            // 
            // btnThemTime
            // 
            this.btnThemTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemTime.Image = ((System.Drawing.Image)(resources.GetObject("btnThemTime.Image")));
            this.btnThemTime.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThemTime.Location = new System.Drawing.Point(68, 216);
            this.btnThemTime.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemTime.Name = "btnThemTime";
            this.btnThemTime.Size = new System.Drawing.Size(69, 48);
            this.btnThemTime.TabIndex = 35;
            this.btnThemTime.Text = "Thêm";
            this.btnThemTime.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThemTime.UseVisualStyleBackColor = true;
            this.btnThemTime.Click += new System.EventHandler(this.btnThemTime_Click);
            // 
            // btnSuaTime
            // 
            this.btnSuaTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuaTime.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaTime.Image")));
            this.btnSuaTime.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSuaTime.Location = new System.Drawing.Point(164, 217);
            this.btnSuaTime.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuaTime.Name = "btnSuaTime";
            this.btnSuaTime.Size = new System.Drawing.Size(63, 48);
            this.btnSuaTime.TabIndex = 36;
            this.btnSuaTime.Text = "Sửa";
            this.btnSuaTime.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSuaTime.UseVisualStyleBackColor = true;
            this.btnSuaTime.Click += new System.EventHandler(this.btnSuaTime_Click);
            // 
            // cmbTimKiem
            // 
            this.cmbTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbTimKiem.FormattingEnabled = true;
            this.cmbTimKiem.Items.AddRange(new object[] {
            "Theo Mã NV",
            "Theo Tên NV",
            "Theo Chức Vụ",
            "Theo Ngày Nhận Chức"});
            this.cmbTimKiem.Location = new System.Drawing.Point(385, 168);
            this.cmbTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTimKiem.Name = "cmbTimKiem";
            this.cmbTimKiem.Size = new System.Drawing.Size(139, 25);
            this.cmbTimKiem.TabIndex = 43;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTimKiem.Location = new System.Drawing.Point(184, 168);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(184, 25);
            this.txtTimKiem.TabIndex = 42;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.Image")));
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.Location = new System.Drawing.Point(528, 165);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 32);
            this.btnLamMoi.TabIndex = 40;
            this.btnLamMoi.Text = "Làm Mới ";
            this.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(83, 165);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(97, 32);
            this.btnTimKiem.TabIndex = 41;
            this.btnTimKiem.Text = "Tìm Kiếm: ";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label13.Location = new System.Drawing.Point(159, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(365, 31);
            this.label13.TabIndex = 44;
            this.label13.Text = "Quản Lý Thời Gian Công Tác";
            // 
            // frmTGCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(700, 542);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmbTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnThoatTime);
            this.Controls.Add(this.btnHuyTime);
            this.Controls.Add(this.btnLuuTime);
            this.Controls.Add(this.btnXoaTime);
            this.Controls.Add(this.btnThemTime);
            this.Controls.Add(this.btnSuaTime);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmTGCT";
            this.Text = "frmTGCT";
            this.Load += new System.EventHandler(this.frmTGCT_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTGCT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbChucVu;
        private System.Windows.Forms.DateTimePicker dpNgayNhanChuc;
        private System.Windows.Forms.Label lbNgayNhanChuc;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.Label lbMaCV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvTGCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhanChuc;
        private System.Windows.Forms.Button btnThoatTime;
        private System.Windows.Forms.Button btnHuyTime;
        private System.Windows.Forms.Button btnLuuTime;
        private System.Windows.Forms.Button btnXoaTime;
        private System.Windows.Forms.Button btnThemTime;
        private System.Windows.Forms.Button btnSuaTime;
        private System.Windows.Forms.ComboBox cmbTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbNhanVien;
    }
}