using QuanLiQuanCaPhe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiQuanCaPhe.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;

        public static FoodDAO Instance
        {
            get { if (instance == null) instance = new FoodDAO(); return FoodDAO.instance; }
            private set { FoodDAO.instance = value; }
        }

        private FoodDAO() { }

        public List<Food> GetFoodByCategoryID(int id)
        {
            List<Food> list = new List<Food>();

            string query = "SELECT * FROM MONAN WHERE IDPhanLoai = " + id;

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }

        public List<Food> GetListDrink()
        {
            List<Food> list = new List<Food>();

            string query = "SELECT * FROM MONAN";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }
        public bool InsertFood(string TenMon, int IDPhanLoai, float Gia)
        {
            string query = string.Format($"INSERT dbo.MONAN ( TenMon, IDPhanLoai, Gia ) VALUES  ( N'{TenMon}', {IDPhanLoai},{Gia})");
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateFood(string TenMon, float Gia)
        {
            string query = string.Format($"UPDATE dbo.MONAN SET Gia = {Gia} WHERE TenMon = N'{TenMon}'");
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteFood(string TenMon)
        {
            string query = string.Format($"Delete dbo.MONAN WHERE TenMon = N'{TenMon}'");
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
    }
}
