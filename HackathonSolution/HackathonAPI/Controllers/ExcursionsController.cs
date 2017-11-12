using HackathonFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HackathonAPI.Controllers
{
    public class ExcursionsController : ApiController
    {
        public IEnumerable<Excursion> GetExcursions()
        {
            return SqlTasks.GetAllExcursions();
        }

        public IEnumerable<Excursion> GetExcursionsForCruise([FromUri] string cruiseID)
        {
            return SqlTasks.GetExcursionsForCruise(cruiseID);
        }
    }
}
