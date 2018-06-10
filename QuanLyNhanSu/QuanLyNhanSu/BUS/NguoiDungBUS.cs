using QuanLyNhanSu.DAL;
using QuanLyNhanSu.ENTITY;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.BUS
{
    public class NguoiDungBUS
    {
        NguoiDung nd = new NguoiDung();
        NguoiDungDAL nddal = new NguoiDungDAL();
        public DataTable GetData()
        {
            return nddal.GetData();
        }
        public DataTable DangNhap(NguoiDung nd)
        {
            return nddal.GetUser(nd);
        }
        public int ThemNguoiDung(NguoiDung nd)
        {
            return nddal.ThemNguoiDung(nd);
        }
        public int SuaTaiKhoan(NguoiDung nd)
        {
            return nddal.SuaTaiKhoan(nd);
        }
        public int DeLeteTK(string ID)
        {
            return nddal.DeleteData(ID);
        }
        public DataTable GetListDataNV()
        {
            return nddal.GetListDataNV();
        }
    }
}
