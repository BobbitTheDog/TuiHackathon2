using HackathonFramework;
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
        public List<Passenger> GetAllPassengers()
        {
            return SqlTasks.GetAllPassengers();
        }
        
        public string GetPassengerLocation(string passengerName)
        {
            return SqlTasks.GetPassengerLocation(passengerName);
        }

        public IHttpActionResult PostPassengerLocation(string passengerName, [FromBody] string location)
        {
            PassengerLocation _location;

            if (!Enum.TryParse(location, out _location))
                return BadRequest($"{location} is not a valid PassengerLocation.");

            var success = SqlTasks.UpdatePassengerLocation(passengerName, _location);
            return Ok(success);
        }
    }
}
