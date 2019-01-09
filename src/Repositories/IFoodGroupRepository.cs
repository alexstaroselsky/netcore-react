using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using src.Models;

namespace src.Repositories
{
    public interface IFoodGroupRepository
    {
        Task<List<FoodGroup>> ListAsync();
    }
}
