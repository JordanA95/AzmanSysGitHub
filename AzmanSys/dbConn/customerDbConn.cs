using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace AzmanSys
{
    class customerDbConn: dbConn
    {
        public void insertCustomer(string CusFName, string CusLName, string CusTelNum, string CusNationality)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "INSERT INTO `tblCustomer` (`CusID`, `CusFName`, `CusLName`, `CusTelNum`, 'CusNationality') VALUES (NULL,@CusFName, @CusLName, @CusTelNum, @CusNationality);";
            comm.Parameters.AddWithValue("@CusFName", CusFName);
            comm.Parameters.AddWithValue("@CusLName", CusLName);
            comm.Parameters.AddWithValue("@CusTelNum", CusTelNum);
            comm.Parameters.AddWithValue("@CusNationality", CusNationality);
            comm.ExecuteNonQuery();
            connClose();
        }
        //Inserts the details of a new customer into the SQL Database "tblCustomer" by adding customer details into the table.

        public void updateCustomer(string CusID, string FName, string LName, string TelNum, string CusNationality)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "UPDATE `tblCustomer` SET CusFName=@FName, CusLName=@LName, CusTelNum=@TelNum, CusNationality=@CusNationality WHERE CusID=@CusID;";
            comm.Parameters.AddWithValue("@CusID", CusID);
            comm.Parameters.AddWithValue("@FName", FName);
            comm.Parameters.AddWithValue("@LName", LName);
            comm.Parameters.AddWithValue("@TelNum", TelNum);
            comm.Parameters.AddWithValue("@CusNationality", CusNationality);
            comm.ExecuteNonQuery();
            connClose();
        }
        //Updates customer details in the SQL Database by replacing the existing customer details with the new customer details.

        public void deleteCustomer(string CusID)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "DELETE FROM `tblCustomer` WHERE CusID = @CusID";
            comm.Parameters.AddWithValue("@CusID", CusID);
            comm.ExecuteNonQuery();
            connClose();
        }
        //Deletes a customer by removing customer details from the database.
    }
}
