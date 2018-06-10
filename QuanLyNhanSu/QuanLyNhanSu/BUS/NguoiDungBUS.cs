using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhanSu.ENTITY;
using QuanLyNhanSu.DAL;
using System.Data;

namespace QuanLyNhanSu.BUS
{
    public class NguoiDungBUS
    {
        NguoiDungDAL nddal = new NguoiDungDAL();
        public DataTable DangNhap(string TaiKhoan, string MatKhau)
        {
            return nddal.GetUser(TaiKhoan,MatKhau);
        }
    }
}
