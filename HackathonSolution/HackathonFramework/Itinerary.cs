using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonFramework
{
    public class Itinerary
    {
        private readonly List<PortOfCall> _portsOfCall;
        public List<PortOfCall> PortsOfCall => _portsOfCall;

        private readonly string _itineraryID;
        public string ID => _itineraryID;

        private readonly string _name;
        public string Name => _name;

        public Itinerary(string ItineraryID, string name, List<PortOfCall> portsOfCall = null)
        {
            _itineraryID = ItineraryID;
            _name = name;
            _portsOfCall = SqlTasks.GetPortsOfCall(ItineraryID);
        }
    }
}
