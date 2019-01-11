using NutritionaData.Backend.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NutritionaData.Backend.Repositories
{
    public interface IFoodGroupRepository
    {
        Task<List<FoodGroup>> ListAsync();
    }
}
