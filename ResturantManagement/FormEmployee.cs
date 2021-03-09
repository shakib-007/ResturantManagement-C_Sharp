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
    public partial class FormEmployee : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\c sharp\Resturant\ResturantDB.mdf;Integrated Security=True;Connect Timeout=30");
        public FormEmployee()
        {
            InitializeComponent();
        }
        public void display()
        {
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Employee";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvEmployee.DataSource = dt;



            sqlConnection.Close();
        }
        public void searchData(string searchableText)
        {
            sqlConnection.Open();

            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Employee where Emp_Name LIKE '" + searchableText + "%'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvEmployee.DataSource = dt;

            sqlConnection.Close();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            FormHome formHome = new FormHome();
            formHome.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            setDefault();
        }
        public void setDefault()
        {
            txtEmpId.Text = "";
            txtType.Text = "";
            txtName.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtSalary.Text = "";
            txtPhoneNo.Text = "";
            txtAddress.Text = "";
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Employee values('" + txtEmpId.Text + "','" + txtType.Text + "','" + txtName.Text + "','" + txtUsername.Text + "','" + txtPassword.Text + "','" + txtSalary.Text + "','" + txtPhoneNo.Text + "','" + txtAddress.Text + "')";
            cmd.ExecuteNonQuery();

            sqlConnection.Close();
            display();

            MessageBox.Show("Inserted successfully.");
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            display();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Employee where Emp_ID= '" + txtEmpId.Text + "'";
            cmd.ExecuteNonQuery();

            sqlConnection.Close();
            display();

            MessageBox.Show("Deleted successfully.");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //sqlConnection.Open();
            //SqlCommand cmd = sqlConnection.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "update Employee set Type='" + txtType.Text + "',Emp_Name='" + txtName.Text + "',Username='" + txtUsername.Text + "',Password='" + txtPassword.Text + "',Salary='" + txtSalary.Text + "',Contact_No.='" + txtPhoneNo.Text + "',Address='" + txtAddress.Text + "'  where Emp_ID= '" + txtEmpId.Text + "'";
            //cmd.ExecuteNonQuery();

            //sqlConnection.Close();
            //display();

            //MessageBox.Show("Updated successfully.");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            searchData(txtSearch.Text.Trim());
        }
    }
}
