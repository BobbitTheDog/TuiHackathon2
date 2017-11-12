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
        public stringcabin GetCruise(string cabinID)
        {
            return SqlTasks.GetCruise(cabinID);
        }
    }
}
