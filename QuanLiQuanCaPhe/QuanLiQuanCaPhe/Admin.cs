using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using QuanLiQuanCaPhe.DAO;

namespace QuanLiQuanCaPhe
{
    public partial class Admin : Form
    {
        BindingSource ListViewAccount = new BindingSource();
        BindingSource ListViewDrink = new BindingSource();
        BindingSource ListViewDiscount = new BindingSource();
        public Admin()
        {
            InitializeComponent();
            LoadListBillByDate(dateTimePickerFromDay.Value);

            dataGridViewAccount.DataSource = ListViewAccount;
            dataGridViewDrink.DataSource = ListViewDrink;
            dataGridViewDiscount.DataSource = ListViewDiscount;

            LoadAccount();
            LoadListDrink();
            LoadDiscount();

            AddDrinkBinding();
            AddAccountBinding();
            AddDiscountBinding();
        }
        void LoadAccount()
        {
            ListViewAccount.DataSource = AccountDAO.Instance.GetListAccount();
        }
        void LoadListDrink()
        {
            ListViewDrink.DataSource = FoodDAO.Instance.GetListDrink();
        }
        void LoadDiscount()
        {
            ListViewDiscount.DataSource = DiscountDAO.Instance.GetDiscountsList();
        }
        void LoadListBillByDate(DateTime checkIn)
        {
            dataGridViewBill.DataSource = BillDAO.Instance.GetBillListByDate(checkIn);
        }
        void AddAccountBinding()
        {
            textBoxDisplayName.DataBindings.Add(new Binding("Text", dataGridViewAccount.DataSource, "TenHienThi", true, DataSourceUpdateMode.Never));
            textBoxUserName.DataBindings.Add(new Binding("Text", dataGridViewAccount.DataSource, "TenDangNhap", true, DataSourceUpdateMode.Never));   
            textBoxAccountType.DataBindings.Add(new Binding("Text", dataGridViewAccount.DataSource, "LoaiTaiKhoan", true, DataSourceUpdateMode.Never));
        }
        void AddDrinkBinding()
        {
            textBoxID.DataBindings.Add(new Binding("Text", dataGridViewDrink.DataSource, "ID", true, DataSourceUpdateMode.Never));
            textBoxDrinkName.DataBindings.Add(new Binding("Text", dataGridViewDrink.DataSource,"Name", true, DataSourceUpdateMode.Never));
            numericUpDownPrice.DataBindings.Add(new Binding("Value", dataGridViewDrink.DataSource, "Price", true, DataSourceUpdateMode.Never));
            numericUpDownCategory.DataBindings.Add(new Binding ("Value", dataGridViewDrink.DataSource,"CategoryID", true, DataSourceUpdateMode.Never));
        }
        void AddDiscountBinding() 
        {
            textBoxDiscountCode.DataBindings.Add(new Binding("Text", dataGridViewDiscount.DataSource, "Magiam", true, DataSourceUpdateMode.Never)); ;
            numericUpDownDiscountValue.DataBindings.Add(new Binding("Value", dataGridViewDiscount.DataSource, "Mucgiam", true, DataSourceUpdateMode.Never));
        }



