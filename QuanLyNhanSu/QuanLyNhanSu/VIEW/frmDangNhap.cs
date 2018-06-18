using QuanLyNhanSu.BUS;
using QuanLyNhanSu.ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.VIEW
{
    public partial class frmDangNhap : Form
    {
        NguoiDung nd = new NguoiDung();
        NguoiDungBUS ndbus = new NguoiDungBUS();

        public static string Temp;
        public static string TaiKhoan;
        public static string MatKhau;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            TaiKhoan = txtTaiKhoan.Text;
            Temp = cmbQuyen.Text;
            MatKhau = txtMatKhau.Text;
            nd.TaiKhoan= txtTaiKhoan.Text ;
             nd.MatKhau= txtMatKhau.Text ;
             nd.PhanQuyen= cmbQuyen.Text ;
            if (txtTaiKhoan.Text == "")
            {
                lblNoName.Text = "Bạn chưa nhập tài khoản";
            }
            else if (txtMatKhau.Text == "")
            {
                lblNoPass.Text = "Bạn chưa nhập mật khẩu";
            }
            else
            {
                DataTable dt = new DataTable();
                dt = ndbus.DangNhap(nd);
                if (dt.Rows.Count > 0)
                {
                    frmMain mainn=new frmMain();
                    mainn.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
            MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        }
        private void txtTenDangNhap_Click(object sender, EventArgs e)
        {
            lblNoName.Text = "";
        }

        private void txtMatKhau_Click(object sender, EventArgs e)
        {
            lblNoPass.Text = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool ckeck = checkBox1.Checked;
            if (ckeck)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
                txtMatKhau.UseSystemPasswordChar = true;

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
