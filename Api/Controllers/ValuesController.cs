using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace CTM.Postcode.Service.Controllers
{
    public class ValuesController : Controller
    {
        [HttpGet]
        [Route("address/{number}/{postcode}")]
        public string Get(string number, string postcode)
        {
            return "Boom!";
        }
    }
}
