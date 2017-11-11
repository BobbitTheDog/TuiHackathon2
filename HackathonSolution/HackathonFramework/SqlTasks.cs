using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;

namespace HackathonFramework
{
    public static class SqlTasks
    {
        public static List<Port> GetAllPorts()
        {
            using (var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString))
            using (var cmd = new MySqlCommand(SqlStrings.Port_ListNameAndID, conn))
            using (var da = new MySqlDataAdapter(cmd))
            using (var data = new DataTable())
            {
                da.Fill(data);
                return data.AsEnumerable().Select(row => new Port(row["PortID"].ToString(), row["Name"].ToString())).ToList();
            }
        }

        public static List<Ship> GetAllShips(bool loadItinerary = true)
        {
            using (var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString))
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
            using (var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString))
            using (var cmd = new MySqlCommand(SqlStrings.PortOfCall_ListByShipID, conn))
            using (var da = new MySqlDataAdapter(cmd))
            using (var data = new DataTable())
            {
                cmd.Parameters.AddWithValue("@ShipID", shipID);

                da.Fill(data);

                return data.AsEnumerable().Select(row => new Port(row["portID"].ToString(), row["Name"].ToString()));
            }
        }
    }
}
