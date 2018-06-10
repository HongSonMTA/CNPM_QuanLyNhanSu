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
    public partial class frmDoiMatKhau : Form
    {
        NguoiDungBUS Bus = new NguoiDungBUS();
        NguoiDung nd = new NguoiDung();
        
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void check_CheckedChanged(object sender, EventArgs e)
        {
            bool checkpass = check.Checked;
            if (checkpass)
            {
                txtDKMatKhau.UseSystemPasswordChar = false;
                txtNhapLaiMatKhau.UseSystemPasswordChar = false;
            }
            else
                txtDKMatKhau.UseSystemPasswordChar = true;
                 txtNhapLaiMatKhau.UseSystemPasswordChar = false;
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
            this.Close();
        }

        private void btnDoiPass_Click(object sender, EventArgs e)
        {
            nd.TaiKhoan = frmDangNhap.TaiKhoan;
            nd.MatKhau = txtDKMatKhau.Text;

            if (txtDKMatKhau.Text == "")
            {
                lblLoiDangKiMatKhau.Text = "Bạn chưa nhập mật khẩu";
            }
            else if (txtDKMatKhau.Text != txtNhapLaiMatKhau.Text)
            {
                lblLoiNhapLaiMatKhau.Text = "Mật khẩu không trùng khớp";
            }
            else
            {
                Bus.SuaTaiKhoan(nd);
                MessageBox.Show("Đổi Mật Khẩu Thành Công!");
                frmMain frmTK = new frmMain();
                frmTK.Show();
                this.Close();
            }
        }
    }
}
