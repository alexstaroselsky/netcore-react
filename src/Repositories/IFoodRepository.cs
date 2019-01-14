using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NutritionData.Backend.Models.food;

namespace NutritionData.Backend.Repositories
{
    public interface IFoodRepository
    {
        Task<List<Food>> ListAsync();
    }
}
