using System.Web.Mvc;
using TrainersMap.Api.Controllers;
using Xunit;

namespace TrainersMap.Api.Tests.Controllers
{
    public class HomeControllerTest
    {
        [Fact]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Home Page", result.ViewBag.Title);
        }
    }
}
