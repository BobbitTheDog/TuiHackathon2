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
    public class Excursion
    {
        private string _excursionID;
        public string ExcurionID => _excursionID;

        private readonly string _portID;
        public string PortID => _portID;

        private int _numberOfCoaches;
        public int NumCoach => _numberOfCoaches;

        public Excursion(string excurID, string seapID, int numCoaches)
        {
            _excursionID = excurID;
            _portID = seapID;
            _numberOfCoaches = numCoaches;
        }


    }
}
