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
    public class ChucVuDAL
    {
        KetNoi conn = new KetNoi();

        public DataTable GetData()
        {
            return conn.GetData("SelectAll_CV", null);
        }

        public int InsertData(ChucVuEntity ChucVu)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaChucVu",ChucVu.MaChucVu),
                new SqlParameter("TenChucVu",ChucVu.TenChucVu)
            };
            return conn.ExcuteSQL("Them_CV", para);
        }

        public int UpdateData(ChucVuEntity ChucVu)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaChucVu",ChucVu.MaChucVu),
                new SqlParameter("TenChucVu",ChucVu.TenChucVu)
            };
            return conn.ExcuteSQL("Sua_CV", para);
        }

        public int DeleteData(string MaCV)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaChucVu",MaCV)
            };
            return conn.ExcuteSQL("Xoa_CV", para);
        }
        public string TangMa()
        {
            return conn.TangMa("select * from ChucVu", "CV");
        }
        public DataTable TimKiem(string str)
        {
            return conn.GetData(str);
        }

    }
}
