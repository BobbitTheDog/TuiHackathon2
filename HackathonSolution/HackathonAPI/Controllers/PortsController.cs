using HackathonFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HackathonAPI.Controllers
{
    public class PortsController : ApiController
    {
        public IEnumerable<Port> GetAllPorts()
        {
            return SqlTasks.GetAllPorts().AsEnumerable();
        }

        public IEnumerable<Port> GetPorts(string shipID)
        {
            return SqlTasks.GetDestinationPorts(shipID);
        }
    }
}
