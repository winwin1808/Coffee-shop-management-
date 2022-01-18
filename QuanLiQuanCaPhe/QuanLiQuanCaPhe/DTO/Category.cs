using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiQuanCaPhe.DAO
{
    public class Category
    {
        public Category(int id, string name)
        {
            this.id = id;  
            this.name = name;  
        }
        public Category(DataRow row)
        {
             this.id = (int)row["ID"];
            this.name = row["Loai"].ToString();

        }
        private string name;
        private int id;
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; } 
    }
}
