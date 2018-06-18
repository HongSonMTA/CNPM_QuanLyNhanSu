
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
    public partial class frmNhanVien : Form
    {
        NhanVienEntity obj = new NhanVienEntity();
        NhanVienBUS Bus = new NhanVienBUS();

        ThoiGianCongTacBUS TimeBus = new ThoiGianCongTacBUS();
        ThoiGianCongTacEntity Time = new ThoiGianCongTacEntity();

        DanTocBUS dantocBus = new DanTocBUS();
        PhongbanBus pbBus = new PhongbanBus();
        ChucVuBUS cvBus = new ChucVuBUS();
        TrinhDoHocVanBUS tdBus = new TrinhDoHocVanBUS();
        LuongBus lBus = new LuongBus();

        private int fluu = 1;
        public frmNhanVien()
        {
            InitializeComponent();
        }
        public void ShowPhongBan()
        {
            DataTable dt = new DataTable();
            dt = pbBus.GetData();
            cmbMaPB.DataSource = dt;
            cmbMaPB.DisplayMember = "TenPB";
            cmbMaPB.ValueMember = "MaPB";
         
        }
        public void ShowChucVu()
        {
            DataTable dt = new DataTable();
            dt = cvBus.GetData();
            cmbChucVu.DataSource = dt;
            cmbChucVu.DisplayMember = "TenChucVu";
            cmbChucVu.ValueMember = "MaChucVu";

        }
        public void ShowDanToc()
        {
            DataTable dt = new DataTable();
            dt = dantocBus.GetData();
            cmbDanToc.DataSource = dt;
            cmbDanToc.DisplayMember = "TenDanToc";
            cmbDanToc.ValueMember = "MaDanToc";

        }
        public void ShowLuong()
        {
            DataTable dt = new DataTable();
            dt = lBus.GetData();
            cmbBacLuong.DataSource = dt;
            cmbBacLuong.DisplayMember = "BacLuong";
            cmbBacLuong.ValueMember = "BacLuong";
        }
        public void ShowTDHV()
        {
            DataTable dt = new DataTable();
            dt = tdBus.GetData();
            cmbMaTDHV.DataSource = dt;
            cmbMaTDHV.DisplayMember = "TenTrinhDo";
            cmbMaTDHV.ValueMember = "MaTDHV";
        }
        private void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            dtNgaySinh.Enabled = e;      
            cmbBacLuong.Enabled = e;
            cmbDanToc.Enabled = e;
            txtHoTen.Enabled = e;
            cmbMaPB.Enabled = e;
            txtMaNV.Enabled = e;
            cmbMaTDHV.Enabled = e;
            txtQueQuan.Enabled = e;
            txtSDT.Enabled = e;
            radNam.Enabled = e;
            radNu.Enabled = e;
            cmbChucVu.Enabled = e;
            dpNgayNhan.Enabled = e;
        }
        private void clearData()
        {
            txtMaNV.Text = "";
            cmbBacLuong.Text = "";
            cmbDanToc.Text = "";
            txtHoTen.Text = "";
            radNam.Checked=false;
            radNu.Checked = false;
            txtQueQuan.Text = "";
            txtSDT.Text = "";
            cmbMaPB.Text = "";
            cmbMaTDHV.Text = "";
        }
        private void HienThi()
        {
            dgvNhanVien.DataSource = Bus.GetData();
        }
        // xử lý cbMaPB


        private void btnThoat_Click(object sender, EventArgs e)
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
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            HienThi();
            DisEnl(false);
            ShowPhongBan();
            ShowLuong();
            ShowTDHV();
            ShowChucVu();
            ShowDanToc();
            if(frmDangNhap.Temp=="Quản Lý")
            {
                btnTGCT.Enabled = true;
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Bus.DeleteData(txtMaNV.Text);
                    MessageBox.Show("Xóa thành công!");
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            fluu = 0;
            txtMaNV.Text = Bus.TangMa();
            DisEnl(true);
            txtMaNV.Enabled = false;         
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            fluu = 1;
            DisEnl(true);
            txtMaNV.Enabled = false;
            cmbChucVu.Enabled = false;
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbTimKiem.Text == "Mã Nhân Viên")
            {
                dgvNhanVien.DataSource = Bus.TimKiemNV("SELECT dbo.NhanVien.MaNV,HoTen,TenDanToc,GioiTinh,NhanVien.SDT,QueQuan,NgaySinh,TenTrinhDo,TenPB,TienLuong=(LuongCoBan + LuongCoBan*HeSoLuong +HeSoLuong*100000),TenChucVu FROM dbo.NhanVien, dbo.PhongBan,dbo.TrinhDoHocVan,dbo.Luong,dbo.ChucVu,dbo.ThoiGianCongTac,DanToc WHERE  PhongBan.MaPB = NhanVien.MaPB   AND  Luong.BacLuong = NhanVien.BacLuong  AND  TrinhDoHocVan.MaTDHV = NhanVien.MaTDHV AND MaChucVu = MaCV AND NhanVien.MaNV = ThoiGianCongTac.MaNV AND DanToc.MaDanToc = dbo.NhanVien.MaDanToc AND NhanVien.MaNV LIKE '%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbTimKiem.Text == "Tên Nhân Viên")
            {
                dgvNhanVien.DataSource = Bus.TimKiemNV("SELECT dbo.NhanVien.MaNV,HoTen,TenDanToc,GioiTinh,NhanVien.SDT,QueQuan,NgaySinh,TenTrinhDo,TenPB,TienLuong=(LuongCoBan + LuongCoBan*HeSoLuong +HeSoLuong*100000),TenChucVu FROM dbo.NhanVien, dbo.PhongBan,dbo.TrinhDoHocVan,dbo.Luong,dbo.ChucVu,dbo.ThoiGianCongTac,DanToc WHERE  PhongBan.MaPB = NhanVien.MaPB   AND  Luong.BacLuong = NhanVien.BacLuong  AND  TrinhDoHocVan.MaTDHV = NhanVien.MaTDHV AND MaChucVu = MaCV AND NhanVien.MaNV = ThoiGianCongTac.MaNV AND DanToc.MaDanToc = dbo.NhanVien.MaDanToc AND HoTen LIKE N'%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbTimKiem.Text == "Dân Tộc")
            {
                dgvNhanVien.DataSource = Bus.TimKiemNV("SELECT dbo.NhanVien.MaNV,HoTen,TenDanToc,GioiTinh,NhanVien.SDT,QueQuan,NgaySinh,TenTrinhDo,TenPB,TienLuong=(LuongCoBan + LuongCoBan*HeSoLuong +HeSoLuong*100000),TenChucVu FROM dbo.NhanVien, dbo.PhongBan,dbo.TrinhDoHocVan,dbo.Luong,dbo.ChucVu,dbo.ThoiGianCongTac,DanToc WHERE  PhongBan.MaPB = NhanVien.MaPB   AND  Luong.BacLuong = NhanVien.BacLuong  AND  TrinhDoHocVan.MaTDHV = NhanVien.MaTDHV AND MaChucVu = MaCV AND NhanVien.MaNV = ThoiGianCongTac.MaNV AND DanToc.MaDanToc = dbo.NhanVien.MaDanToc AND TenDanToc LIKE N'%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbTimKiem.Text == "Giới Tính")
            {
                dgvNhanVien.DataSource = Bus.TimKiemNV("SELECT dbo.NhanVien.MaNV,HoTen,TenDanToc,GioiTinh,NhanVien.SDT,QueQuan,NgaySinh,TenTrinhDo,TenPB,TienLuong=(LuongCoBan + LuongCoBan*HeSoLuong +HeSoLuong*100000),TenChucVu FROM dbo.NhanVien, dbo.PhongBan,dbo.TrinhDoHocVan,dbo.Luong,dbo.ChucVu,dbo.ThoiGianCongTac,DanToc WHERE  PhongBan.MaPB = NhanVien.MaPB   AND  Luong.BacLuong = NhanVien.BacLuong  AND  TrinhDoHocVan.MaTDHV = NhanVien.MaTDHV AND MaChucVu = MaCV AND NhanVien.MaNV = ThoiGianCongTac.MaNV AND DanToc.MaDanToc = dbo.NhanVien.MaDanToc AND GioiTinh LIKE N'%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbTimKiem.Text == "SĐT")
            {
                dgvNhanVien.DataSource = Bus.TimKiemNV("SELECT dbo.NhanVien.MaNV,HoTen,TenDanToc,GioiTinh,NhanVien.SDT,QueQuan,NgaySinh,TenTrinhDo,TenPB,TienLuong=(LuongCoBan + LuongCoBan*HeSoLuong +HeSoLuong*100000),TenChucVu FROM dbo.NhanVien, dbo.PhongBan,dbo.TrinhDoHocVan,dbo.Luong,dbo.ChucVu,dbo.ThoiGianCongTac,DanToc WHERE  PhongBan.MaPB = NhanVien.MaPB   AND  Luong.BacLuong = NhanVien.BacLuong  AND  TrinhDoHocVan.MaTDHV = NhanVien.MaTDHV AND MaChucVu = MaCV AND NhanVien.MaNV = ThoiGianCongTac.MaNV AND DanToc.MaDanToc = dbo.NhanVien.MaDanToc AND  NhanVien.SDT LIKE  '%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbTimKiem.Text == "Quê Quán")
            {
                dgvNhanVien.DataSource = Bus.TimKiemNV("SELECT dbo.NhanVien.MaNV,HoTen,TenDanToc,GioiTinh,NhanVien.SDT,QueQuan,NgaySinh,TenTrinhDo,TenPB,TienLuong=(LuongCoBan + LuongCoBan*HeSoLuong +HeSoLuong*100000),TenChucVu FROM dbo.NhanVien, dbo.PhongBan,dbo.TrinhDoHocVan,dbo.Luong,dbo.ChucVu,dbo.ThoiGianCongTac,DanToc WHERE  PhongBan.MaPB = NhanVien.MaPB   AND  Luong.BacLuong = NhanVien.BacLuong  AND  TrinhDoHocVan.MaTDHV = NhanVien.MaTDHV AND MaChucVu = MaCV AND NhanVien.MaNV = ThoiGianCongTac.MaNV AND DanToc.MaDanToc = dbo.NhanVien.MaDanToc AND  QueQuan LIKE N'%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbTimKiem.Text == "Ngày Sinh(năm-tháng-ngày)")
            {
                dgvNhanVien.DataSource = Bus.TimKiemNV("SELECT dbo.NhanVien.MaNV,HoTen,TenDanToc,GioiTinh,NhanVien.SDT,QueQuan,NgaySinh,TenTrinhDo,TenPB,TienLuong=(LuongCoBan + LuongCoBan*HeSoLuong +HeSoLuong*100000),TenChucVu FROM dbo.NhanVien, dbo.PhongBan,dbo.TrinhDoHocVan,dbo.Luong,dbo.ChucVu,dbo.ThoiGianCongTac,DanToc WHERE  PhongBan.MaPB = NhanVien.MaPB   AND  Luong.BacLuong = NhanVien.BacLuong  AND  TrinhDoHocVan.MaTDHV = NhanVien.MaTDHV AND MaChucVu = MaCV AND NhanVien.MaNV = ThoiGianCongTac.MaNV AND DanToc.MaDanToc = dbo.NhanVien.MaDanToc AND  NgaySinh LIKE  '%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbTimKiem.Text == "TĐHV")
            {
                dgvNhanVien.DataSource = Bus.TimKiemNV("SELECT dbo.NhanVien.MaNV,HoTen,TenDanToc,GioiTinh,NhanVien.SDT,QueQuan,NgaySinh,TenTrinhDo,TenPB,TienLuong=(LuongCoBan + LuongCoBan*HeSoLuong +HeSoLuong*100000),TenChucVu FROM dbo.NhanVien, dbo.PhongBan,dbo.TrinhDoHocVan,dbo.Luong,dbo.ChucVu,dbo.ThoiGianCongTac,DanToc WHERE  PhongBan.MaPB = NhanVien.MaPB   AND  Luong.BacLuong = NhanVien.BacLuong  AND  TrinhDoHocVan.MaTDHV = NhanVien.MaTDHV AND MaChucVu = MaCV AND NhanVien.MaNV = ThoiGianCongTac.MaNV AND DanToc.MaDanToc = dbo.NhanVien.MaDanToc AND TenTrinhDo LIKE N'%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbTimKiem.Text == "Tên Phòng Ban")
            {
                dgvNhanVien.DataSource = Bus.TimKiemNV("SELECT dbo.NhanVien.MaNV,HoTen,TenDanToc,GioiTinh,NhanVien.SDT,QueQuan,NgaySinh,TenTrinhDo,TenPB,TienLuong=(LuongCoBan + LuongCoBan*HeSoLuong +HeSoLuong*100000),TenChucVu FROM dbo.NhanVien, dbo.PhongBan,dbo.TrinhDoHocVan,dbo.Luong,dbo.ChucVu,dbo.ThoiGianCongTac,DanToc WHERE  PhongBan.MaPB = NhanVien.MaPB   AND  Luong.BacLuong = NhanVien.BacLuong  AND  TrinhDoHocVan.MaTDHV = NhanVien.MaTDHV AND MaChucVu = MaCV AND NhanVien.MaNV = ThoiGianCongTac.MaNV AND DanToc.MaDanToc = dbo.NhanVien.MaDanToc AND PhongBan.TenPB LIKE N'%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cbTimKiem.Text == "Lương")
            {
                dgvNhanVien.DataSource = Bus.TimKiemNV("SELECT dbo.NhanVien.MaNV,HoTen,TenDanToc,GioiTinh,NhanVien.SDT,QueQuan,NgaySinh,TenTrinhDo,TenPB,TienLuong=(LuongCoBan + LuongCoBan*HeSoLuong +HeSoLuong*100000),TenChucVu FROM dbo.NhanVien, dbo.PhongBan,dbo.TrinhDoHocVan,dbo.Luong,dbo.ChucVu,dbo.ThoiGianCongTac,DanToc WHERE  PhongBan.MaPB = NhanVien.MaPB   AND  Luong.BacLuong = NhanVien.BacLuong  AND  TrinhDoHocVan.MaTDHV = NhanVien.MaTDHV AND MaChucVu = MaCV AND NhanVien.MaNV = ThoiGianCongTac.MaNV AND DanToc.MaDanToc = dbo.NhanVien.MaDanToc AND (LuongCoBan + LuongCoBan * HeSoLuong + HeSoPhuCap * 100000) LIKE '%" + txtTimKiem.Text.Trim() + "%'");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // xử lý
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtHoTen.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbDanToc.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập dân tộc của nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtQueQuan.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập quê quán nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txtSDT.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập SĐT nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (cmbBacLuong.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập bậc lương nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbMaPB.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập phòng ban của nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbMaTDHV.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập TĐHV nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (radNam.Checked == false && radNu.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn giới tính của nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbChucVu.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Chức Vụ Của  nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                obj.MaNV = txtMaNV.Text;
                obj.HoTen = txtHoTen.Text;
                obj.MaPB = cmbMaPB.SelectedValue.ToString();
                obj.QueQuan = txtQueQuan.Text;
                obj.DanToc = cmbDanToc.SelectedValue.ToString();
                obj.MaTDHV = cmbMaTDHV.SelectedValue.ToString();
                obj.SDT = txtSDT.Text;
                obj.NgaySinh = dtNgaySinh.Value;
                obj.BacLuong = cmbBacLuong.SelectedValue.ToString();
                Time.MaNV = txtMaNV.Text;
                Time.MaCV = cmbChucVu.SelectedValue.ToString();
                Time.NgayNhanChuc = dpNgayNhan.Value;
                string gt;
                if (radNam.Checked)
                {
                    gt = "Nam";
                }
                else gt = "Nữ";
                obj.GioiTinh = gt;

                if ( fluu == 0)
                {
                    try
                    {
                        Bus.InsertData(obj);
                        TimeBus.InserData(Time);
                        MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThi();
                        frmNhanVien_Load(sender, e);
                        clearData();
                        DisEnl(false);
                        fluu = 1;
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
                        Bus.UpdateData(obj);
                        TimeBus.UpdateData(Time);
                        MessageBox.Show("Sửa Thành Công ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienThi();
                        frmNhanVien_Load(sender, e);
                        clearData();
                        DisEnl(false);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi" + ex.Message);
                    }
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                HienThi();
                DisEnl(false);
                fluu = 1;
                
            }
            else
                return;
        }

        private void dgvNhanVien_RowPrePaint_1(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvNhanVien.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (fluu == 0)
            {
                txtHoTen.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["HoTen"].Value);
                cmbDanToc.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["DanToc"].Value);
                txtSDT.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["SDT"].Value);
                txtQueQuan.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["QueQuan"].Value);
                dtNgaySinh.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["NgaySinh"].Value);
                cmbMaTDHV.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["TenTrinhDo"].Value);
                cmbMaPB.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["TenPB"].Value);
                cmbBacLuong.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["TienLuong"].Value);
                if (dgvNhanVien.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString() == "Nam") radNam.Checked = true;
                else radNu.Checked = true;
                cmbChucVu.Text= Convert.ToString(dgvNhanVien.CurrentRow.Cells["ChucVu"].Value);
            }
            else
            {
                txtMaNV.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["MaNV"].Value);
                txtHoTen.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["HoTen"].Value);
                cmbDanToc.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["DanToc"].Value);
                txtSDT.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["SDT"].Value);
                txtQueQuan.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["QueQuan"].Value);
                dtNgaySinh.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["NgaySinh"].Value);
                cmbMaTDHV.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["TenTrinhDo"].Value);
                cmbMaPB.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["TenPB"].Value);
                cmbBacLuong.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["TienLuong"].Value);
                if (dgvNhanVien.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString() == "Nam") radNam.Checked = true;
                else radNu.Checked = true;
                cmbChucVu.Text = Convert.ToString(dgvNhanVien.CurrentRow.Cells["ChucVu"].Value);
            }
        }

        private void btnTGCT_Click(object sender, EventArgs e)
        { 
            frmTGCT frm = new frmTGCT();
            frm.Show();
            this.Hide();
        }
    }
}
