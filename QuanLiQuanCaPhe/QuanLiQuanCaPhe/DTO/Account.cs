using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiQuanCaPhe.DTO
{
    public class Account
    {
        public Account(string TenHienThi, string TenDangNhap, int LoaiTaiKhoan, string MatKhau = null)
        {
            this.DisplayName = TenHienThi;
            this.UserName    = TenDangNhap;
            this.Password = MatKhau;
            this.Type = LoaiTaiKhoan;
        }

        public Account(DataRow row)
        {
            this.UserName = row["TenDangNhap"].ToString();
            this.DisplayName = row["TenHienThi"].ToString();
            this.Password = row["MatKhau"].ToString();
            this.Type = (int)row["LoaiTaiKhoan"];
        }

        private int type;

        public int Type
        {
            get { return type; }
            set { type = value; }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private string displayName;

        public string DisplayName
        {
            get { return displayName; }
            set { displayName = value; }
        }

        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
    }
}
