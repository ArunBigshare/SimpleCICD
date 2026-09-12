using Microsoft.AspNetCore.Mvc;
using SimpleCICD.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SimpleCICD.Tests
{
    public class HelloControllerTests
    {
        [Fact]
        public void Get_ReturnsOkResult()
        {
            // Arrange: create an instance of the controller
            var controller = new HelloController();

            // Act: call the Get() method
            var result = controller.Get();

            // Assert: check it returned HTTP 200 OK
            var okResult = Assert.IsType<OkObjectResult>(result);
            Assert.Equal(200, okResult.StatusCode);
        }

        [Fact]
        public void Get_ReturnsExpectedMessage()
        {
            // Arrange
            var controller = new HelloController();

            // Act
            var result = controller.Get() as OkObjectResult;

            // Assert: use reflection to check the anonymous object's "message" property
            Assert.NotNull(result);
            var value = result.Value;
            var messageProperty = value.GetType().GetProperty("message");
            var message = messageProperty.GetValue(value, null) as string;

            Assert.Equal("Hello from CI/CD Version 2!", message);
        }
    }
}
