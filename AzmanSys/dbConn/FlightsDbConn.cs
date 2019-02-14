using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzmanSys
{
    class FlightsDbConn : dbConn
    {
        public void insertFlight(string F_Depar_DateTime, string F_Arrival_DateTime, string F_Departure_City, string F_Arrival_City, string F_Price)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "INSERT INTO `tblFlight`(`FlightID`, `F_Depar_DateTime`, `F_Arrival_DateTime`, `F_Departure_City`, `F_Arrival_City`, `F_Price`) VALUES " +
                " (NULL, @F_Depar_DateTime, @F_Arrival_DateTime, @F_Departure_City, @F_Arrival_City, @F_Price);";
            comm.Parameters.AddWithValue("@F_Depar_DateTime", F_Depar_DateTime);
            comm.Parameters.AddWithValue("@F_Arrival_DateTime", F_Arrival_DateTime);
            comm.Parameters.AddWithValue("@F_Departure_City", F_Departure_City);
            comm.Parameters.AddWithValue("@F_Arrival_City", F_Arrival_City);
            comm.Parameters.AddWithValue("@F_Price", F_Price);
            comm.ExecuteNonQuery();
            connClose();
        }
        //Inserts a new flight into the SQL Database "tblFlight" by adding flight details into the table.

        public void updateFlight(String FlightID, string F_Depar_DateTime, string F_Arrival_DateTime, string F_Departure_City, string F_Arrival_City, string F_Price)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "UPDATE `tblFlight` SET `F_Depar_DateTime`=@F_Depar_DateTime,`F_Arrival_DateTime`=@F_Arrival_DateTime,`F_Departure_City`=@F_Departure_City," +
                "`F_Arrival_City`=@F_Arrival_City,`F_Price`=@F_Price WHERE FlightID = @FlightID";
            comm.Parameters.AddWithValue("@F_Depar_DateTime", F_Depar_DateTime);
            comm.Parameters.AddWithValue("@F_Arrival_DateTime", F_Arrival_DateTime);
            comm.Parameters.AddWithValue("@F_Departure_City", F_Departure_City);
            comm.Parameters.AddWithValue("@F_Arrival_City", F_Arrival_City);
            comm.Parameters.AddWithValue("@F_Price", F_Price);
            comm.Parameters.AddWithValue("@FlightID", FlightID);
            comm.ExecuteNonQuery();
            connClose();
        }
        //Updates a flight in the SQL Database by replacing the existing flight details with the new flight details.

        public void deleteFlight(string FlightID)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "DELETE FROM `tblFlight` WHERE FlightID = @FlightID";
            comm.Parameters.AddWithValue("@FlightID", FlightID);
            comm.ExecuteNonQuery();
            connClose();
        }
        //Deletes a flight by removing flight details from the SQL database.

        public void qry(string F_Departure_City, string F_Arrival_City)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "SEARCH `tblFlight`(`FlightID`, `F_Depar_DateTime`, `F_Arrival_DateTime`, `F_Departure_City`, `F_Arrival_City`, `F_Price`) VALUES " +
                " (NULL, @F_Depar_DateTime, @F_Arrival_DateTime, @F_Departure_City, @F_Arrival_City, @F_Price);";
            comm.Parameters.AddWithValue("@F_Departure_City", F_Departure_City);
            comm.Parameters.AddWithValue("@F_Arrival_City", F_Arrival_City);
            comm.ExecuteNonQuery();
            connClose();
        }
        //Searches the SQL database for flights matching the details the user has entered.
    }
}
