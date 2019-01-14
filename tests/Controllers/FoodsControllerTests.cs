using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NutritionData.Backend.Controllers;
using NutritionData.Backend.Models.food;
using NutritionData.Backend.Repositories;
using Xunit;

namespace server_tests.Controllers
{
    public class FoodsControllerTests
    {
        [Fact]
        public async Task ReturnsFoodGroups()
        {
            // Arrange
            var mockRepo = new Mock<IFoodRepository>();
            mockRepo.Setup(repo => repo.ListAsync()).ReturnsAsync(GetTestFoods());
            var controller = new FoodsController(mockRepo.Object);

            // Act
            var result = await controller.Get();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnValue = Assert.IsType<List<Food>>(okResult.Value);
        }

        private List<Food> GetTestFoods()
        {
            return new List<Food>();
        }
    }
}
