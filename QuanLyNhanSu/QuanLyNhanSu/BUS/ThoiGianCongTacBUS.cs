using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyNhanSu.ENTITY;
using QuanLyNhanSu.DAL;
namespace QuanLyNhanSu.BUS
{
    public class ThoiGianCongTacBUS
    {
        ThoiGianCongTacDAL TGCTDAL = new ThoiGianCongTacDAL();
        public DataTable GetData()
        {
            return TGCTDAL.GetData();
        }
        public int InserData(ThoiGianCongTacEntity TGCT)
        {
            return TGCTDAL.InsertData(TGCT);
        }
        public int UpdateData(ThoiGianCongTacEntity TGCT)
        {
            return TGCTDAL.UpdateData(TGCT);
        }
        public int DeleteData(string MaNV,string MaCV)
        {
            return TGCTDAL.DeleteData(MaNV,MaCV);
        }
        public DataTable GetListChucVu()
        {
            return TGCTDAL.GetListChucVu();
        }
        public DataTable GetListNhanVien()
        {
            return TGCTDAL.GetListNhanVien();
        }
        public DataTable TimKiemTGCT(string strTimKiem)
        {
            return TGCTDAL.TimKiemTGCT(strTimKiem);
        }
    }
}
