using HumansOfNewYork.Models;
using HumansOfNewYork.Web.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace HumansOfNewYork.Test.Controllers.Web
{
    public class HomeControllerTests
    {
        private readonly Mock<IHumanRepository> _mockRepo;

        public HomeControllerTests()
        {
            _mockRepo = new Mock<IHumanRepository>();
        }

        [Fact(DisplayName = "Index should return default view")]
        public void Index_should_return_default_view()
        {
            var controller = new HomeController(_mockRepo.Object);
            var viewResult = (ViewResult)controller.Index();
            var viewName = viewResult.ViewName;

            Assert.True(string.IsNullOrEmpty(viewName) || viewName == "Index");
        }

        [Fact(DisplayName = "Error should return error view")]
        public void Index_should_return_error_view()
        {
            var controller = new HomeController(_mockRepo.Object);
            var viewResult = (ViewResult)controller.Error();
            var viewName = viewResult.ViewName;

            Assert.True(string.IsNullOrEmpty(viewName) || viewName == "Error");
        }
    }
}
