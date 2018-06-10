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
    public class DanTocDAL
    {
        KetNoi conn = new KetNoi();
        public DataTable GetData()
        {
            return conn.GetData("SelectAll_DT", null);
        }

        public int InsertData(DanTocEntity DT)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaDanToc",DT.MaDanToc),
                new SqlParameter("TenDanToc",DT.TenDanToc),
                new SqlParameter("GhiChu",DT.GhiChu)
            };
            return conn.ExcuteSQL("Them_DT", para);
        }
        public int UpdateData(DanTocEntity DT)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaDanToc",DT.MaDanToc),
                new SqlParameter("TenDanToc",DT.TenDanToc),
                new SqlParameter("GhiChu",DT.GhiChu)
            };
            return conn.ExcuteSQL("Sua_DT", para);
        }
        public int DeleteData(string MaDanToc)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaDanToc",MaDanToc)
        };
            return conn.ExcuteSQL("Xoa_DT", para);
        }
        public DataTable TimKiem(string strTimKiem)
        {
            return conn.GetData(strTimKiem);
        }
        public string TangMa()
        {
            return conn.TangMa("Select * From DanToc ", "DT");
        }
    }
}
