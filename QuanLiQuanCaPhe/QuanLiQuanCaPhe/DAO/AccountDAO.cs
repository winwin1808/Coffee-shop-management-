using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLiQuanCaPhe.DTO;

namespace QuanLiQuanCaPhe.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }
        private AccountDAO() { }

        public bool Login(string UserName, string PassWord)
            {
            string query = "USP_LOGIN @TenDangNhap , @MatKhau";

            DataTable result = DataProvider.Instance.ExcuteQuery(query, new object[] {UserName, PassWord});

            return result.Rows.Count > 0;
        }

        public Account GetAccountByUserName(string TenDangNhap)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery($"Select * FROM TAIKHOAN WHERE TenDangNhap = '{TenDangNhap}'");

            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }

            return null;
        }

        public DataTable GetListAccount()
        {
            return DataProvider.Instance.ExcuteQuery("SELECT TenHienThi, TenDangNhap, LoaiTaiKhoan FROM dbo.TAIKHOAN");
        }
        public bool InsertAccount(string TenHienThi, string TenDangNhap, int LoaiTaiKhoan)
        {
            string query = string.Format($"INSERT dbo.TAIKHOAN ( TenHienThi, TenDangNhap, MatKhau, LoaiTaiKhoan ) VALUES  ( N'{TenHienThi}', N'{TenDangNhap}', N'1', {LoaiTaiKhoan})");
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateAccount(string TenHienThi, string TenDangNhap, int LoaiTaiKhoan)
        {
            string query = string.Format($"UPDATE dbo.TAIKHOAN SET TenHienThi = N'{TenHienThi}', LoaiTaiKhoan = {LoaiTaiKhoan} WHERE TenDangNhap = N'{TenDangNhap}'");
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteAccount(string TenDangNhap)
        {
            string query = string.Format($"Delete TAIKHOAN WHERE UserName = N'{TenDangNhap}'");
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }

    }
}
