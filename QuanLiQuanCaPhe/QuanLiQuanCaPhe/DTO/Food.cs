using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiQuanCaPhe.DTO
{
    public class Food
    {
        public Food(int id, string name, int categoryID, float price)
        {
            this.ID = id;
            this.Name = name;
            this.CategoryID = categoryID;
            this.Price = price;
        }
        public Food(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.Name = row["TenMon"].ToString();
            this.CategoryID = (int)row["IDPhanLoai"];
            this.Price = (float)Convert.ToDouble(row["Gia"].ToString());
        }
        private float price;
        private int categoryID;
        private string name;
        private int iD;
        public float Price { get => price; set => price = value; }
        public int CategoryID { get => categoryID; set => categoryID = value; }
        public string Name { get => name; set => name = value; }
        public int ID { get => iD; set => iD = value; }
    }
}
