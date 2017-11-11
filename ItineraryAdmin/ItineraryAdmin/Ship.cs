using ItineraryAdmin.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItineraryAdmin
{
    class Ship : ICloneable, IEquatable<Ship>
    {
        private Ship lastSaved;

        private readonly string _shipID;
        public string ID => _shipID;

        private readonly string _shipName;
        public string Name => _shipName;

        private readonly List<Port> _ports = new List<Port>();
        public List<Port> Ports => _ports;

        private string _startPort;
        public string StartPort
        {
            get
            {
                if (!_ports.Any(port => port.ID == _startPort))
                    StartPort = null;
                return _startPort;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && !_ports.Any(port => port.ID == StartPort))
                    throw new InvalidOperationException("This port is not in the ship's itinerary");

                _startPort = value;
            }
        }

        public bool Modified => !Equals(lastSaved);

        public Ship(string id, string name)
        {
            _shipID = id;
            _shipName = name;
        }

        internal void LoadItinerary()
        {
            using (var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString))
            using (var cmd = new MySqlCommand(Resources.ItineraryStop_ListByShipID, conn))
            using (var da = new MySqlDataAdapter(cmd))
            using (var data = new DataTable())
            {
                cmd.Parameters.AddWithValue("@ShipID", ID);

                da.Fill(data);

                Ports.Clear();
                Ports.AddRange(data.AsEnumerable().Select(row => new Port(row["portID"].ToString(), row["Name"].ToString())));
            }
        }

        public object Clone()
        {
            var newShip = new Ship(ID, Name);
            newShip.Ports.AddRange(Ports);
            newShip.StartPort = StartPort;

            return newShip;
        }

        public bool Equals(Ship other)
        {
            return (
                other.ID == ID &&
                other.Name == Name &&
                other.Ports.SequenceEqual(Ports) &&
                other.StartPort == StartPort
                );
        }

        internal async Task<bool> SaveItineraryAsync()
        {
            using (var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString))
            using (var cmd = new MySqlCommand(Resources.ItineraryStop_Insert))
            {
                cmd.Parameters.AddWithValue("@shipID", ID);
                cmd.Parameters.Add("@seaportID", MySqlDbType.String);

                foreach (Port port in Ports)
                {
                    cmd.Parameters["@seaportID"].Value = port.ID;
                }
            }

        }
    }
}
