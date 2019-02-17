using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            comm.ExecuteNonQuery();
            connClose();
        }
        //Inserts new login details into the SQL Database "tblUserLogin" by adding new username and password into the table.
        public void ValidateLogin(string CusUsername, string CusPassword)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "SELECT FROM 'tblUserLogin where CusUsername='"Usernametxb.text"' AND CusPassword='"Passwordtxb.text"'";
            logincheck = ExecuteReader();
            if(logincheck.read())
            {
                MessageBox.Show("Login sucessful");
            }
            else
            {
                MessageBox.Show("Invalid Login");
            }
            conn.Close();
        }
    }
}

    }
}