        void AddAccount(string TenHienThi, string TenDangNhap, int LoaiTaiKhoan)
        {
            if (AccountDAO.Instance.InsertAccount(TenHienThi, TenDangNhap, LoaiTaiKhoan))
            {
                MessageBox.Show("Added!");
            }
            else
            {
                MessageBox.Show("Failed!");
            }

            LoadAccount();
        }
        void EditAccount(string TenHienThi, string TenDangNhap, int LoaiTaiKhoan)
        {
            if (AccountDAO.Instance.UpdateAccount(TenHienThi, TenDangNhap, LoaiTaiKhoan))
            {
                MessageBox.Show("Updated!");
            }
            else
            {
                MessageBox.Show("Failed!");
            }
            LoadAccount();
        }
        void DeleteAccount(string TenDangNhap)
        {
            if (AccountDAO.Instance.DeleteAccount(TenDangNhap))
            {
                MessageBox.Show("Deleted!");
            }
            else
            {
                MessageBox.Show("Failed!");
            }

            LoadAccount();
        }
        void AddFood(string TenMon, int IDPhanLoai, float Gia)
        {
            if (FoodDAO.Instance.InsertFood(TenMon, IDPhanLoai, Gia))
            {
                MessageBox.Show("Added!");
            }
            else
            {
                MessageBox.Show("Failed!");
            }
            LoadListDrink();
        }
        void EditFood(string TenMon, float Gia)
        {
            if (FoodDAO.Instance.UpdateFood(TenMon, Gia))
            {
                MessageBox.Show("Updated!");
            }
            else
            {
                MessageBox.Show("Failed!");
            }

            LoadListDrink();
        }
        void DeleteFood(string TenMon)
        {
            if (FoodDAO.Instance.DeleteFood(TenMon))
            {
                MessageBox.Show("Deleted!");
            }
            else
            {
                MessageBox.Show("Failed!");
            }

            LoadListDrink();
        }
        void AddDiscount(string Magiam, int MucGiam)
        {
            if (DiscountDAO.Instance.InsertDiscount(Magiam,MucGiam))
            {
                MessageBox.Show("Added!");
            }
            else
            {
                MessageBox.Show("Failed!");
            }

            LoadDiscount();
        }
        void EditDiscount(string Magiam, int MucGiam)
        {
            if (DiscountDAO.Instance.UpdateDiscount(Magiam, MucGiam))
            {
                MessageBox.Show("Updated!");
            }
            else
            {
                MessageBox.Show("Failed!");
            }

            LoadDiscount();
        }
        void DeleteDiscount(string Magiam)
        {
            if (DiscountDAO.Instance.DeleteDiscount(Magiam))
            {
                MessageBox.Show("Deleted!");
            }
            else
            {
                MessageBox.Show("Failed!");
            }

            LoadDiscount();
        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tabPageDrink_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void buttonViewBill_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dateTimePickerFromDay.Value);
        }

        private void dateTimePickerFromDay_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonEditAccount_Click(object sender, EventArgs e)
        {
            string TenHienThi = textBoxDisplayName.Text;
            string TenDangNhap = textBoxUserName.Text;
            int LoaiTaiKhoan = 0;
            EditAccount(TenHienThi, TenDangNhap, LoaiTaiKhoan);
        }

        private void buttonAddAccount_Click(object sender, EventArgs e)
        {
            string TenHienThi = textBoxDisplayName.Text;
            string TenDangNhap = textBoxUserName.Text;
            int LoaiTaiKhoan = 0;
            AddAccount(TenHienThi,TenDangNhap,LoaiTaiKhoan);
        }

        private void buttonDeleteAccount_Click(object sender, EventArgs e)
        {
            string TenDangNhap = textBoxUserName.Text;
            DeleteAccount(TenDangNhap);
        }

        private void buttonViewAccount_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBoxAccountType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        

        private void buttonViewDis_Click(object sender, EventArgs e)
        {
            LoadDiscount();
        }
        private void buttonViewDrink_Click(object sender, EventArgs e)
        {
            LoadListDrink();
        }
        private void buttonAddDrink_Click(object sender, EventArgs e)
        {
            string TenMon = textBoxDrinkName.Text;
            int IDPhanLoai = (int)numericUpDownCategory.Value;
            float Gia = (float)numericUpDownPrice.Value;
            AddFood(TenMon, IDPhanLoai, Gia);
        }

        private void buttonEditDrink_Click(object sender, EventArgs e)
        {
            string TenMon = textBoxDrinkName.Text;
            float Gia = (float)numericUpDownPrice.Value;
            EditFood(TenMon, Gia);
        }

        private void buttonDeleteDrink_Click(object sender, EventArgs e)
        {
            string TenMon = textBoxDrinkName.Text;          
            DeleteFood(TenMon);
        }

        private void buttonEditDis_Click(object sender, EventArgs e)
        {
            string MaGiam = textBoxDiscountCode.Text;
            int MucGiam = (int)numericUpDownDiscountValue.Value;
            EditDiscount(MaGiam, MucGiam);
        }

        private void buttonAddDis_Click(object sender, EventArgs e)
        {
            string MaGiam = textBoxDiscountCode.Text;
            int MucGiam = (int)numericUpDownDiscountValue.Value;
            AddDiscount(MaGiam, MucGiam);
        }

        private void buttonDeleteDis_Click(object sender, EventArgs e)
        {
            string MaGiam = textBoxDiscountCode.Text;
            DeleteDiscount(MaGiam);
        }
    }
}
