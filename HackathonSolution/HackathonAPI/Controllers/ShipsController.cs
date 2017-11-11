using HackathonFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HackathonAPI.Controllers
{
    public class ShipsController : ApiController
    {
        public IEnumerable<Ship> GetAllShips()
        {
            return SqlTasks.GetAllShips(false);
        }
    }
}
