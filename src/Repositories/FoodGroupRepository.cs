using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NutritionData.Backend.Models;
using NutritionData.Backend.Repositories;

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
