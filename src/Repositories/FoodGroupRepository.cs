using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NutritionaData.Backend.Models;

namespace NutritionaData.Backend.Repositories
{
    public class FoodGroupRepository : IFoodGroupRepository
    {
        public async Task<List<FoodGroup>> ListAsync()
        {
            return await Task.FromResult(new List<FoodGroup>());
        }
    }
}
