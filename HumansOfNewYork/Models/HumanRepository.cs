using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HumansOfNewYork.Models
{
    public class HumanRepository : IHumanRepository
    {
        private HumansContext _context;
        private ILogger<HumanRepository> _logger;

        public HumanRepository(HumansContext context, ILogger<HumanRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IEnumerable<Person> GetAllPersons()
        {
            _logger.LogInformation("Getting All Persons from the Database");

            return _context.Persons.Include(i => i.Interests).ToList();
        }
    }
}
