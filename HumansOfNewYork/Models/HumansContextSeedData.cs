using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HumansOfNewYork.Models
{
    public class HumansContextSeedData
    {
        private HumansContext _context;

        public HumansContextSeedData(HumansContext context)
        {
            _context = context;
        }

        public async Task EnsureSeedData()
        {
            if (!_context.Persons.Any())
            {
                var superMan = new Person()
                {
                    FirstName = "Clark",
                    LastName = "Kent",
                    Age = 25,
                    Street = "123 Somewhere Street",
                    City = "New York",
                    State = "NY",
                    Zip = "12345",
                    Interests = new List<Interest>()
                    {
                        new Interest() { Description = "Flying" },
                        new Interest() { Description = "Looking Through Walls" },
                        new Interest() { Description = "Laser Vision" },
                        new Interest() { Description = "Spending time in the ice castle" }
                    }
                };

                var superImage = new Picture()
                {
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/e/eb/SupermanRoss.png"
                };

                _context.Pictures.Add(superImage);
                superMan.Picture = superImage;

                _context.Persons.Add(superMan);
                _context.Interests.AddRange(superMan.Interests);

                var batMan = new Person()
                {
                    FirstName = "Bruce",
                    LastName = "Wayne",
                    Age = 35,
                    Street = "123 Somewhere Street",
                    City = "Gotham City",
                    State = "NY",
                    Zip = "54321",
                    Interests = new List<Interest>()
                    {
                        new Interest() { Description = "Driving Fast Cars" },
                        new Interest() { Description = "Wearing Black" },
                        new Interest() { Description = "Wearing Really Really Dark Grey" },
                        new Interest() { Description = "Fighting Superman" }
                    }
                };

                var batImage = new Picture()
                {
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/1/17/Batman-BenAffleck.jpg"
                };

                _context.Pictures.Add(batImage);
                batMan.Picture = batImage;

                _context.Persons.Add(batMan);
                _context.Interests.AddRange(batMan.Interests);

                var spiderMan = new Person()
                {
                    FirstName = "Peter",
                    LastName = "Parker",
                    Age = 25,
                    Street = "127 Somewhere Street",
                    City = "New York",
                    State = "NY",
                    Zip = "56789",
                    Interests = new List<Interest>()
                    {
                        new Interest() { Description = "Climbing Walls" },
                        new Interest() { Description = "Saving People" },
                        new Interest() { Description = "Spinning Webs" },
                        new Interest() { Description = "Teasing Antman" }
                    }
                };

                var spiderImage = new Picture()
                {
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/0/0c/Spiderman50.jpg"
                };

                _context.Pictures.Add(spiderImage);
                spiderMan.Picture = spiderImage;

                _context.Persons.Add(spiderMan);
                _context.Interests.AddRange(spiderMan.Interests);

                await _context.SaveChangesAsync();
            }
        }
    }
}
