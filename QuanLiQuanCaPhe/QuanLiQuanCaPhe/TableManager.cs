using QuanLiQuanCaPhe.DAO;
using QuanLiQuanCaPhe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiQuanCaPhe
{
    public partial class TableManager : Form
    {
        public TableManager()
        {
            InitializeComponent();
            LoadTable();
            LoadCategory();
        }


        #region Method
        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "Name";
        }
        void LoadFoodListByCateID(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id);
            cbDrink.DataSource = listFood;
            cbDrink.DisplayMember = "Name";
        }
        void LoadTable()
        {
            List<Table> tablelist = DAO.TableDAO.Instance.LoadTableList();
            foreach (Table item in tablelist)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.TenBan + "\n" + item.TrangThai;
                btn.Click += btn_Click;
                btn.Tag = item;

                switch (item.TrangThai)
                {
                    case "Available":
                        btn.BackColor = Color.LightBlue;
                        break;
                    default:
                        btn.BackColor = Color.DarkGray;
                        break;
                }

                flpTable.Controls.Add(btn);
            }
        }

        void ShowBill(int id)
        {
            lvBill.Items.Clear();
            List<Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            float totalPrice = 0;

            foreach (Menu item in listBillInfo)
            {
                ListViewItem lvItem = new ListViewItem(item.TenMon.ToString());
                lvItem.SubItems.Add(item.SoLuong.ToString());
                lvItem.SubItems.Add(item.Gia.ToString());
                lvItem.SubItems.Add(item.ThanhTien.ToString());
                totalPrice += item.ThanhTien;   
                lvBill.Items.Add(lvItem);
       
            }
            if ( totalPrice != 0)
            {
                ListViewItem lvTotal = new ListViewItem("TOTAL");
                lvTotal.SubItems.Add("");
                lvTotal.SubItems.Add("");
                lvTotal.SubItems.Add(totalPrice.ToString());
                Font f = new Font(lvTotal.Font, FontStyle.Bold);
                lvTotal.Font = f;
                lvBill.Items.Add(lvTotal);
            }
            
        }

        #endregion


        #region Events

        void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).SoBan;
            lvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }


        private void TableManager_Load(object sender, EventArgs e)
        {
           
        }

        private void qToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void flpTable_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion

        private void lvBill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void personalInfomationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonalInformation f = new PersonalInformation();
            f.ShowDialog();

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Admin f = new Admin();
            f.ShowDialog();
        }

        private void cbCategoryChange(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            Category selected = cb.SelectedItem as Category;
            id = selected.Id;

            LoadFoodListByCateID(id);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Table table = lvBill.Tag as Table;

            if (table == null)
            {
                MessageBox.Show("Pick a tag");
                return;
            }

            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.SoBan);
            int foodID = (cbDrink.SelectedItem as Food).ID;
            int count = (int)nmNum.Value;

            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.SoBan);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), foodID, count);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, foodID, count);
            }


            ShowBill(table.SoBan);

            LoadTable();
        }

        private void btBill_Click(object sender, EventArgs e)
        {
            Table table = lvBill.Tag as Table;

            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.SoBan);

            if (idBill != -1)
            {
                if (MessageBox.Show($"Confirm {table.TenBan}?", "Nofication", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idBill);
                    ShowBill(table.SoBan);
                }
            }
        }
    }
}
 