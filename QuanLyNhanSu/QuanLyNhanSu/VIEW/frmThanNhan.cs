using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyNhanSu.BUS;
using QuanLyNhanSu.ENTITY;

namespace QuanLyNhanSu.VIEW
{
    public partial class frmThanNhan : Form
    {

        ThanNhanBUS thanNhanBus = new ThanNhanBUS();
        ThanNhan thanNhan = new ThanNhan();

        NhanVienBUS nhanVienBus = new NhanVienBUS();

        private int clickBtn = 1;
        public frmThanNhan()
        {
            InitializeComponent();
        }

        private void frmThanNhan_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void HienThi()
        {
            dgvThanNhan.DataSource = thanNhanBus.GetData();
            ShowNhanVien();
            cbNhanVien.Text = "";
            cbGioiTinh.Text = "Nam";
            khoaBtn(false);
        }

        private void khoaBtn(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            cbNhanVien.Enabled = e;
            txtTenTN.Enabled = e;
            txtTuoi.Enabled = e;
            cbGioiTinh.Enabled = e;
            txtMQH.Enabled = e;
        }

        private void clearTxt()
        {
            txtTenTN.Text = "";
            cbNhanVien.Text = "";
            txtTuoi.Text = "";
            cbGioiTinh.Text = "";
            txtMQH.Text = "";
        }

        public void ShowNhanVien()
        {
            DataTable dt = new DataTable();
            dt = nhanVienBus.GetData();
            cbNhanVien.DataSource = dt;
            cbNhanVien.DisplayMember = "HoTen";
            cbNhanVien.ValueMember = "MaNV";
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                frmMain m = new frmMain();
                m.Show();
                this.Close();
            }
            else
                HienThi();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                HienThi();
                khoaBtn(false);
                clickBtn = 1;

            }
            else
                return;
        }

        private void dgvThanNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenTN.Text = Convert.ToString(dgvThanNhan.CurrentRow.Cells["TenTN"].Value);
            txtTuoi.Text = Convert.ToString(dgvThanNhan.CurrentRow.Cells["Tuoi"].Value);
            cbGioiTinh.Text = Convert.ToString(dgvThanNhan.CurrentRow.Cells["GioiTinh"].Value);
            cbNhanVien.Text = Convert.ToString(dgvThanNhan.CurrentRow.Cells["MaNV"].Value);
            txtMQH.Text = Convert.ToString(dgvThanNhan.CurrentRow.Cells["MoiQuanHe"].Value);
        }

        private void dgvThanNhan_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvThanNhan.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    thanNhanBus.DeleteData(txtTenTN.Text);
                    MessageBox.Show("Xóa thành công!");
                    clearTxt();
                    khoaBtn(false);
                    HienThi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            clickBtn = 0;          
            khoaBtn(true);          
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            clickBtn = 1;
            khoaBtn(true);
            txtTenTN.Enabled = false;
        }

       

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtTenTN.Text==""||txtMQH.Text==""||txtTuoi.Text==""||cbGioiTinh.Text==""||cbNhanVien.Text=="")
            {
                MessageBox.Show("Thiếu thông tin!");
            }
            else
            {
                thanNhan.TenTN = txtTenTN.Text;
                thanNhan.GioiTinh = cbGioiTinh.Text;
                thanNhan.Tuoi = Convert.ToInt32(txtTuoi.Text);
                thanNhan.MaNV = cbNhanVien.SelectedValue.ToString();
                thanNhan.MoiQuanHe = txtMQH.Text;
                if(clickBtn == 0)
                {
                    try
                    {
                        thanNhanBus.InsertData(thanNhan);
                        MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi" + ex.Message);
                    }
                    
                }
                else
                {
                    try
                    {
                        thanNhanBus.UpdateData(thanNhan);
                        MessageBox.Show("Sửa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi" + ex.Message);
                    }
                }
                HienThi();
                clearTxt();
                khoaBtn(false);
                clickBtn = 1;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cmbTimKiem.Text == "Theo Tên Thân Nhân")
            {
                dgvThanNhan.DataSource = thanNhanBus.TimKiem("SELECT TenTN, HoTen ,ThanNhan.GioiTinh,Tuoi,MoiQuanHe FROM dbo.ThanNhan,dbo.NhanVien WHERE NhanVien.MaNV = ThanNhan.MaNV AND TenTN LIKE '%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cmbTimKiem.Text == "Theo Tên Nhân Viên")
            {
                dgvThanNhan.DataSource = thanNhanBus.TimKiem("SELECT TenTN, HoTen ,ThanNhan.GioiTinh,Tuoi,MoiQuanHe FROM dbo.ThanNhan,dbo.NhanVien WHERE NhanVien.MaNV = ThanNhan.MaNV AND HoTen LIKE N'%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cmbTimKiem.Text == "Theo Tuổi")
            {
                dgvThanNhan.DataSource = thanNhanBus.TimKiem("SELECT TenTN, HoTen ,ThanNhan.GioiTinh,Tuoi,MoiQuanHe FROM dbo.ThanNhan,dbo.NhanVien WHERE NhanVien.MaNV = ThanNhan.MaNV AND Tuoi LIKE N'%" + txtTimKiem.Text.Trim() + "%'");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            cmbTimKiem.Text = "";
        }
    }
}
