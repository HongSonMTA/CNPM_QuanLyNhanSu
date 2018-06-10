using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyNhanSu.ENTITY;
using System.Data.SqlClient;

namespace QuanLyNhanSu.DAL
{
    public class NguoiDungDAL
    {
        KetNoi conn = new KetNoi();
        public DataTable GetData()
        {
            return conn.GetData("Select_TK", null);
        }
        public DataTable GetUser(NguoiDung nd)
        {
            SqlParameter[] para = { new SqlParameter("TaiKhoan", nd.TaiKhoan),
                                    new SqlParameter("MatKhau", nd.MatKhau),
                                    new SqlParameter("PhanQuyen", nd.PhanQuyen)

            };
            return conn.GetData("DangNhap", para);
        }
        public int ThemNguoiDung(NguoiDung nd)
        {
            SqlParameter[] para = { new SqlParameter("TaiKhoan", nd.TaiKhoan),
                                    new SqlParameter("MatKhau", nd.MatKhau),
                                    new SqlParameter("PhanQuyen", nd.PhanQuyen),
                                    new SqlParameter("MaNV", nd.MaNV)
            };
            return conn.ExcuteSQL("SP_ThemNguoiDung", para);
        }
        public int SuaTaiKhoan(NguoiDung nd)
        {
            SqlParameter[] para = { new SqlParameter("TaiKhoan", nd.TaiKhoan),
                                    new SqlParameter("MatKhau", nd.MatKhau)
            };
            return conn.ExcuteSQL("SP_SuaTK", para);
        }
        public int DeleteData(string ID)
        {
            SqlParameter[] para =
            {
                new SqlParameter("TaiKhoan",ID)
        };
            return conn.ExcuteSQL("Xoa_TK ", para);
        }
        public DataTable GetListDataNV()
        {
            return conn.GetData("Select_TKNV", null);
        }
    }
}
