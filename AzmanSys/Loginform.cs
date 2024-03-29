﻿using System;
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
    public partial class Loginform : Form
    {
        LoginDbConn mysqlConn;
        public Loginform()
        {
            InitializeComponent();
            mysqlConn = new LoginDbConn();
            mysqlConn.connect();
        }

        private void Signinbtn_Click(object sender, EventArgs e)
        {
            if (Usernametxb.Text =="")
            {
                MessageBox.Show("Please enter a valid username");
                Usernametxb.Focus();
            } else if(passwordtxb.Text == "")
            {
                MessageBox.Show("Password Incorrect");
                passwordtxb.Focus();
            }
            if(Usernametxb.Text != "" & passwordtxb.Text != "") //!= is checking that the textbox is NOT empty
            {
                int t = 0;
                string query = "SELECT count(*) FROM `UserLogin` WHERE Username ='"+Usernametxb.Text+"' AND Password ='" +passwordtxb.Text+"'";
                MySqlDataAdapter records = new MySqlDataAdapter(query, mysqlConn.conn);
                DataTable table = new DataTable();
                records.Fill(table);
                t = Convert.ToInt32(table.Rows[0][0].ToString());
                if(t == 1) //Is checking the login details are correct.
                {
                    MessageBox.Show("Login Successful"); //Login successful message
                    Close();
                    (new MainForm()).Show();
                } else
                {
                    MessageBox.Show("Incorrect Username or Password"); //Login unsuccessful message
                }

            }
        }

        private void Usernametxb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
