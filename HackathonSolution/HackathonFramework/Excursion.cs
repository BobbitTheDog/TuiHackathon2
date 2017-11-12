using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonFramework
{
    public class Excursion
    {
        private string _excursionID;
        public string ExcursionID => _excursionID;

        private readonly string _portID;
        public string PortID => _portID;

        private readonly string _name;
        public string Name => _name;

        private int _numberOfCoaches;
        public int NumCoach => _numberOfCoaches;

        public Excursion(string excurID, string seapID, string name, int numCoaches)
        {
            _excursionID = excurID;
            _portID = seapID;
            _name = name;
            _numberOfCoaches = numCoaches;
        }


    }
}
