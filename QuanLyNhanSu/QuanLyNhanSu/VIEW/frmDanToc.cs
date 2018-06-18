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
    public partial class frmDanToc : Form
    {
        DanTocBUS dantocBus = new DanTocBUS();
        DanTocEntity DT = new DanTocEntity();

        private int fluu = 1;
        public frmDanToc()
        {
            InitializeComponent();
        }
        private void HienThi()
        {
            dgvDanToc.DataSource = dantocBus.GetData();
            khoaBtn(false);
        }

        private void khoaBtn(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            txtMaDT.Enabled = e;
            txtTenDT.Enabled = e;
            txtGhiChu.Enabled = e;
        }

        private void clearTxt()
        {
            txtMaDT.Text = "";
            txtTenDT.Text = "";
            txtGhiChu.Text = "";
        }

        private void frmDanToc_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void dgvDanToc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (fluu == 0)
            {
                txtTenDT.Text = Convert.ToString(dgvDanToc.CurrentRow.Cells["TenDanToc"].Value);
                txtGhiChu.Text = Convert.ToString(dgvDanToc.CurrentRow.Cells["GhiChu"].Value);
            }
            else
            {
                txtTenDT.Text = Convert.ToString(dgvDanToc.CurrentRow.Cells["TenDanToc"].Value);
                txtGhiChu.Text = Convert.ToString(dgvDanToc.CurrentRow.Cells["GhiChu"].Value);
                txtMaDT.Text = Convert.ToString(dgvDanToc.CurrentRow.Cells["MaDanToc"].Value);
            }
        }

        private void dgvDanToc_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvDanToc.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fluu = 0;
            khoaBtn(true);
            txtMaDT.Text = dantocBus.TangMa();
            txtMaDT.Enabled = false;
        }

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

        private void btnSua_Click(object sender, EventArgs e)
        {
            fluu = 1;
            khoaBtn(true);
            txtMaDT.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    dantocBus.DeleteData(txtMaDT.Text);
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaDT.Text == "" || txtTenDT.Text == "" || txtGhiChu.Text == "" )
            {
                MessageBox.Show("Thiếu thông tin!");
            }
            else
            {
                DT.MaDanToc = txtMaDT.Text;
                DT.TenDanToc = txtTenDT.Text;
                DT.GhiChu = txtGhiChu.Text;
                if (fluu == 0)
                {
                    try
                    {
                        dantocBus.InsertData(DT);
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
                        dantocBus.UpdateData(DT);
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
                fluu = 1;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                HienThi();
                khoaBtn(false);
                clearTxt();
                fluu = 1;

            }
            else
                return;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cmbTimKiem.Text .Equals ("Mã Dân Tộc"))
            {
                dgvDanToc.DataSource = dantocBus.TimKiem("SELECT * FROM dbo.DanToc WHERE MaDanToc LIKE'%" + txtTimKiem.Text.Trim() + "%'");
            }
            if (cmbTimKiem.Text.Equals( "Tên Dân Tộc"))
            {
                dgvDanToc.DataSource = dantocBus.TimKiem("SELECT * FROM dbo.DanToc WHERE TenDanToc LIKE N'%" + txtTimKiem.Text.Trim() + "%'");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            cmbTimKiem.Text = "";
            HienThi();
        }
    }
}
