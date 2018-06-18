using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.VIEW

{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItemDangXuat_Click(object sender, EventArgs e)
        {

            frmDangNhap t = new frmDangNhap();
            t.Show();
            this.Close();
        }

        private void ToolStripMenuItemThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn thoát chương trình không?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void toolStripMenuItemQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien nv = new frmNhanVien();
            nv.Show();
            this.Hide();
        }

        private void toolStripMenuItemQuanLyPhongBan_Click(object sender, EventArgs e)
        {

            frmphongBan t = new frmphongBan();
            t.Show();
            this.Hide();
        }

        private void ToolStripMenuItemQuanLyNangLuong_Click(object sender, EventArgs e)
        {
            frmLuong l = new frmLuong();
            l.Show();
            this.Hide();
        }

        private void ToolStripMenuItemQuanLyTĐHV_Click(object sender, EventArgs e)
        {
            frmTDHV hv = new frmTDHV();
            hv.Show();
            this.Hide();
        }

        private void toolStripMenuItemQTCT_Click(object sender, EventArgs e)
        {
            frmTGCT t = new frmTGCT();
            t.Show();
            this.Hide();
        }

        private void ttNhanVientoolStripButton_Click(object sender, EventArgs e)
        {
            frmNhanVien nv = new frmNhanVien();
            nv.Show();
            this.Hide();
        }

        private void btnPhongBan_Click(object sender, EventArgs e)
        {
            frmphongBan t = new frmphongBan();
            t.Show();
            this.Hide();
        }

        private void btnNangLuong_Click(object sender, EventArgs e)
        {
            frmLuong l = new frmLuong();
            l.Show();
            this.Hide();
        }

        private void btnTĐHV_Click(object sender, EventArgs e)
        {
            frmTDHV hv = new frmTDHV();
            hv.Show();
            this.Hide();
        }

        private void btnQuaTrinhCongTac_Click(object sender, EventArgs e)
        {
            frmTGCT frm = new frmTGCT();
            frm.Show();        
            this.Hide();
        }
        private int i = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbchuchay.Location = new Point(lbchuchay.Location.X -i,lbchuchay.Location.Y);

            if(lbchuchay.Location.X <= -510 ||lbchuchay.Location.Y <= 0)
            {
                lbchuchay.Location = new Point(lbchuchay.Location.X+1300, lbchuchay.Location.Y);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if(frmDangNhap.Temp == "Quản Lý")
            {
                btnPhongBan.Enabled = true;
                btnNangLuong.Enabled = true;
                btnTĐHV.Enabled = true;
                btnQuaTrinhCongTac.Enabled = true;
                toolStripMenuItemQuanLyPhongBan.Enabled = true;
                ToolStripMenuItemQuanLyNangLuong.Enabled = true;
                ToolStripMenuItemQuanLyTĐHV.Enabled = true;
                toolStripMenuItemQTCT.Enabled = true;
                tàiKhoảnToolStripMenuItem.Enabled = true;
                quảnLýChứcVụToolStripMenuItem.Enabled = true;
                quảnLýThânNhânToolStripMenuItem.Enabled = true;
                quảnLýDânTộcToolStripMenuItem.Enabled = true;
                btnChucVu.Enabled = true;
                btnDanToc.Enabled = true;
            }
            timer1.Enabled = true;
        }

        private void hướngDãnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Helps.chm");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn thoát chương trình không?", "Xác nhận ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
         }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuTroGiup_Click(object sender, EventArgs e)
        {
            frmhuongdan hd = new frmhuongdan();
            hd.Show();
            
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongTinTaiKhoan frmTT = new frmThongTinTaiKhoan();
            frmTT.Show();
            this.Hide();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frmDoiPass = new frmDoiMatKhau();
            frmDoiPass.Show();
            this.Hide();
        }

        private void quảnLýChứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChucVu frm = new frmChucVu();
            frm.Show();
            this.Hide();
        }

        private void quảnLýThânNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThanNhan frmtn = new frmThanNhan();
            frmtn.Show();
            this.Hide();
        }

        private void quảnLýDânTộcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDanToc frm = new frmDanToc();
            frm.Show();
            this.Hide();
        }

     

        private void btnChucVu_Click(object sender, EventArgs e)
        {
            frmChucVu frm = new frmChucVu();
            frm.Show();
            this.Hide();
        }

        private void btnThannhan_Click(object sender, EventArgs e)
        {
            frmThanNhan frmtn = new frmThanNhan();
            frmtn.Show();
            this.Hide();
        }

        private void btnDanToc_Click(object sender, EventArgs e)
        {
            frmDanToc frm = new frmDanToc();
            frm.Show();
            this.Hide();
        }
    }
}
