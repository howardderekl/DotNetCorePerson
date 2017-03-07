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

        public void AddPerson(Person person)
        {
            _context.Add(person);
        }

        public IEnumerable<Person> GetAllPersons()
        {
            _logger.LogInformation("Getting All Persons from the Database");

            return _context.Persons
                .Include(i => i.Interests)
                .Include(p => p.Picture)
                .OrderBy(p => p.LastName).ThenBy(p => p.FirstName)
                .ToList();
        }

        public IEnumerable<Person> GetPersonsByFirstLastName(string name)
        {
            _logger.LogInformation("Getting Persons from the Database Matching by First Name or Last Name");

            return _context.Persons
                .Include(p => p.Interests)
                .Include(p => p.Picture)
                .Where(p => p.FirstName.Contains(name) || p.LastName.Contains(name))
                .OrderBy(p => p.LastName).ThenBy(p => p.FirstName)
                .ToList();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }
    }
}
