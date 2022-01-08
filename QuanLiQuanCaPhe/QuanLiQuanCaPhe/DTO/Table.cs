using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiQuanCaPhe.DTO
{
    public class Table
    {
        public Table(int soban, string tenban, string trangthai)
        {
            this.SoBan = soban;
            this.TenBan = tenban;
            this.TrangThai = trangthai;
        }

        public Table(DataRow row)
        {
            this.SoBan = (int)row["SoBan"];
            this.TenBan = row["TenBan"].ToString();
            this.TrangThai = row["TrangThai"].ToString();
        }

        private string status;

        public string TrangThai
        {
            get { return status; }
            set { status = value; }
        }

        private string name;

        public string TenBan
        {
            get { return name; }
            set { name = value; }
        }

        private int iD;

        public int SoBan
        {
            get { return iD; }
            set { iD = value; }
        }
    }
}
