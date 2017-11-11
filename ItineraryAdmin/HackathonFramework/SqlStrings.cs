using HackathonFramework.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackathonFramework
{
    public static class SqlStrings
    {
        public static string Port_GetDistances => Resources.Port_GetDistances;
        public static string Port_ListNameAndID => Resources.Port_ListNameAndID;
        public static string PortOfCall_ClearByShipID => Resources.PortOfCall_ClearByShipID;
        public static string PortOfCall_Insert => Resources.PortOfCall_Insert;
        public static string PortOfCall_ListByShipID => Resources.PortOfCall_ListByShipID;
        public static string PortOfCall_Update => Resources.PortOfCall_Update;
        public static string Ship_ListNameAndID => Resources.Ship_ListNameAndID;
    }
}
