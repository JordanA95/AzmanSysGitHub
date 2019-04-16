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
        public void insertCustomer(string CustomerName, string CustomerTelNum, string CustomerAddress, string CustomerEmail)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "INSERT INTO `Customer` (`CustomerID`, `CustomerName`, `CustomerTelNum`, `CustomerAddress`, 'CustomerEmail') VALUES (NULL,@CustomerName, @CustomerTelNum, @CustomerAddress, @CustomerEmail);";
            comm.Parameters.AddWithValue("@CustomerName", CustomerName);
            comm.Parameters.AddWithValue("@CustomerTelNum", CustomerTelNum);
            comm.Parameters.AddWithValue("@CustomerAddress", CustomerAddress);
            comm.Parameters.AddWithValue("@CustomerEmail", CustomerEmail);
            comm.ExecuteNonQuery();
            connClose();
        }
        //Inserts the details of a new customer into the SQL Database "Customer" by adding customer details into the table.

        public void updateCustomer(string CustomerID, string CustomerName, string CustomerTelNum, string CustomerAddress, string CustomerEmail)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "UPDATE `Customer` SET CustomerName=@CustomerName, CustomerTelNum=@CustomerTelNum, CustomerAddress=@CustomerAddress, CustomerEmail=@CustomerEmail WHERE CustomerID=@CustomerID;";
            comm.Parameters.AddWithValue("@CustomerID", CustomerID);
            comm.Parameters.AddWithValue("@CustomerName", CustomerName);
            comm.Parameters.AddWithValue("@CustomerTelNum", CustomerTelNum);
            comm.Parameters.AddWithValue("@CustomerAddress", CustomerAddress);
            comm.Parameters.AddWithValue("@CustomerEmail", CustomerEmail);
            comm.ExecuteNonQuery();
            connClose();
        }
        //Updates customer details in the SQL Database by replacing the existing customer details with the new customer details.

        public void deleteCustomer(string CustomerID)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "DELETE FROM `Customer` WHERE CustomerID = @CustomerID";
            comm.Parameters.AddWithValue("@CustomerID", CustomerID);
            comm.ExecuteNonQuery();
            connClose();
        }
        //Deletes a customer by removing customer details from the database.
    }
}
