using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HumansOfNewYork.Models
{
    public class HumanRepository : IHumanRepository
    {
        private HumansContext _context;

        public HumanRepository(HumansContext context)
        {
            _context = context;
        }

        public IEnumerable<Person> GetAllPersons()
        {
            return _context.Persons.ToList();
        }
    }
}
