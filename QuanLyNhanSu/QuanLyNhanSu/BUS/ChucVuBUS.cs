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
    public class ChucVuBUS
    {
        ChucVuDAL chucvuDAl = new ChucVuDAL();
        public DataTable GetData()
        {
            return chucvuDAl.GetData();
        }
        public int InsertData(ChucVuEntity CV)
        {
            return chucvuDAl.InsertData(CV);
        }
        public int UpdateData(ChucVuEntity CV)
        {
            return chucvuDAl.UpdateData(CV);
        }
        public int DeleteData(string ID)
        {
            return chucvuDAl.DeleteData(ID);
        }
        public string TangMa()
        {
            return chucvuDAl.TangMa();
        }
        public DataTable TimKiem(string str)
        {
            return chucvuDAl.TimKiem(str);
        }
    }
}
