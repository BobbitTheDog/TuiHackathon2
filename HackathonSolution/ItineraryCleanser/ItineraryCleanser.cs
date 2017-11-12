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
        static void Main(string[] args)
        {
            var itineraries = SqlTasks.GetAllItineraries().ToList();

            BruteForce(itineraries);
        }

        private static void BruteForce(List<Itinerary> itineraries)
        {
            foreach (Itinerary itinerary in itineraries)
            {

            }
        }
    }
}
