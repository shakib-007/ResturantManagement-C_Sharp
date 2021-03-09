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
    public partial class FormHome : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\c sharp\Resturant\ResturantDB.mdf;Integrated Security=True;Connect Timeout=30");
        public FormHome()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormReservation formReservation = new FormReservation();
            formReservation.Show();
            this.Hide();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            FormOrder formOrder = new FormOrder();
            formOrder.Show();
            this.Hide();

        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
            FormEmployee formEmployee = new FormEmployee();
            formEmployee.Show();
            this.Hide();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }
    }
}
