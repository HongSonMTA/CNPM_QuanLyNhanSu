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
    public class PhongbanBus
    {
        PhongbanDAL da = new PhongbanDAL();
        public DataTable GetData()
        {
            return da.GetData();
        }
        public int InsertData(PhongBanEntity Pb)
        {
            return da.InsertData(Pb);
        }
        public int UpdateData(PhongBanEntity Pb)
        {
            return da.UpdateData(Pb);
        }
        public int DeleteData(String ID)
        {
            return da.DeleteData(ID);
        }
        public string TangMa()
        {
            return da.TangMa();
        }
        public DataTable TimKiemPB(string strTimKiem)
        {
            return da.TimKiemPB(strTimKiem);
        }
    }
}
