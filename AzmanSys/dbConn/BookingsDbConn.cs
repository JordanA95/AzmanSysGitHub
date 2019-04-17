using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzmanSys
{
    class BookingsDbConn : dbConn
    {
        public void addSale(String CustomerID, string DateOfSale, string Status, string TotalCost, string SalesID)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "UPDATE `Sales` SET `CustomerID`=@CustomerID,`DateOfSale`=@DateOfSale,`Status`=@Status, 'TotalCost'=@TotalCost WHERE SalesID=@SalesID";
            comm.Parameters.AddWithValue("@CustomerID", CustomerID);
            comm.Parameters.AddWithValue("@DateOfSale", DateOfSale);
            comm.Parameters.AddWithValue("@Status", Status);
            comm.Parameters.AddWithValue("@TotalCost", TotalCost);
            comm.Parameters.AddWithValue("@SalesID", SalesID);
            comm.ExecuteNonQuery();
            connClose();
        }
        //Inserts the details of a new booking into the SQL Database "tblBooking" by adding booking details into the table.

        public void updateSale(String CustomerID, string DateOfSale, string Status, string TotalCost, string SalesID)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "UPDATE `Sales` SET `CustomerID`=@CustomerID,`DateOfSale`=@DateofSale,`Status`=@Status,`TotalCost`=@TotalCost WHERE SalesID=@SalesID";
            comm.Parameters.AddWithValue("@CustomerID", CustomerID );
            comm.Parameters.AddWithValue("@DateOfSale", DateOfSale);
            comm.Parameters.AddWithValue("@Status", Status);
            comm.Parameters.AddWithValue("@TotalCost", TotalCost);
            comm.Parameters.AddWithValue("@SalesID", SalesID);
            comm.ExecuteNonQuery();
            connClose();
        }
        //Updates booking details in the SQL Database by replacing the existing booking details with the new booking details.

        public void deleteSale(string SalesID)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "DELETE FROM `Sales` WHERE `SalesID` = @SalesID";
            comm.Parameters.AddWithValue("@SalesID", SalesID);
            comm.ExecuteNonQuery();
            connClose();
        }
        //Deletes a booking by removing booking details from the database.
    }
}
