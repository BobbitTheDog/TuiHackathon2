using HackathonFramework.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonFramework
{
    public static class SqlStrings
    {
        public static string Port_GetDistances => Resources.Port_GetDistances;
        public static string Port_ListNameAndID => Resources.Port_ListNameAndID;
        public static string PortOfCall_ClearByShipID => Resources.PortOfCall_ClearByShipID;
        public static string PortOfCall_Insert => Resources.PortOfCall_Insert;
        public static string PortOfCall_ListByItineraryID => Resources.PortOfCall_ListByItineraryID;
        public static string PortOfCall_Update => Resources.PortOfCall_Update;
        public static string Ship_ListNameAndID => Resources.Ship_ListNameAndID;
        public static string Itinerary_ListAll => Resources.Itinerary_ListAll;
        public static string Bookings_GetByCabinID => Resources.Bookings_GetByCabinID;
        public static string Booking_Insert => Resources.Booking_Insert;
        public static string Passenger_UpdateLocation => Resources.Passenger_UpdateLocation;
        public static string Passenger_GetByName => Resources.Passenger_GetByName;
        public static string Passenger_ListAll => Resources.Passenger_ListAll;
        public static string Excursion_ListAll => Resources.Excursion_ListAll;
    }
}
