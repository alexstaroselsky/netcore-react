using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using server.Controllers;
using server.Models;
using Xunit;

namespace server_tests.Controllers
{
    public class FoodGroupsControllerTests
    {
        [Fact]
        public void ReturnsFoodGroups()
        {
            // Arrange
            var controller = new FoodGroupsController();

            // Act
            var result = controller.Get();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnValue = Assert.IsType<List<FoodGroup>>(okResult.Value);
        }
    }
}
