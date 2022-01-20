using QuanLiQuanCaPhe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiQuanCaPhe.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }

        private BillDAO() { }

        public int GetUncheckBillIDByTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery($"SELECT * FROM dbo.HOADON WHERE IDBan = {id} AND TrangThai = 0");

            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }

            return -1;
        }

        public void InsertBill(int id)
        {
            DataProvider.Instance.ExcuteNonQuery("EXEC USP_InsertBill @IDBan", new object[] { id });
        }
        public int GetMaxIDBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(ID) FROM dbo.HOADON");
            }
            catch
            {
                return 1;
            }
        }
         public void CheckOut(int id, string MaGiam, float TongTien)
        {
            string query = $"UPDATE dbo.HOADON SET TrangThai = 1, GiamGia = N'{MaGiam}', TongTien = {TongTien} WHERE ID = {id}";
            DataProvider.Instance.ExcuteNonQuery(query);
        }

        public DataTable GetBillListByDate(DateTime checkIn)
        {
            return DataProvider.Instance.ExcuteQuery("exec USP_GetListBillByDate @NgayVao", new object[] { checkIn });
        }

    }    
}
