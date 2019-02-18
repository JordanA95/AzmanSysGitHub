using MySql.Data.MySqlClient;
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
    class LoginDbConn : dbConn
    {



        public void insertNewUser(string CusUsername, string CusPassword)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "INSERT INTO `tblUserLogin`(`CusUsername`, `CusPassword') VALUES " +
                " (@CusUsername, @CusPassword);";
            comm.Parameters.AddWithValue("@CusUsername", CusUsername);
            comm.Parameters.AddWithValue("@CusPassword", CusPassword);
            connClose();
        }
        //Inserts new login details into the SQL Database "tblUserLogin" by adding new username and password into the table.

        public void ValidateLogin(string CusUsername, string CusPassword)
        {
           MySqlCommand comm = conn.CreateCommand();
                comm.CommandText = "SELECT*FROM tblUserLogin where CusUsername=@CusUsername AND CusPassword=@CusPassword";
                comm.Parameters.AddWithValue("@CusUsername", CusUsername);
                comm.Parameters.AddWithValue("@CusPassword", CusPassword);
                MessageBox.Show("Login sucessful");
                comm.ExecuteNonQuery(); 
                connClose();
            /*if (dr.read())
            {
                MessageBox.Show("Login sucessful");
            }
            else
            {
                MessageBox.Show("Invalid Login");
            }*/
            
        }
    }
}
