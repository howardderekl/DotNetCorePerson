using HumansOfNewYork.Api.Controllers;
using HumansOfNewYork.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace HumansOfNewYork.Test.Controllers.Api
{
    public class PersonControllerTests
    {
        private readonly Mock<IHumanRepository> _mockRepo;
        private readonly Mock<ILogger<PersonController>> _mockLogger;
        public PersonControllerTests()
        {
            _mockRepo = new Mock<IHumanRepository>();
            _mockLogger = new Mock<ILogger<PersonController>>();
        }

        [Fact(DisplayName = "Default Get should return All persons")]
        public void get_all()
        {
            var person1 = new Person()
            {
                FirstName = "Clark",
                LastName = "Kent",
                Age = 25,
                Street = "123 Somewhere Street",
                City = "New York",
                State = "NY",
                Zip = "12345",
                Picture = new Picture() { ImageUrl = "https://upload.wikimedia.org/wikipedia/en/e/eb/SupermanRoss.png" },
                Interests = new List<Interest>()
                    {
                        new Interest() { Description = "Flying" },
                        new Interest() { Description = "Looking Through Walls" },
                        new Interest() { Description = "Laser Vision" },
                        new Interest() { Description = "Spending time in the ice castle" }
                    }
            };
            var person2 = new Person()
            {
                FirstName = "Peter",
                LastName = "Parker",
                Age = 25,
                Street = "125 Somewhere Street",
                City = "New York",
                State = "NY",
                Zip = "54321",
                Picture = new Picture() { ImageUrl = "https://upload.wikimedia.org/wikipedia/en/0/0c/Spiderman50.jpg" },
                Interests = new List<Interest>()
                    {
                        new Interest() { Description = "Climbing Walls" },
                        new Interest() { Description = "Saving People" },
                        new Interest() { Description = "Spinning Webs" },
                        new Interest() { Description = "Teasing Antman" }
                    }
            };

            var persons = new List<Person>() { person1, person2 };

            _mockRepo.Setup(m => m.GetAllPersons()).Returns(persons);

            var controller = new PersonController(_mockRepo.Object, _mockLogger.Object);

            var result = controller.Get();

            var okObjectResult = result as OkObjectResult;
            Assert.NotNull(okObjectResult);
            Assert.Equal(200, okObjectResult.StatusCode);
            Assert.NotNull(okObjectResult.Value);
        }

    }
}
