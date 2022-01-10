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
        }


        #region Method

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
            List<BillInfo> listBillInfo = BillInfoDAO.Instance.GetListBillInfo(BillDAO.Instance.GetUncheckBillIDByTableID(id));     
            foreach (BillInfo item in listBillInfo)
            {
                ListViewItem lvItem = new ListViewItem(item.IDMonAn.ToString());
                lvItem.SubItems.Add(item.SoLuong.ToString());
                //lvItem.SubItems.Add(item.Gia.ToString());
                lvBill.Items.Add(lvItem);
            }

        }

        #endregion


        #region Events

        void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).SoBan;
            ShowBill(tableID);
        }



        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonalInformation f = new PersonalInformation(); 
            f.ShowDialog();
        }

        private void TableManager_Load(object sender, EventArgs e)
        {
           
        }

        private void qToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin f = new Admin();
            f.ShowDialog();
        }

        private void flpTable_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion
    }
}
 