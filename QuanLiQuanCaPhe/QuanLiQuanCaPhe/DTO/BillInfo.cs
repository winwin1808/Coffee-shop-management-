using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiQuanCaPhe.DTO
{
    public class BillInfo
    {
        public BillInfo(int ID, int IDHoaDon, int IDMonAn, int SoLuong)
        {
            this.ID = ID;
            this.IDHoaDon = IDHoaDon;
            this.IDMonAn = IDMonAn;
            this.SoLuong = SoLuong;
        }

        public BillInfo(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.IDHoaDon = (int)row["IDHoaDon"];
            this.IDMonAn = (int)row["IDMonAn"];
            this.SoLuong = (int)row["SoLuong"];
        }

        private int count;

        public int SoLuong
        {
            get { return count; }
            set { count = value; }
        }

        private int foodID;

        public int IDMonAn
        {
            get { return foodID; }
            set { foodID = value; }
        }

        private int billID;

        public int IDHoaDon
        {
            get { return billID; }
            set { billID = value; }
        }

        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
    }
}
