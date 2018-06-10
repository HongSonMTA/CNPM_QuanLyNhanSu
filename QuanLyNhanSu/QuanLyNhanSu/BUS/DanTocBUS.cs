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
    public class DanTocBUS
    {
        DanTocDAL dantoc = new DanTocDAL();

        public DataTable GetData()
        {
            return dantoc.GetData();
        }
        public int InsertData(DanTocEntity DT)
        {
            return dantoc.InsertData(DT);
        }
        public int UpdateData(DanTocEntity DT)
        {
            return dantoc.UpdateData(DT);
        }
        public int DeleteData(string MaDanToc)
        {
            return dantoc.DeleteData(MaDanToc);
        }
        public DataTable TimKiem(string strTimKiem)
        {
            return dantoc.TimKiem(strTimKiem);
        }
        public string TangMa()
        {
            return dantoc.TangMa();
        }
    }
}
