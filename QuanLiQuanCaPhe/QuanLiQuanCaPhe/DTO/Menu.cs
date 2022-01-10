using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiQuanCaPhe.DTO
{
    public class Menu
    {
        public Menu(string foodName, int count, float price, float totalPrice = 0)
        {
            this.TenMon = foodName;
            this.SoLuong = count;
            this.Gia = price;
            this.ThanhTien = totalPrice;
        }

        public Menu(DataRow row)
        {
            this.TenMon = row["TenMon"].ToString();
            this.SoLuong = (int)row["SoLuong"];
            this.Gia = (float)Convert.ToDouble(row["Gia"].ToString());
            this.ThanhTien = (float)Convert.ToDouble(row["ThanhTien"].ToString());
        }

        private float totalPrice;

        public float ThanhTien{ get { return totalPrice; } set { totalPrice = value; }}

        private float price;

        public float Gia { get { return price; }set { price = value; }}

        private int count;

        public int SoLuong { get { return count; } set { count = value; }}

        private string foodName;

        public string TenMon { get { return foodName; } set { foodName = value; }}
    }
}
