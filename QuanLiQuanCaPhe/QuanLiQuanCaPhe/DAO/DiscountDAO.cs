using QuanLiQuanCaPhe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiQuanCaPhe.DAO
{
    public class DiscountDAO
    {
        private static DiscountDAO instance;
        public static DiscountDAO Instance

        {
            get { if (instance == null) instance = new DiscountDAO(); return instance; }
            private set { instance = value; }
        }
        private DiscountDAO()
        {

        }

        public int CheckDiscount(string MaGiam)
        {
            
            DataTable data = DataProvider.Instance.ExcuteQuery($"SELECT * FROM dbo.GIAMGIA WHERE MaGia = N'{MaGiam}'");

            if (data.Rows.Count > 0)
            {
                Discount bill = new Discount(data.Rows[0]);
                return bill.Mucgiam;
            }

            return 1;
            
        }
        public List<Discount> GetDiscountsList()
        {
            List<Discount> list = new List<Discount>();

            string query = "SELECT * FROM GIAMGIA";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Discount discount = new Discount(item);
                list.Add(discount);
            }

            return list;
        }
        public bool InsertDiscount(string Magiam, int MucGiam)
        {
            string query = string.Format($"INSERT dbo.GIAMGIA ( MaGia, MucGiam ) VALUES  ( N'{Magiam}',{MucGiam})");
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateDiscount(string Magiam, int MucGiam)
        {
            string query = string.Format($"UPDATE dbo.GIAMGIA SET MucGiam = {MucGiam} WHERE MaGiam = N'{Magiam}'");
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteDiscount(string Magiam)
        {
            string query = string.Format($"Delete dbo.GIAMGIA WHERE MaGia = N'{Magiam}'");
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
    } 
}
