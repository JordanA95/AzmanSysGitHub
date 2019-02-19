using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzmanSys
{
    public partial class MainForm : Form
    {
        LoginDbConn mysqlConn;
        public MainForm()
        {
            InitializeComponent();
            mysqlConn = new LoginDbConn();
            mysqlConn.connect();
            if (mysqlConn.connOpen() == true)
            mysqlConn.connClose();
        }
        //Connects to the MySQL database tblUserLogin.

        private void btnManageCustomers_Click(object sender, EventArgs e)
        {
            Close(); // closes the current "MainForm" form
            CustomersForm custForm = new CustomersForm();
            custForm.Show(); //Opens the customer form
        }

        private void btnManageFlights_Click(object sender, EventArgs e)
        {
            Close(); // closes the current "MainForm" form
            FlightsForm flightsForm = new FlightsForm();
            flightsForm.Show(); //Opens the flights form
        }

        private void btnManageBookings_Click(object sender, EventArgs e)
        {
            Close(); // closes the current "MainForm" form
            BookingsForm bookingsForm = new BookingsForm();
            bookingsForm.Show(); //Opens the bookings form
          
        }

        private void ExitAzmanSys_Click(object sender, EventArgs e)
        {
            Application.Exit(); //closes the whole application
        }
    }
}