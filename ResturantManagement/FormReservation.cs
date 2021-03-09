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
    public partial class FormReservation : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\c sharp\Resturant\ResturantDB.mdf;Integrated Security=True;Connect Timeout=30");
        public FormReservation()
        {
            InitializeComponent();
        }
        public void display()
        {
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Tables";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvTableInfo.DataSource = dt;



            sqlConnection.Close();
        }
        public void displayForReservation()
        {
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Reservation";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvReservation.DataSource = dt;



            sqlConnection.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormHome formHome = new FormHome();
            formHome.Show();
            this.Hide();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormReservation_Load(object sender, EventArgs e)
        {
            display();
            displayForReservation();
        }

        private void dgvReservation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Reservation values('" + txtReserveId.Text + "','" + txtTableId.Text + "','" + txtName.Text + "','" + txtPhoneNo.Text + "','" + date.Text + "','" + txtTime.Text + "','" + currDate.Text + "')";
            cmd.ExecuteNonQuery();

            sqlConnection.Close();
            displayForReservation();

            MessageBox.Show("Inserted successfully.");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Reservation where Re_ID= '" + txtReserveId.Text + "'";
            cmd.ExecuteNonQuery();

            sqlConnection.Close();
            displayForReservation();

            MessageBox.Show("Deleted successfully.");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            setDefault();
        }
        public void setDefault()
        {
            txtReserveId.Text = "";
            txtTableId.Text = "";
            txtName.Text = "";
            txtPhoneNo.Text = "";
            date.Text = System.DateTime.Now.ToString();
            txtTime.Text = "";
            currDate.Text = System.DateTime.Now.ToString();
           
        }

        private void time_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
