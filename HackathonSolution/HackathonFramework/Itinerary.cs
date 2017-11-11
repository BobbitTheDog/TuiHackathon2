using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonFramework
{
    public class Itinerary
    {
        private readonly List<Port> _ports = new List<Port>();
        public List<Port> Ports => _ports;

        private readonly string _itineraryID;
        public string ID => _itineraryID;

        public Itinerary(string ItineraryID)
        {
            _itineraryID = ItineraryID;
        }
    }
}
