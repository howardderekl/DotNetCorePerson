using HumansOfNewYork.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
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
            try
            {
                return Ok(_repo.GetAllPersons());
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error Getting All Persons from the repository: {ex}");
                return BadRequest($"Error getting the list of Persons");
            }
        }

        [HttpGet("[action]")]
        public IActionResult GetDelayedResponse()
        {
            try
            {
                Thread.Sleep(3000);
                return Ok(_repo.GetAllPersons());
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error Getting All Persons from the repository: {ex}");
                return BadRequest($"Error getting the list of Persons");
            }
        }

        [HttpGet("search/{nameFilter}")]
        public IActionResult Get(string nameFilter)
        {
            try
            {
                return Ok(_repo.GetPersonsByFirstLastName(nameFilter));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error Getting Persons from the repository by name: {ex}");
                return BadRequest($"Error getting the list of Persons by name");
            }
        }

        [HttpPost("")]
        public async Task<IActionResult> Post([FromBody]Person thePerson)
        {
            if (ModelState.IsValid)
            {
                _repo.AddPerson(thePerson);

                if (await _repo.SaveChangesAsync())
                {
                    return Created($"api/person/{thePerson.FirstName}", thePerson);
                }
                else
                    return BadRequest("Failed to save changes to the database");

            }

            return BadRequest(ModelState);
            
        }
    }
}