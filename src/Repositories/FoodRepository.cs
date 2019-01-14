using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NutritionData.Backend.Models.food;

namespace NutritionData.Backend.Repositories
{
    public class FoodRepository : IFoodRepository
    {
        public Task<List<Food>> ListAsync()
        {
            return Task.FromResult(new List<Food>());
        }
    }
}
