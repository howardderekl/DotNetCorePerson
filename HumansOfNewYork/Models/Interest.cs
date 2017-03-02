using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HumansOfNewYork.Models
{
    public class Interest
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public string Description { get; set; }
    }
}
