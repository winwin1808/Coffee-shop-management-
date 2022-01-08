using QuanLiQuanCaPhe.DAO;

namespace QuanLiQuanCaPhe
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void button_LOGIN_Click(object sender, EventArgs e)
        {
            string UserName = textbox_LOGIN.Text;
            string PassWord = textbox_PASSWORD.Text;    

            if (Login(UserName, PassWord))
            {
                TableManager f = new TableManager();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password!");
            }
           
        }

        bool Login(string UserName, string PassWord)
        {
            return AccountDAO.Instance.Login(UserName,PassWord);
        }


        private void LOGIN_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Exit now?", "Warning", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}