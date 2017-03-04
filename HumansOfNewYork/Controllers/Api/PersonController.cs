using HumansOfNewYork.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HumansOfNewYork.Api.Controllers
{
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        private ILogger<PersonController> _logger;
        private IHumanRepository _repo;

        public PersonController(IHumanRepository repo, ILogger<PersonController> logger)
        {
            _repo = repo;
            _logger = logger;
        }

        [HttpGet("")]
        public IActionResult Get()
        {
            return Ok(_repo.GetAllPersons());            
        }
    }
}