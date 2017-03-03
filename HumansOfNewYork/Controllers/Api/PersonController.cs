using HumansOfNewYork.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HumansOfNewYork.Api.Controllers
{
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        private IHumanRepository _repo;

        public PersonController(IHumanRepository repo)
        {
            _repo = repo;
        }
    }
}
