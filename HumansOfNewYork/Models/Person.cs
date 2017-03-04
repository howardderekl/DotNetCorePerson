using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HumansOfNewYork.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public int Age { get; set; }
        public ICollection<Interest> Interests { get; set; }

        public int? PictureId { get; set; }
        public Picture Picture { get; set; }
    }
}
