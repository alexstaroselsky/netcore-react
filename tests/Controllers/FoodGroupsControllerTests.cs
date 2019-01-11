using Microsoft.AspNetCore.Mvc;
using Moq;
using NutritionaData.Backend.Models;
using NutritionaData.Backend.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace NutritionaData.Backend.Controllers
{
    public class FoodGroupsControllerTests
    {
        [Fact]
        public async Task ReturnsFoodGroups()
        {
            // Arrange
            var mockRepo = new Mock<IFoodGroupRepository>();
            mockRepo.Setup(repo => repo.ListAsync()).ReturnsAsync(GetTestFoodGroups());
            var controller = new FoodGroupsController(mockRepo.Object);

            // Act
            var result = await controller.Get();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnValue = Assert.IsType<List<FoodGroup>>(okResult.Value);
        }

        private List<FoodGroup> GetTestFoodGroups()
        {
            return new List<FoodGroup>();
        }
    }
}
