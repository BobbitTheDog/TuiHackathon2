﻿using System;
using System.Collections.Generic;
using System.Linq;

using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;

namespace HackathonFramework
{
    public static class SqlTasks
    {
        private static MySqlConnection Conn => new MySqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);

        public static List<Port> GetAllPorts()
        {
            using (var conn = Conn)
            using (var cmd = new MySqlCommand(SqlStrings.Port_ListNameAndID, conn))
            using (var da = new MySqlDataAdapter(cmd))
            using (var data = new DataTable())
            {
                da.Fill(data);
                return data.AsEnumerable().Select(row => new Port(row["PortID"].ToString(), row["Name"].ToString())).ToList();
            }
        }

        public static IEnumerable<Excursion> GetExcursionsForCruise(string cruiseID)
        {
            using (var conn = Conn)
            using (var cmd = new MySqlCommand(SqlStrings.Excursion_ListByCruiseID, conn))
            using (var da = new MySqlDataAdapter(cmd))
            using (var data = new DataTable())
            {
                cmd.Parameters.AddWithValue("@cruiseID", cruiseID);
                da.Fill(data);
                return data.AsEnumerable().Select(row => new Excursion(row["ExcursionID"].ToString(), row["PortID"].ToString(),row["Name"].ToString(), (int)row["NumCoaches"])).ToList();
            }
        }

        internal static List<PortOfCall> GetPortsOfCall(string itineraryID)
        {
            using (var conn = Conn)
            using (var cmd = new MySqlCommand(SqlStrings.PortOfCall_ListByItineraryID, conn))
            using (var da = new MySqlDataAdapter(cmd))
            using (var data = new DataTable())
            {
                cmd.Parameters.AddWithValue("@itineraryID", itineraryID);

                da.Fill(data);
                return data.AsEnumerable().Select(row => new PortOfCall(row["PortOfCallID"].ToString(), row["ItineraryID"].ToString(), new HackathonFramework.Port(row["PortID"].ToString(), row["Name"].ToString()))).ToList();
            }
        }

        public static List<Itinerary> GetAllItineraries()
        {
            using (var conn = Conn)
            using (var cmd = new MySqlCommand(SqlStrings.Itinerary_ListAll, conn))
            using (var da = new MySqlDataAdapter(cmd))
            using (var data = new DataTable())
            {
                da.Fill(data);

                return data.AsEnumerable().Select(row => new Itinerary(row["ItineraryID"].ToString(), row["Name"].ToString())).ToList();
            }
        }

        public static IEnumerable<Excursion> GetAllExcursions()
        {
            using (var conn = Conn)
            using (var cmd = new MySqlCommand(SqlStrings.Excursion_ListAll, conn))
            using (var da = new MySqlDataAdapter(cmd))
            using (var data = new DataTable())
            {
                da.Fill(data);
                return data.AsEnumerable().Select(row => new Excursion(row["ExcursionID"].ToString(), row["PortID"].ToString(), row["Name"].ToString(), (int)row["NumCoaches"])).ToList();
            }
        }

        public static List<Ship> GetAllShips(bool loadItinerary = true)
        {
            using (var conn = Conn)
            using (var cmd = new MySqlCommand(SqlStrings.Ship_ListNameAndID, conn))
            using (var da = new MySqlDataAdapter(cmd))
            using (var data = new DataTable())
            {
                da.Fill(data);
                var allShips = new List<Ship>();
                foreach (DataRow row in data.Rows.OfType<DataRow>())
                {
                    var ship = new Ship(row["ShipID"].ToString(), row["Name"].ToString());
                    if (loadItinerary) ship.LoadItinerary();

                    allShips.Add(ship);
                }

                return allShips;
            }
        }

        public static IEnumerable<Port> GetDestinationPorts(string shipID)
        {
            using (var conn = Conn)
            using (var cmd = new MySqlCommand(SqlStrings.PortOfCall_ListByItineraryID, conn))
            using (var da = new MySqlDataAdapter(cmd))
            using (var data = new DataTable())
            {
                cmd.Parameters.AddWithValue("@ShipID", shipID);

                da.Fill(data);

                return data.AsEnumerable().Select(row => new Port(row["portID"].ToString(), row["Name"].ToString()));
            }
        }

        public static IEnumerable<Booking> GetBookings(string cabinID)
        {
            using (var conn = Conn)
            using (var cmd = new MySqlCommand(SqlStrings.Bookings_GetByCabinID, conn))
            using (var da = new MySqlDataAdapter(cmd))
            using (var data = new DataTable())
            {
                cmd.Parameters.AddWithValue("@cabinID", cabinID);

                da.Fill(data);

                return data.AsEnumerable().Select(row => new Booking(
                    row["ExcursionID"].ToString(),
                    cabinID,
                    (int)row["numPassengers"],
                    (BookingStatus)Enum.Parse(typeof(BookingStatus), row["status"].ToString())
                ));
            }
        }

        public static IEnumerable<Booking> GetAllBookings()
        {
            using (var conn = Conn)
            using (var cmd = new MySqlCommand(SqlStrings.Bookings_ListAll, conn))
            using (var da = new MySqlDataAdapter(cmd))
            using (var data = new DataTable())
            {
                da.Fill(data);

                return data.AsEnumerable().Select(row => new Booking(
                    row["ExcursionID"].ToString(),
                    row["cabinID"].ToString(),
                    (int)row["numPassengers"],
                    (BookingStatus)Enum.Parse(typeof(BookingStatus), row["status"].ToString())
                ));
            }
        }

        public static bool InsertBooking(string cabinID, string excursionID, BookingStatus status, int numPassengers)
        {
            using (var conn = Conn)
            using (var cmd = new MySqlCommand(SqlStrings.Booking_Insert, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@cabinID", cabinID);
                cmd.Parameters.AddWithValue("@excursionID", excursionID);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@numPassengers", numPassengers);

                return (cmd.ExecuteNonQuery() == 1);
            }
        }

        public static Booking UpdateBooking(int bookingID, string cabinID, string excursionID, BookingStatus status, int numPassengers)
        {
            throw new NotImplementedException();
        }

        public static List<Passenger> GetAllPassengers()
        {
            using (var conn = Conn)
            using (var cmd = new MySqlCommand(SqlStrings.Passenger_ListAll, conn))
            using (var da = new MySqlDataAdapter(cmd))
            using (var data = new DataTable())
            {
                da.Fill(data);
                return data.AsEnumerable().Select(row => new Passenger(
                    row["PassengerID"].ToString(),
                    (int)row["CruiseID"],
                    row["CabinID"].ToString(),
                    row["Name"].ToString())).ToList();
            }
        }


        public static string GetPassengerLocation(string passengerName)
        {
            using (var conn = Conn)
            using (var cmd = new MySqlCommand(SqlStrings.Passenger_GetByName, conn))
            using (var da = new MySqlDataAdapter(cmd))
            using (var data = new DataTable())
            {
                cmd.Parameters.AddWithValue("@passengerName", passengerName);

                da.Fill(data);

                if (data.Rows.Count != 1)
                    throw new DataException($"Unable to find one passenger with that name; found {data.Rows.Count}.");

                return data.Rows[0]["Location"].ToString();
            }
        }

        public static bool UpdatePassengerLocation(string name, PassengerLocation location)
        {
            using (var conn = Conn)
            using (var cmd = new MySqlCommand(SqlStrings.Passenger_UpdateLocation, conn))
            {
                conn.Open();

                cmd.Parameters.AddWithValue("@passengerName", name);
                cmd.Parameters.AddWithValue("@location", location.ToString());

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
