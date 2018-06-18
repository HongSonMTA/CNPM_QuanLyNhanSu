using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhanSu.DAL;
using QuanLyNhanSu.ENTITY;
using System.Data;
namespace QuanLyNhanSu.BUS
{
    public class ThanNhanBUS
    {
        ThanNhanDAL thanNhanDAL = new ThanNhanDAL();

        public DataTable GetData()
        {
            return thanNhanDAL.GetData();
        }

        public int InsertData(ThanNhan thanNhan)
        {
           return thanNhanDAL.InsertData(thanNhan);
        }
        public int UpdateData(ThanNhan thanNhan)
        {
            return thanNhanDAL.UpdateData(thanNhan);
        }
        public int DeleteData(string tenThanNhan)
        {
            return thanNhanDAL.DeleteData(tenThanNhan);
        }
        public DataTable TimKiem(string strTimKiem)
        {
            return thanNhanDAL.TimKiem(strTimKiem);
        }
        public string TangMa()
        {
            return thanNhanDAL.TangMa();
        }

        public DataTable GetListNhanVien()
        {
            return thanNhanDAL.GetListNhanVien();
        }

    }
}
