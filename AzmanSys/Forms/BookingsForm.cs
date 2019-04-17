using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
        //Connects to the MySQL Database Sales.

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbCustomerID.Text == "")
            {
                MessageBox.Show("Please enter the Customer ID");
            }
            else if (tbFlightID.Text == "")
            {
                MessageBox.Show("Please enter the Sales Status");
            }
            else if (tbBookingTotalCost.Text == "")
            {
                MessageBox.Show("Please enter the total cost of the sale");
            }
            if (tbCustomerID.Text != "" & tbFlightID.Text != "" & tbBookingTotalCost.Text != "") //!= is checking that the textboxes are NOT empty
                if (mysqlConn.connOpen() == true)
            {
                mysqlConn.addSale(tbBookingID.Text, tbCustomerID.Text, tbFlightID.Text, dtBookingDateTime.Text, tbBookingTotalCost.Text);
                dataGridView1.DataSource = mysqlConn.qry("SELECT * FROM `Sales`").Tables[0];
            }
            mysqlConn.connClose();
        }
        //Adds a sale to the database using the values entrered into the form with form validation and sends those details to the MySQL 'Sales' table in the database.

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbCustomerID.Text == "")
            {
                MessageBox.Show("Please enter the Customer ID");
            }
            else if (tbFlightID.Text == "")
            {
                MessageBox.Show("Please enter the Flight ID");
            }
            else if (tbBookingTotalCost.Text == "")
            {
                MessageBox.Show("Please enter the total cost of the booking");
            }
            if (tbCustomerID.Text != "" & tbFlightID.Text != "" & tbBookingTotalCost.Text != "") //!= is checking that the textboxes are NOT empty
                if (mysqlConn.connOpen() == true)
            {
                mysqlConn.updateSale(tbBookingID.Text, tbCustomerID.Text, tbFlightID.Text, dtBookingDateTime.Text, tbBookingTotalCost.Text);
                dataGridView1.DataSource = mysqlConn.qry("SELECT * FROM `Sales`").Tables[0];
            }
            mysqlConn.connClose();
        }
        //Updates the sales details by using the values entrered into the form with form validation and sends those to the MySQL table 'Sales' database to update it.

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this record ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                if (mysqlConn.connOpen() == true)
                {
                    mysqlConn.deleteSale(tbBookingID.Text);
                    dataGridView1.DataSource = mysqlConn.qry("SELECT * FROM `Sales`").Tables[0];
                }
                mysqlConn.connClose();
            }
        }
        //Deletes the selected sale by removing it from the MySQL 'Sales' table database with confirmation message.

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
        //Converts the value of the selected data to string

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
        //Closes the BookingsForm and opens the MainForm.

        private void BookingsForm_Load(object sender, EventArgs e)
        {

        }

        private void printbookingsbtn_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            printDocument1.Print();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
        }
        
        Bitmap memoryImage;

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }
        //Captures the screen to print the form.

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void viewnetprofitbtn_Click(object sender, EventArgs e)
        {
            if (mysqlConn.connOpen() == true)
            {
                mysqlConn.viewtotalnetprofit();
                dataGridView1.DataSource = mysqlConn.qry("SELECT * FROM `Sales`").Tables[0];
            }
            mysqlConn.connClose();
        }
    }
}
