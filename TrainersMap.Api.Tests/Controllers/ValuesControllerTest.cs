using System.Collections.Generic;
using System.Linq;
using System.Web.Http.Results;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainersMap.Api.Controllers;

namespace TrainersMap.Api.Tests.Controllers
{
    [TestClass]
    public class ValuesControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            ValuesController controller = new ValuesController();
            IEnumerable<string> result = controller.Get();
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
            Assert.AreEqual("value1", result.ElementAt(0));
            Assert.AreEqual("value2", result.ElementAt(1));
        }

        [TestMethod]
        public void GetById()
        {
            ValuesController controller = new ValuesController();
            var result = controller.Get(5);
            OkNegotiatedContentResult<string> conNegResult = (OkNegotiatedContentResult<string>) result;
            Assert.AreEqual("value", conNegResult.Content);
        }

        [TestMethod]
        public void Post()
        {
            // Arrange
            ValuesController controller = new ValuesController();

            // Act
            controller.Post("value");

            // Assert
        }

        [TestMethod]
        public void Put()
        {
            // Arrange
            ValuesController controller = new ValuesController();

            // Act
            controller.Put(5, "value");

            // Assert
        }

        [TestMethod]
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
