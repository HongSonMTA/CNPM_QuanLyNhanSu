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
    public partial class frmThongTinTaiKhoan : Form
    {
        NguoiDungBUS Bus = new NguoiDungBUS();
        public frmThongTinTaiKhoan()
        {
            InitializeComponent();
        }
        private void frmThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            dgvTTTK.DataSource = Bus.GetData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmDangKi frmDk = new frmDangKi();
            frmDk.Show();
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                frmMain frmMain = new frmMain();
                frmMain.Show();
            }
            else
                frmThongTinTaiKhoan_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Bus.DeLeteTK(txtTK.Text);
                    MessageBox.Show("Xóa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmThongTinTaiKhoan_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có Lỗi Không thể xóa !");
                }
            }
        }

        private void dgvTTTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTK.Text = Convert.ToString(dgvTTTK.CurrentRow.Cells["TaiKhoan"].Value);
        }

        private void dgvTTTK_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvTTTK.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }
    }
}
