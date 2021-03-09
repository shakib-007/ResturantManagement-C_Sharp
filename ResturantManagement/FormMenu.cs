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
    public partial class FormMenu : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\c sharp\Resturant\ResturantDB.mdf;Integrated Security=True;Connect Timeout=30");
        public FormMenu()
        {
            InitializeComponent();
        }
        public void display()
        {
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Menu";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvMenu.DataSource = dt;



            sqlConnection.Close();
        }
        public void searchData(string searchableText)
        {
            sqlConnection.Open();

            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Menu where Item_Name LIKE '" + searchableText + "%'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvMenu.DataSource = dt;

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
            txtItemId.Text = "";           
            txtName.Text = "";
            txtType.Text = "";
            txtPrice.Text = "";
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            display();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Menu values('" + txtItemId.Text + "','" + txtName.Text + "','" + txtType.Text + "','" + txtPrice.Text + "')";
            cmd.ExecuteNonQuery();

            sqlConnection.Close();
            display();

            MessageBox.Show("Inserted successfully.");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Menu where Item_ID= '" + txtItemId.Text + "'";
            cmd.ExecuteNonQuery();

            sqlConnection.Close();
            display();

            MessageBox.Show("Deleted successfully.");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Menu set  Item_Name='" + txtName.Text + "',Type='" + txtType.Text + "',Price='" + txtPrice.Text + "'  where Item_ID= '" + txtItemId.Text + "'";
            cmd.ExecuteNonQuery();

            sqlConnection.Close();
            display();

            MessageBox.Show("Updated successfully.");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            searchData(txtSearch.Text.Trim());
        }
    }
}
