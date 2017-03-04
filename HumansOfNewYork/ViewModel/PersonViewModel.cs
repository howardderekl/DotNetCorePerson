using HumansOfNewYork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HumansOfNewYork.ViewModel
{
    public class PersonViewModel
    {
        public string Name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public int Age { get; set; }
        public ICollection<Interest> Interests { get; set; }
    }
}
