using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ResturantManagement
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\c sharp\Resturant\ResturantDB.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "Select * from Employee where Username='" + txtUsername.Text.Trim() +
                "' and Password='" + txtPassword.Text.Trim() + "' ";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                FormHome formHome = new FormHome();
                formHome.Show();
                this.Hide();
                //MessageBox.Show("Success.");
            }
            else
            {
                MessageBox.Show("Check your username and password");
            }
        }
    }
}
