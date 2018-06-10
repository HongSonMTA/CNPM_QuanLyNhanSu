namespace QuanLyNhanSu.VIEW
{
    partial class frmChucVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChucVu));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTenChucVu = new System.Windows.Forms.TextBox();
            this.lbTenChucVu = new System.Windows.Forms.Label();
            this.txtMaChucVu = new System.Windows.Forms.TextBox();
            this.lbMaChucVu = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvChucVu = new System.Windows.Forms.DataGridView();
            this.STT1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCV1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucVu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnThoat);
            this.groupBox3.Controls.Add(this.btnHuy);
            this.groupBox3.Controls.Add(this.btnLuu);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.btnSua);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Controls.Add(this.txtTenChucVu);
            this.groupBox3.Controls.Add(this.lbTenChucVu);
            this.groupBox3.Controls.Add(this.txtMaChucVu);
            this.groupBox3.Controls.Add(this.lbMaChucVu);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(2, 48);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(784, 430);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin chức vụ";
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThoat.Location = new System.Drawing.Point(574, 112);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(67, 51);
            this.btnThoat.TabIndex = 31;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.Enabled = false;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHuy.Location = new System.Drawing.Point(478, 112);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 50);
            this.btnHuy.TabIndex = 30;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.Enabled = false;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLuu.Location = new System.Drawing.Point(389, 113);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(76, 50);
            this.btnLuu.TabIndex = 29;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoa.Location = new System.Drawing.Point(294, 113);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(72, 50);
            this.btnXoa.TabIndex = 28;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSua.Location = new System.Drawing.Point(200, 114);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(68, 50);
            this.btnSua.TabIndex = 27;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThem.Location = new System.Drawing.Point(105, 114);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(67, 50);
            this.btnThem.TabIndex = 26;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTenChucVu
            // 
            this.txtTenChucVu.Location = new System.Drawing.Point(460, 41);
            this.txtTenChucVu.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenChucVu.Name = "txtTenChucVu";
            this.txtTenChucVu.Size = new System.Drawing.Size(171, 25);
            this.txtTenChucVu.TabIndex = 24;
            // 
            // lbTenChucVu
            // 
            this.lbTenChucVu.AutoSize = true;
            this.lbTenChucVu.Location = new System.Drawing.Point(352, 49);
            this.lbTenChucVu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTenChucVu.Name = "lbTenChucVu";
            this.lbTenChucVu.Size = new System.Drawing.Size(89, 17);
            this.lbTenChucVu.TabIndex = 23;
            this.lbTenChucVu.Text = "Tên Chức Vụ";
            // 
            // txtMaChucVu
            // 
            this.txtMaChucVu.Location = new System.Drawing.Point(142, 41);
            this.txtMaChucVu.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaChucVu.Name = "txtMaChucVu";
            this.txtMaChucVu.Size = new System.Drawing.Size(179, 25);
            this.txtMaChucVu.TabIndex = 24;
            // 
            // lbMaChucVu
            // 
            this.lbMaChucVu.AutoSize = true;
            this.lbMaChucVu.Location = new System.Drawing.Point(8, 49);
            this.lbMaChucVu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaChucVu.Name = "lbMaChucVu";
            this.lbMaChucVu.Size = new System.Drawing.Size(86, 17);
            this.lbMaChucVu.TabIndex = 23;
            this.lbMaChucVu.Text = "Mã Chức Vụ";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.dgvChucVu);
            this.groupBox4.Location = new System.Drawing.Point(8, 197);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(776, 233);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách chức vụ";
            // 
            // dgvChucVu
            // 
            this.dgvChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChucVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT1,
            this.MaCV1,
            this.TenCV});
            this.dgvChucVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChucVu.Location = new System.Drawing.Point(4, 22);
            this.dgvChucVu.Margin = new System.Windows.Forms.Padding(4);
            this.dgvChucVu.Name = "dgvChucVu";
            this.dgvChucVu.Size = new System.Drawing.Size(768, 207);
            this.dgvChucVu.TabIndex = 0;
            this.dgvChucVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChucVu_CellClick);
            this.dgvChucVu.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvChucVu_RowPrePaint);
            // 
            // STT1
            // 
            this.STT1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.STT1.HeaderText = "STT";
            this.STT1.Name = "STT1";
            // 
            // MaCV1
            // 
            this.MaCV1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaCV1.DataPropertyName = "MaChucVu";
            this.MaCV1.HeaderText = "Mã Chức Vụ";
            this.MaCV1.Name = "MaCV1";
            // 
            // TenCV
            // 
            this.TenCV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenCV.DataPropertyName = "TenChucVu";
            this.TenCV.HeaderText = "Tên Chức Vụ";
            this.TenCV.Name = "TenCV";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label13.Location = new System.Drawing.Point(263, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(228, 31);
            this.label13.TabIndex = 22;
            this.label13.Text = "Quản Lý Chức Vụ";
            // 
            // frmChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(789, 481);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChucVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChucVu";
            this.Load += new System.EventHandler(this.frmChucVu_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTenChucVu;
        private System.Windows.Forms.Label lbTenChucVu;
        private System.Windows.Forms.TextBox txtMaChucVu;
        private System.Windows.Forms.Label lbMaChucVu;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCV1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCV;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
    }
}