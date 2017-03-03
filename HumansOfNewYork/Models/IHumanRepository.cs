﻿using System.Collections.Generic;

namespace HumansOfNewYork.Models
{
    public interface IHumanRepository
    {
        IEnumerable<Person> GetAllPersons();
    }
}