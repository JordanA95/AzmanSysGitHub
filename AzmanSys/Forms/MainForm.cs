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
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnManageCustomers_Click(object sender, EventArgs e)
        {
            Close(); // closes the current "MainForm" form
            CustomersForm custForm = new CustomersForm();
            custForm.Show();
        }

        private void btnManageFlights_Click(object sender, EventArgs e)
        {
            Close(); // closes the current "MainForm" form
            FlightsForm flightsForm = new FlightsForm();
            flightsForm.Show();
        }

        private void btnManageBookings_Click(object sender, EventArgs e)
        {
            Close(); // closes the current "MainForm" form
            BookingsForm bookingsForm = new BookingsForm();
            bookingsForm.Show();
          
        }

        private void ExitAzmanSys_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
