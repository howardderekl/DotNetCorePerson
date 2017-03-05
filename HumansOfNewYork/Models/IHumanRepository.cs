using System.Collections.Generic;
using System.Threading.Tasks;

namespace HumansOfNewYork.Models
{
    public interface IHumanRepository
    {
        IEnumerable<Person> GetAllPersons();
        IEnumerable<Person> GetPersonsByFirstLastName(string name);
        void AddPerson(Person person);
        Task<bool> SaveChangesAsync();
    }
}