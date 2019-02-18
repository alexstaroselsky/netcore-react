using NutritionData.Backend.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NutritionData.Backend.Repositories
{
    public interface IFoodGroupRepository
    {
        Task<List<FoodGroup>> ListAsync();
    }
}
