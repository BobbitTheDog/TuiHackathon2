using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonFramework
{
    public class PortOfCall
    {
        private readonly string _ID;
        public string ID => _ID;

        private readonly string _itineraryID;
        public string ItineraryID => _itineraryID;

        private readonly Port _port;
        public Port Port => _port;

        public int StopOrder { get; set; }

        public PortOfCall(string id, string itinerary, Port port)
        {
            _ID = id;
            _itineraryID = itinerary;
            _port = port;
        }
    }
}
