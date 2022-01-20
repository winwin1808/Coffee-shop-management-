using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiQuanCaPhe.DTO
{
    public class Discount
    {
        public Discount(string MaGiam, int MucGiam)
        {
            this.MaGiam = MaGiam;
            this.Mucgiam = MucGiam;
        }
        public Discount(DataRow row)
        {
            this.MaGiam = row["MaGia"].ToString();
            this.MucGiam =(int)row["MucGiam"];
        }
        private string MaGiam;
        private int MucGiam;

        public int Mucgiam { get => MucGiam; set => MucGiam = value; }
        public string Magiam { get => MaGiam; set => MaGiam = value; }
    }
}
