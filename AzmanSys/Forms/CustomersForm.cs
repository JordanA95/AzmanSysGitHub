﻿using System;
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
    public partial class CustomersForm : Form
    {
        customerDbConn mysqlConn;
        public CustomersForm()
        {
            InitializeComponent();
            mysqlConn = new customerDbConn();
            mysqlConn.connect();
            if (mysqlConn.connOpen() == true)
            {
                dataGridView1.DataSource = mysqlConn.qry("SELECT * FROM `Customer`").Tables[0];
            }
            mysqlConn.connClose();
        }
        //This is the code conecting the CustomerForm to the Customer SQL Database

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbFName.Text == "")
            {
                MessageBox.Show("Please enter the customer's first name");
            }
            else if (tbLName.Text == "")
            {
                MessageBox.Show("Please enter the customer's address");
            }
            else if (tbTel.Text == "")
            {
                MessageBox.Show("Please enter the customer's telephone number");
            }
            else if (tbNationality.Text == "")
            {
                MessageBox.Show("Please enter the customer's email");
            }
            if (tbFName.Text != "" & tbLName.Text != "" & tbTel.Text != "" & tbNationality.Text !="") //!= is checking that the textboxes are NOT empty
                if (mysqlConn.connOpen() == true)
            {
                mysqlConn.insertCustomer(tbFName.Text, tbLName.Text, tbTel.Text, tbNationality.Text);
                dataGridView1.DataSource = mysqlConn.qry("SELECT * FROM `Customer`").Tables[0];
            }
            mysqlConn.connClose();
        }
        //This is the code for adding a new customer to the tblCustomer table.

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            { 
            tbCustID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            tbFName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            tbLName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            tbTel.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            }
        }
        //This converts the value of the selected row in the Customers grid to a string value

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbFName.Text == "")
            {
                MessageBox.Show("Please enter the customer's first name");
            }
            else if (tbLName.Text == "")
            {
                MessageBox.Show("Please enter the customer's address");
            }
            else if (tbTel.Text == "")
            {
                MessageBox.Show("Please enter the customer's telephone number");
            }
            else if (tbNationality.Text =="")
            {
                MessageBox.Show("Please enter the customer's email");
            }
            if (tbFName.Text != "" & tbLName.Text != "" & tbTel.Text != "" & tbNationality.Text != "") //!= is checking that the textboxes are NOT empty
                if (mysqlConn.connOpen() == true)
            {
                mysqlConn.updateCustomer(tbCustID.Text, tbFName.Text, tbLName.Text, tbTel.Text, tbNationality.Text);
                dataGridView1.DataSource = mysqlConn.qry("SELECT * FROM `Customer`").Tables[0];
            }
            mysqlConn.connClose();
        }
        //This is the code for updating the customer details with form validation and then inserting the new details into the tbl Customer table.

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this record ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                if (mysqlConn.connOpen() == true)
                {
                    mysqlConn.deleteCustomer(tbCustID.Text);
                    dataGridView1.DataSource = mysqlConn.qry("SELECT * FROM `Customer`").Tables[0];
                }
                mysqlConn.connClose();
            }
        }
        //This is the code for deleting the cutomer details from the table with an alert message confirming that the user wants to delete the data.

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            Close();
            (new MainForm()).Show();
        }
        //This is the code for returning to the main menu by closing the CustomersForm and opening the MainForm.

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //This is the code for closing the whole application.

        private void btnMainMenu_Click_1(object sender, EventArgs e)
        {
            Close();
            (new MainForm()).Show();
        }

        private void printcustomersbtn_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            printDocument1.Print();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
        }
        //This is the code for printing the Customer Form
        Bitmap memoryImage;

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }
        //This is the code for capturing what is on the screen/form for printing

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }
    }
}
