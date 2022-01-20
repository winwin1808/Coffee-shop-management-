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
    }
}
