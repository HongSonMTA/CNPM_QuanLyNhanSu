using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhanSu.ENTITY;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhanSu.DAL
{
    public class ThoiGianCongTacDAL
    {
        KetNoi conn = new KetNoi();
        public DataTable GetData()
        {
            return conn.GetData("Select_TGCT", null);
        }
        public DataTable TimKiemTGCT(string strTimKiem)
        {
            return conn.GetData(strTimKiem);
        }
        public int InsertData(ThoiGianCongTacEntity TGCT)
        {
            SqlParameter[] para = {
                new SqlParameter("MaNV", TGCT.MaNV),
                new SqlParameter("MaCV", TGCT.MaCV),
                new SqlParameter("NgayNhanChuc", TGCT.NgayNhanChuc),
            };
            return conn.ExcuteSQL("Them_TGCT", para);
        }

        public int UpdateData(ThoiGianCongTacEntity TGCT)
        {
            SqlParameter[] para = {
                new SqlParameter("MaNV", TGCT.MaNV),
                new SqlParameter("MaCV", TGCT.MaCV),
                new SqlParameter("NgayNhanChuc", TGCT.NgayNhanChuc),
            };
            return conn.ExcuteSQL("Sua_TGCT", para);
        }

        public int DeleteData(string MaNV,string MaCV)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaNV",MaNV),
                new SqlParameter("MaCV",MaCV)

            };
            return conn.ExcuteSQL("Xoa_TGCT", para);
        }
        public DataTable GetListChucVu()
        {
            return conn.GetData("SelectAll_CV", null);
        }
        public DataTable GetListNhanVien()
        {
            return conn.GetData("SelectAll_NV", null);
        }
    }
}
