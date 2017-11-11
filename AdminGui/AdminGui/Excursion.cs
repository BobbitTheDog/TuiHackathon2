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
    class Excursion
    {
        private string _excursionID;
        public string exID => _excursionID;

        private readonly string _seaportID;
        public string seaID => _seaportID;

        private int _numberOfCoaches;
        public int numCoach => _numberOfCoaches;

        public Excursion(string excurID, string seapID, int numCoaches)
        {
            _excursionID = excurID;
            _seaportID = seapID;
            _numberOfCoaches = numCoaches;
        }


    }
}
