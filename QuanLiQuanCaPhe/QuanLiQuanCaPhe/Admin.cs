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
        public Admin()
        {
            InitializeComponent();
            LoadListBillByDate(dateTimePickerFromDay.Value);

            dataGridViewAccount.DataSource = ListViewAccount;

            LoadAccount();
            AddAccountBinding();
        }
        void LoadAccount()
        {
            ListViewAccount.DataSource = AccountDAO.Instance.GetListAccount();
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
    }
}
