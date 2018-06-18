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
    public class ThanNhanDAL
    {
        KetNoi conn = new KetNoi();
        public DataTable GetData()
        {
            return conn.GetData("SP_ThanNhanSelectAll", null);
        }
     
        public int InsertData(ThanNhan thanNhan)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaTN",thanNhan.MaTN),
                new SqlParameter("TenTN",thanNhan.TenTN),
                new SqlParameter("MaNV",thanNhan.MaNV),
                new SqlParameter("GioiTinh",thanNhan.GioiTinh),
                new SqlParameter("MoiQuanHe",thanNhan.MoiQuanHe),
                new SqlParameter("Tuoi",thanNhan.Tuoi)
            };
            return conn.ExcuteSQL("SP_ThemThanNhan", para);
        }
        public int UpdateData(ThanNhan thanNhan)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaTN",thanNhan.MaTN),
                new SqlParameter("TenTN",thanNhan.TenTN),
                new SqlParameter("MaNV",thanNhan.MaNV),
                new SqlParameter("GioiTinh",thanNhan.GioiTinh),
                new SqlParameter("MoiQuanHe",thanNhan.MoiQuanHe),
                new SqlParameter("Tuoi",thanNhan.Tuoi)
            };
            return conn.ExcuteSQL("SP_SuaThanNhan", para);
        }
        public int DeleteData(string MaTN)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaTN",MaTN)
        };
            return conn.ExcuteSQL("SP_XoaThanNhan", para);
        }
        public DataTable TimKiem(string strTimKiem)
        {
            return conn.GetData(strTimKiem);
        }
        public string TangMa()
        {
            return conn.TangMa("Select * From ThanNhan ", "TN");
        }
        public DataTable GetListNhanVien()
        {
            return conn.GetData("SP_SelectNV", null);
        }
    }
}
