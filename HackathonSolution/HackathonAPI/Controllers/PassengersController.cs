using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HackathonAPI.Controllers
{
    public class PassengersController : ApiController
    {
        public IHttpActionResult PostPassengerLocation(string passengerName)
        {

            return Ok();
        }
    }
}
