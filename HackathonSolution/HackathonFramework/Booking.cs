using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonFramework
{
    public class Booking
    {
        private readonly string _excursionID;
        public string ExcursionID => _excursionID;

        private readonly string _cabinID;
        public string CabinID => _cabinID;

        public BookingStatus Status { get; set; }

        private int _numPassengers;
        public int NumPassengers => _numPassengers;

        public Booking(string excursionID, string cabinID, int numPassengers, BookingStatus status = BookingStatus.Cancelable)
        {
            _excursionID = excursionID;
            _cabinID = cabinID;
            _numPassengers = NumPassengers;

            Status = status;
        }
    }
}
