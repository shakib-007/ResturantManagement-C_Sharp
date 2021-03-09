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
    public partial class FormOrder : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\c sharp\Resturant\ResturantDB.mdf;Integrated Security=True;Connect Timeout=30");

       
        public enum ItemName
        {
            None = 0,
            French_Fries = 1,
            Burger = 2,
            Pizza = 3,
            Fried_Rice = 4,
            Nachos = 5,
            Pasta = 6,
            Coca_Cola = 7,
            Water = 8,
            Brownie = 9,
            Cake = 10

        }
        public enum PriceList
        {
            None = 0,
            French_Fries = 80,
            Burger = 150,
            Pizza = 500,
            Fried_Rice = 120,
            Nachos = 130,
            Pasta = 160,
            Coca_Cola = 35,
            Water = 20,
            Brownie = 50,
            Cake = 100

        }
        public void display()
        {
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Order_List";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvOrder.DataSource = dt;



            sqlConnection.Close();
        }
        public FormOrder()
        {
            InitializeComponent();
            comboItem.DataSource = Enum.GetNames(typeof(ItemName));
            comboPrice.DataSource = Enum.GetValues(typeof(PriceList));
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

            txtOrderId.Text = "";
            txtItemId.Text = "";
            comboItem.SelectedItem = ItemName.None;
            comboPrice.SelectedItem = ItemName.None;
            txtTableId.Text = "";
            date.Text = System.DateTime.Now.ToString();
        }

        private void comboItem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Order_List values('" + txtOrderId.Text + "','" + txtItemId.Text + "','" + (string)comboItem.SelectedItem + "','" + (int)comboPrice.SelectedItem + "','" + txtTableId.Text + "','" + date.Text +  "')";
            cmd.ExecuteNonQuery();

            sqlConnection.Close();
            display();

            MessageBox.Show("Inserted successfully.");
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {
            display();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            //double price = Convert.ToDouble(ocRepo.GetPrice(this.cmbFoodName.Text));
            //int quantity = Convert.ToInt32(this.nudQuantity.Value);
            //this.txtPrice.Text = Convert.ToString(price * quantity);
            //var sql = "select Price From Order_List where Order_ID = @0";
            //MessageBox.Show(sql);
             string sql = "select sum(Price) as 'total' from Order_List where Order_ID = '" + txtOrderId.Text + "'";
            var dataTable = new DataTable("Order_List");
            //using (var sqlConnection = new SqlConnection("MyConnectionStringBlaBlaBla"))
           // {
                sqlConnection.Open();
                using (var sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection))
                {
                    sqlDataAdapter.Fill(dataTable);
                }
           // }
            MessageBox.Show("Total price is "+dataTable.Rows[0].ItemArray[0].ToString());

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Order_List where Order_ID= '" + txtOrderId.Text + "'";
            cmd.ExecuteNonQuery();

            sqlConnection.Close();
            display();

            MessageBox.Show("Deleted successfully.");
        }
    }
}
