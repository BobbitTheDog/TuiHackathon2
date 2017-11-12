using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonFramework
{
    public class Passenger
    {
        private readonly string _passengerID;
        public string PassengerID => _passengerID;

        private readonly string _cabinID;
        public string CabinID => _cabinID;

        private readonly string _shipID;
        public string ShipID => _shipID;

        private readonly string _name;
        public string Name => _name;

        public Passenger(string passengerID, string shipID, string cabinID, string name)
        {
            _passengerID = passengerID;
            _shipID = shipID;
            _cabinID = cabinID;
            _name = name;
        }
    }
}
