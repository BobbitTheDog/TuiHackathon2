using HackathonFramework;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace ItineraryCleanser
{
    class ItineraryCleanser
    {
        private static List<Itinerary> itineraries;
        private static List<Port> allPorts;

        static void Main(string[] args)
        {
            LoadPorts();
            
            using (var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString))
            using (var cmd = new MySqlCommand(SqlStrings.Itinerary_ListAll, conn))
            using (var da = new MySqlDataAdapter(cmd))
            using (var data = new DataTable())
            {
                da.Fill(data);

                var view = new DataView(data);

                itineraries = view.ToTable(true, "ItineraryID").AsEnumerable().Select(row => new Itinerary(row["ItineraryID"].ToString())).ToList();

                itineraries.ForEach(itinerary =>
                {
                    view.RowFilter = $"ItineraryID = {itinerary.ID}";

                    itinerary.Ports.AddRange(view.OfType<DataRow>().Select(row => allPorts.First(port => port.ID == row["PortID"].ToString())));
                });
            }
        }

        private static void LoadPorts()
        {
            allPorts = SqlTasks.GetAllPorts();
        }
    }
}
