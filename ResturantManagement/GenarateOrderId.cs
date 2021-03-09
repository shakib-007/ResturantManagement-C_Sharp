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
    public partial class FormOrderId : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\c sharp\Resturant\ResturantDB.mdf;Integrated Security=True;Connect Timeout=30");

        public FormOrderId()
        {
            InitializeComponent();
        }
        public void display()
        {
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Order";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvOrderDetail.DataSource = dt;



            sqlConnection.Close();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            FormHome formHome = new FormHome();
            formHome.Show();
            this.Hide();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            setDefault();
        }
        public void setDefault()
        {
            txtTableId.Text = "";                  
            currDate.Text = System.DateTime.Now.ToString();

        }
        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Order values('" + txtTableId.Text + "','" + currDate.Text + "')";
            cmd.ExecuteNonQuery();

            sqlConnection.Close();
            display();

            MessageBox.Show("Inserted successfully.");
        }

        private void FormOrderId_Load(object sender, EventArgs e)
        {
            display();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            FormOrder formOrder = new FormOrder();
            formOrder.Show();
            this.Hide();
        }

        private void dgvOrderDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
