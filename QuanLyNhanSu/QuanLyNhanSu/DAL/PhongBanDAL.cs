﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhanSu.ENTITY;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhanSu.DAL
{
    public class PhongbanDAL
    {
        KetNoi conn = new KetNoi();
        public DataTable GetData()
        {
            return conn.GetData("PB_SelectAll", null);
        }
        public DataTable GetData(String MaPB)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaPB",MaPB),
               
            };
            return conn.GetData("PB_SellectNV", para);
        }
        public int InsertData(PhongBanEntity pb)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaPB",pb.MaPB),
                new SqlParameter("TenPB",pb.TenPB),
                new SqlParameter("MaTP",pb.MaTP),
                new SqlParameter("DiaChi",pb.DiaChi),
                new SqlParameter ("Sdt",pb.Sdt)
            };
            return conn.ExcuteSQL("Them_PB ", para);
        }
        public int UpdateData(PhongBanEntity pb)
        {
            SqlParameter[] para =
            {
                new SqlParameter("MaPB",pb.MaPB),
                new SqlParameter("TenPB",pb.TenPB),
                new SqlParameter("MaTP",pb.MaTP),
                new SqlParameter("DiaChi",pb.DiaChi),
                new SqlParameter ("Sdt",pb.Sdt)
        };
            return conn.ExcuteSQL("Sua_PB ", para);
        }
        public int DeleteData(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("Ma",ID)
        };
            return conn.ExcuteSQL("Xoa_PB ", para);
        }
        public string TangMa()
        {
            return conn.TangMa("Select * From PhongBan", "PB");
        }
        public DataTable TimKiemPB(string strTimKiem)
        {
            return conn.GetData(strTimKiem);
        }
        public DataTable GetListNhanVien()
        {
            return conn.GetData("SelectAll_NV", null);
        }

    }
}
