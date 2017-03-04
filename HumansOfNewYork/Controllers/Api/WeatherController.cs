using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HumansOfNewYork.Controllers.Api
{
    [Route("api/[controller]")]
    public class WeatherController : Controller
    {
        [HttpGet("[action]/{city}")]
        public IActionResult City(string city)
        {
            return Ok(new { Temp = "12", Summary = "Barmy", City = city });
        }
    }
}
