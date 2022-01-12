using QuanLiQuanCaPhe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiQuanCaPhe.DAO
{
    public class MenuDAO
    {
        private static MenuDAO? instance;

        public static MenuDAO Instance
        {
            get { if (instance == null) instance = new MenuDAO(); return MenuDAO.instance; }
            private set { MenuDAO.instance = value; }
        }

        private MenuDAO() { }

        public List<Menu> GetListMenuByTable(int id)
        {
            List<Menu> listMenu = new List<Menu>();

            string query = $"SELECT MA.TenMon, TTHD.SoLuong, MA.Gia, TTHD.SoLuong*MA.Gia AS ThanhTien  FROM  dbo.THONGTINHOADON AS TTHD, dbo.HOADON AS HD, dbo.MONAN AS MA WHERE TTHD.IDHoaDon = HD.ID AND TTHD.IDMonAn = MA.ID AND HD.IDBan = {id}";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }

            return listMenu;

        }
    }
}
