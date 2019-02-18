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
    public partial class BookingsForm : Form
    {
        BookingsDbConn mysqlConn;
        public BookingsForm()
        {
            InitializeComponent();
            mysqlConn = new BookingsDbConn();
            mysqlConn.connect();
            if (mysqlConn.connOpen() == true)
            {
                dataGridView1.DataSource = mysqlConn.qry("SELECT * FROM `tblBooking`").Tables[0];
            }
            mysqlConn.connClose();
        }
        //Connects to the MySQL Database tblBooking.

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (mysqlConn.connOpen() == true)
            {
                mysqlConn.addBooking(tbBookingID.Text, tbCustomerID.Text, tbFlightID.Text, dtBookingDateTime.Text, tbBookingTotalCost.Text);
                dataGridView1.DataSource = mysqlConn.qry("SELECT * FROM `tblBooking`").Tables[0];
            }
            mysqlConn.connClose();
        }
        //Adds a booking to the database using the values entrered into the form and sends those details to the MySQL tblBooking database.

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (mysqlConn.connOpen() == true)
            {
                mysqlConn.updateBooking(tbBookingID.Text, tbCustomerID.Text, tbFlightID.Text, dtBookingDateTime.Text, tbBookingTotalCost.Text);
                dataGridView1.DataSource = mysqlConn.qry("SELECT * FROM `tblBooking`").Tables[0];
            }
            mysqlConn.connClose();
        }
        //Updates the booking details by using the values entrered into the form and sends those to the MySQL tblBooking database to update it.

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this record ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                if (mysqlConn.connOpen() == true)
                {
                    mysqlConn.deleteBooking(tbBookingID.Text);
                    dataGridView1.DataSource = mysqlConn.qry("SELECT * FROM `tblBooking`").Tables[0];
                }
                mysqlConn.connClose();
            }
        }
        //Deletes a booking by removing it from the MySQL tblBooking database.

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                tbBookingID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                tbCustomerID.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                tbFlightID.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                dtBookingDateTime.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                tbBookingTotalCost.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Closes the entire application.

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            Close();
            (new MainForm()).Show();
        }

        private void BookingsForm_Load(object sender, EventArgs e)
        {

        }
        //Closes the BookingsForm and opens the MainForm.
    }
}
