using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

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
        private AccountDAO()
        {

        }

        public bool Login(string UserName, string PassWord)
            {
            string query = "USP_LOGIN @TenDangNhap , @MatKhau";

            DataTable result = DataProvider.Instance.ExcuteQuery(query, new object[] {UserName, PassWord});

            return result.Rows.Count > 0;
        }

    }
}
