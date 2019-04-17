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
        //Inserts the details of a new sale into the SQL Database "Sales" table by adding sale details into the table.

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
        //Updates sale details in the SQL Database by replacing the existing sales details with the new sales details.

        public void deleteSale(string SalesID)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "DELETE FROM `Sales` WHERE `SalesID` = @SalesID";
            comm.Parameters.AddWithValue("@SalesID", SalesID);
            comm.ExecuteNonQuery();
            connClose();
        }
        //Deletes a sale by removing sales details from the database.

        public void viewtotalnetprofit()
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "SELECT FROM 'Sales' SUM(TotalCost)";
            comm.ExecuteNonQuery();
            connClose();
        }
        //Gets the total net profit by adding all the values in the 'TotalCost' column of the 'sales' table.
    }
}
