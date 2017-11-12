using HackathonFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HackathonAPI.Controllers
{
    public class BookingsController : ApiController
    {
        public IEnumerable<Booking> GetCabinBookings(string cabinID)
        {
            return SqlTasks.GetBookings(cabinID);
        }
    }
}
