using System.Collections.Generic;
using System.Linq;
using System.Web.Http.Results;
using TrainersMap.Api.Controllers;
using Xunit;

namespace TrainersMap.Api.Tests.Controllers
{
    public class ValuesControllerTest
    {
        [Fact]
        public void Get()
        {
            // Arrange
            ValuesController controller = new ValuesController();
            IEnumerable<string> result = controller.Get();
            Assert.NotNull(result);
            Assert.Equal(2, result.Count());
            Assert.Equal("value1", result.ElementAt(0));
            Assert.Equal("value2", result.ElementAt(1));
        }

        [Fact]
        public void GetById()
        {
            ValuesController controller = new ValuesController();
            var result = controller.Get(5);
            OkNegotiatedContentResult<string> conNegResult = (OkNegotiatedContentResult<string>) result;
            Assert.Equal("value", conNegResult.Content);
        }

        [Fact]
        public void Post()
        {
            // Arrange
            ValuesController controller = new ValuesController();

            // Act
            controller.Post("value");

            // Assert
        }

        [Fact]
        public void Put()
        {
            // Arrange
            ValuesController controller = new ValuesController();

            // Act
            controller.Put(5, "value");

            // Assert
        }

        [Fact]
        public void Delete()
        {
            // Arrange
            ValuesController controller = new ValuesController();

            // Act
            controller.Delete(5);

            // Assert
        }
    }
}
