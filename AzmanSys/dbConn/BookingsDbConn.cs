﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzmanSys
{
    class BookingsDbConn : dbConn
    {
        public void addBooking(String BookinID, string CusID, string FlightID, string Booking_DateTime, string Total_BookingCost)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "UPDATE `tblBooking` SET `CusID`=@CusID,`FlightID`=@FlightID,`Booking_DateTime`=@Booking_DateTime,`Total_BookingCost`=@Total_BookingCost WHERE BookinID=@BookinID";
            comm.Parameters.AddWithValue("@CusID", CusID);
            comm.Parameters.AddWithValue("@FlightID", FlightID);
            comm.Parameters.AddWithValue("@Booking_DateTime", Booking_DateTime);
            comm.Parameters.AddWithValue("@Total_BookingCost", Total_BookingCost);
            comm.Parameters.AddWithValue("@BookinID", BookinID);
            comm.ExecuteNonQuery();
            connClose();
        }
        //Inserts the details of a new booking into the SQL Database "tblBooking" by adding booking details into the table.

        public void updateBooking(String BookinID, string CusID, string FlightID, string Booking_DateTime, string Total_BookingCost)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "UPDATE `tblBooking` SET `CusID`=@CusID,`FlightID`=@FlightID,`Booking_DateTime`=@Booking_DateTime,`Total_BookingCost`=@Total_BookingCost WHERE BookinID=@BookinID";
            comm.Parameters.AddWithValue("@CusID", CusID );
            comm.Parameters.AddWithValue("@FlightID", FlightID);
            comm.Parameters.AddWithValue("@Booking_DateTime", Booking_DateTime);
            comm.Parameters.AddWithValue("@Total_BookingCost", Total_BookingCost);
            comm.Parameters.AddWithValue("@BookinID", BookinID);
            comm.ExecuteNonQuery();
            connClose();
        }
        //Updates booking details in the SQL Database by replacing the existing booking details with the new booking details.

        public void deleteBooking(string BookinID)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "DELETE FROM `tblBooking` WHERE `BookinID` = @BookinID";
            comm.Parameters.AddWithValue("@BookinID", BookinID);
            comm.ExecuteNonQuery();
            connClose();
        }
        //Deletes a booking by removing booking details from the database.
    }
}
