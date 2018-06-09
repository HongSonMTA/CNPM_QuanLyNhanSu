using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanSu_Entity;
using QuanLyNhanSu_BUS;

namespace QuanLyNhanSu.QuanLyNhanSu
{
    public partial class frmChucVu : Form
    {
        ChucVuEntity obj = new ChucVuEntity();
        ChucVuBUS bus = new ChucVuBUS();
        private int fluu = 1;
        public frmChucVu()
        {
            InitializeComponent();
        }
        private void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            txtMaChucVu.Enabled = e;
            txtTenChucVu.Enabled = e;
        }
        private void clearData()
        {
            txtMaChucVu.Text = "";
            txtTenChucVu.Text = "";
        }
        private void HienThi()
        {
            dgvChucVu.DataSource = bus.GetData();
        }
        private void frmChucVu_Load(object sender, EventArgs e)
        {
            HienThi();
            DisEnl(false);
        }

        private void dgvChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (fluu == 0)
            {
                txtTenChucVu.Text = Convert.ToString(dgvChucVu.CurrentRow.Cells["TenCV"].Value);
            }
            else
            {
                txtMaChucVu.Text = Convert.ToString(dgvChucVu.CurrentRow.Cells["MaCV1"].Value);
                txtTenChucVu.Text = Convert.ToString(dgvChucVu.CurrentRow.Cells["TenCV"].Value);
            }
        }

        private void dgvChucVu_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvChucVu.Rows[e.RowIndex].Cells["STT1"].Value = e.RowIndex + 1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fluu = 0;
            clearData();
            DisEnl(true);
            txtMaChucVu.Text = bus.TangMa();
            txtMaChucVu.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            fluu = 1;
            DisEnl(true);
            txtMaChucVu.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    bus.DeleteData(txtMaChucVu.Text);
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            obj.MaChucVu = txtMaChucVu.Text;
            obj.TenChucVu = txtTenChucVu.Text;
            if (fluu == 0)
            {
                bus.InsertData(obj);
                MessageBox.Show("Thêm Mới Thành Công!");
                HienThi();
                clearData();
                DisEnl(false);
            }
            else
            {
                bus.UpdateData(obj);
                MessageBox.Show("Sửa Thành Công ! ");
                HienThi();
                clearData();
                DisEnl(false);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác Nhận Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                //frmMain m = new frmMain();
                //   m.Show();
                //  this.Close();

            }
            else
            {
                HienThi();
            }
        }
    }
}
