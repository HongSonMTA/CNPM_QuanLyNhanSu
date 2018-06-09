using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanSu.BUS;
using QuanLyNhanSu.ENTITY;

namespace QuanLyNhanSu.VIEW
{
    public partial class frmTGCT : Form
    {
        ThoiGianCongTacEntity obj = new ThoiGianCongTacEntity();
        ThoiGianCongTacBUS bus = new ThoiGianCongTacBUS();
        private int fluu = 1;
        public frmTGCT()
        {
            InitializeComponent();
        }
        private void DisEnl(bool e)
        {
            btnThemTime.Enabled = !e;
            btnSuaTime.Enabled = !e;
            btnXoaTime.Enabled = !e;
            btnHuyTime.Enabled = e;
            btnLuuTime.Enabled = e;
            cmbNhanVien.Enabled = e;
            cmbChucVu.Enabled = e;
        }
        private void clearData()
        {
            cmbNhanVien.Text = "";
            cmbChucVu.Text = "";
        }
        public void ShowChucVu()
        {
            DataTable dt = new DataTable();
            dt = bus.GetListChucVu();
            cmbChucVu.DataSource = dt;
            cmbChucVu.DisplayMember = "TenChucVu";
            cmbChucVu.ValueMember = "MaChucVu";
        }
        public void ShowNhanVien()
        {
            DataTable dt = new DataTable();
            dt = bus.GetListNhanVien();
            cmbNhanVien.DataSource = dt;
            cmbNhanVien.DisplayMember = "TenNV";
            cmbNhanVien.ValueMember = "MaNV";
        }
        private void HienThi()
        {
            dgvTGCT.DataSource = bus.GetData();
        }
        private void frmTGCT_Load(object sender, EventArgs e)
        {
            HienThi();
            DisEnl(false);
            ShowChucVu();
            ShowNhanVien();
        }

        private void dgvTGCT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbNhanVien.Text = Convert.ToString(dgvTGCT.CurrentRow.Cells["MaNV"].Value);
            cmbChucVu.Text = Convert.ToString(dgvTGCT.CurrentRow.Cells["TenChucVu"].Value);
            dpNgayNhanChuc.Text = Convert.ToString(dgvTGCT.CurrentRow.Cells["NgayNhanChuc"].Value);
        }

        private void dgvTGCT_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvTGCT.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void btnThemTime_Click(object sender, EventArgs e)
        {
            fluu = 0;
            DisEnl(true);
        }

        private void btnSuaTime_Click(object sender, EventArgs e)
        {
            fluu = 1;
            DisEnl(true);
        }

        private void btnXoaTime_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    bus.DeleteData(cmbNhanVien.SelectedValue.ToString(), cmbChucVu.SelectedValue.ToString());
                    MessageBox.Show("Xóa Thành Công!");
                    clearData();
                    DisEnl(false);
                    HienThi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message);
                }
            }
        }

        private void btnLuuTime_Click(object sender, EventArgs e)
        {
            obj.MaNV = cmbNhanVien.SelectedValue.ToString();
            obj.MaCV = cmbChucVu.SelectedValue.ToString();
            obj.NgayNhanChuc = dpNgayNhanChuc.Value;

            if (fluu == 0)
            {
                try
                {
                    bus.InserData(obj);
                    MessageBox.Show("Thêm Mới Thành Công!");
                    HienThi();
                    clearData();
                    DisEnl(false);
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
                    bus.UpdateData(obj);
                    MessageBox.Show("Sửa Thành Công ! ");
                    HienThi();
                    clearData();
                    DisEnl(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message);
                }

            }
        }

        private void btnHuyTime_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn hủy thao tác đang làm không?", "Xác Nhận Hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                HienThi();
                DisEnl(false);
            }
            else
            {
                return;
            }
        }

        private void btnThoatTime_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác Nhận Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                //frmMain m = new frmMain();
                //m.Show();
                // this.Close();

            }
            else
            {
                HienThi();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cmbTimKiem.Text == "Theo Mã NV")
            {
                dgvTGCT.DataSource = bus.TimKiemTGCT("SELECT dbo.ThoiGianCongTac.MaNV,HoTen,TenChucVu,NgayNhanChuc FROM dbo.ThoiGianCongTac,dbo.ChucVu,dbo.NhanVien WHERE MaChucVu = MaCV AND NhanVien.MaNV = ThoiGianCongTac.MaNV and ThoiGianCongTac.MaNV LIKE '%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cmbTimKiem.Text == "Theo Tên NV")
            {
                dgvTGCT.DataSource = bus.TimKiemTGCT(" SELECT dbo.ThoiGianCongTac.MaNV,HoTen,TenChucVu,NgayNhanChuc FROM dbo.ThoiGianCongTac,dbo.ChucVu,dbo.NhanVien WHERE MaChucVu = MaCV AND NhanVien.MaNV = ThoiGianCongTac.MaNV and HoTen LIKE N'%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cmbTimKiem.Text == "Theo Chức Vụ ")
            {
                dgvTGCT.DataSource = bus.TimKiemTGCT("SELECT dbo.ThoiGianCongTac.MaNV,HoTen,TenChucVu,NgayNhanChuc FROM dbo.ThoiGianCongTac,dbo.ChucVu,dbo.NhanVien WHERE MaChucVu = MaCV AND NhanVien.MaNV = ThoiGianCongTac.MaNV and TenChucVu LIKE N'%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cmbTimKiem.Text == "Theo Ngày Nhận Chức")
            {
                dgvTGCT.DataSource = bus.TimKiemTGCT("SELECT dbo.ThoiGianCongTac.MaNV,HoTen,TenChucVu,NgayNhanChuc FROM dbo.ThoiGianCongTac,dbo.ChucVu,dbo.NhanVien WHERE MaChucVu = MaCV AND NhanVien.MaNV = ThoiGianCongTac.MaNV and NgayNhanChuc LIKE '%" + txtTimKiem.Text.Trim() + "%'");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            HienThi();
            DisEnl(false);
        }
    }
}
