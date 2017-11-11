using AdminGui.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminGui
{
    class Booking
    {
        private string _bookingID;

        public string bookID => _bookingID;

        private string _excursionID;

        public string exID => _excursionID;

        private string _cabinID;

        public string cabID => _cabinID;

        private string _status;

        public string stat => _status;

        private int _numberOfPassenger;

        public int numPass => _numberOfPassenger;

        public Booking(string bookingID, string excID, string cabinID, string status, int numberPass)
        {
            _bookingID = bookingID;
            _excursionID = excID;
            _cabinID = cabinID;
            _status = status;
            _numberOfPassenger = numberPass;
        }
        internal void LoadBooking()
        {
            using (var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString))
            using (var cmd = new MySqlCommand(Resources.Booking_ListByBookingID, conn))
            using (var da = new MySqlDataAdapter(cmd))
            using (var data = new DataTable())
            {
                cmd.Parameters.AddWithValue("@Booking", bookID);

                da.Fill(data);

            }
        }
    }
}
