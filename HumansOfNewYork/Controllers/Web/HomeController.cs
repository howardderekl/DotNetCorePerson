using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HumansOfNewYork.Models;

namespace HumansOfNewYork.Web.Controllers
{
    public class HomeController : Controller
    {
        private IHumanRepository _repo;

        public HomeController(IHumanRepository repo)
        {
            _repo = repo;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
