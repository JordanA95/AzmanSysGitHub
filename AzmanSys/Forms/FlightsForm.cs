using System;
using MySql.Data.MySqlClient;
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
    public partial class FlightsForm : Form
    {
        FlightsDbConn mysqlConn;
        public FlightsForm()
        {
            InitializeComponent();
            mysqlConn = new FlightsDbConn();
            mysqlConn.connect();
            if (mysqlConn.connOpen() == true)
            {
                dataGridView1.DataSource = mysqlConn.qry("SELECT * FROM `tblFlight`").Tables[0];
            }
            mysqlConn.connClose();
        }
        //Connects to the MySQL database tblflight.

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbPrice.Text == "")
            {
                MessageBox.Show("Please enter the ticket price");
            } else if (tbDepartureCity.Text=="")
            {
                MessageBox.Show("Please enter a departure city");
            } else if (tbArrivalCity.Text=="")
            {
                MessageBox.Show("Please enter an arrival city");
            }
            if (tbPrice.Text != "" & tbDepartureCity.Text != "" & tbArrivalCity.Text != "") //!= is checking that the textboxes are NOT empty 
                if (mysqlConn.connOpen() == true)
            {
                mysqlConn.insertFlight(dtDepartureDateTime.Text,dtArrivalDateTime.Text,tbDepartureCity.Text,tbArrivalCity.Text,tbPrice.Text);
                dataGridView1.DataSource = mysqlConn.qry("SELECT * FROM `tblFlight`").Tables[0];
            }
            mysqlConn.connClose();
        }
        //Adds a flight to the database using the values entrered into the form and sends those details to the MySQL tblFlight database.

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbPrice.Text == "")
            {
                MessageBox.Show("Please enter the ticket price");
            }
            else if (tbDepartureCity.Text == "")
            {
                MessageBox.Show("Please enter a departure city");
            }
            else if (tbArrivalCity.Text == "")
            {
                MessageBox.Show("Please enter an arrival city");
            }
            if (tbPrice.Text != "" & tbDepartureCity.Text != "" & tbArrivalCity.Text != "") //!= is checking that the textboxes are NOT empty 
                if (mysqlConn.connOpen() == true)
            {
                mysqlConn.updateFlight(tbFlightID.Text, dtDepartureDateTime.Text, dtArrivalDateTime.Text, tbDepartureCity.Text, tbArrivalCity.Text, tbPrice.Text);
                dataGridView1.DataSource = mysqlConn.qry("SELECT * FROM `tblFlight`").Tables[0];
            }
            mysqlConn.connClose();
        }
        //Updates the flight details by using the values entrered into the form and sends those to the MySQL tblFlight database to update it.

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this record ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                if (mysqlConn.connOpen() == true)
                {
                    mysqlConn.deleteFlight(tbFlightID.Text);
                    dataGridView1.DataSource = mysqlConn.qry("SELECT * FROM `tblFlight`").Tables[0];
                }
                mysqlConn.connClose();
            }
        }
        //Deletes a flight by removing it from the MySQL tblFlight database.

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                tbFlightID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                dtDepartureDateTime.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                dtArrivalDateTime.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                tbDepartureCity.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                tbArrivalCity.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                tbPrice.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            Close();
            (new MainForm()).Show();
        }
        //Closes the FlightsForm and opens the MainForm.

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Closes the entire application.

        private void btnMainMenu_Click_1(object sender, EventArgs e)
        {
            Close();
            (new MainForm()).Show();
        }

        private void Searchflightbtn_Click(object sender, EventArgs e)
        {
            if (mysqlConn.connOpen() == true)
            {
                dataGridView1.DataSource = mysqlConn.qry("SELECT * FROM `tblFlight` where F_Departure_City='" + tbDepartureCity.Text + "' Or F_Arrival_City='" + tbArrivalCity.Text + "'").Tables[0];
            }
            mysqlConn.connClose();
        }

        private void flightsearchtxb_TextChanged(object sender, EventArgs e)
        {
            string search = flightsearchtxb.Text;
            string filterData = search.ToString();

            string query = "SELECT *  FROM `tblFlight` WHERE CONCAT( `FlightID`, `F_Depar_DateTime`, `F_Arrival_DateTime`, `F_Departure_City`, `F_Arrival_City`, `F_Price` ) like '%" + filterData +"%'";
            MySqlDataAdapter records = new MySqlDataAdapter(query, mysqlConn.conn);
            DataTable table = new DataTable();
            records.Fill(table);
            dataGridView1.DataSource = table;
        }
        //Searches the MySQL tblFlight database for flights matching the departure city and arrival city entered.

        private void tbPrice_TextChanged(object sender, EventArgs e)
        {
            int Priceforadult = int.Parse(tbPrice.Text);
            int Priceforchild = Priceforadult / 100 * 80;
            int Priceforinfant = Priceforadult / 100 * 70;
        }

        private void calculatepricesbtn_Click(object sender, EventArgs e)
        {
            int Priceforadult = int.Parse(tbPrice.Text);
            int Priceforchild = Priceforadult / 100 * 80;
            int Priceforinfant = Priceforadult / 100 * 70;
            string adultprice = Priceforadult.ToString();
            string childprice = Priceforchild.ToString();
            string infantprice = Priceforinfant.ToString();
            adultpricelbl.Text = adultprice;
            childpricelbl.Text = childprice;
            infantpricelbl.Text = infantprice;
        }
        //When the adult ticket cost is typed into the tbPrice textbox, the cost for child and infant is calculated.
    }
}
