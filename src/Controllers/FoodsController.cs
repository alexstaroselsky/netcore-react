using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NutritionData.Backend.Models.food;
using NutritionData.Backend.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NutritionData.Backend.Controllers
{
    [Route("api/foods")]
    public class FoodsController : Controller
    {
        private readonly IFoodRepository _foodRepository;

        public FoodsController(IFoodRepository foodRepository)
        {
            _foodRepository = foodRepository;
        }

        // GET: api/foods
        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(200, Type = typeof(List<Food>))]
        public async Task<ActionResult> Get()
        {
            var foodGroups = await _foodRepository.ListAsync();

            return Ok(foodGroups);
        }
    }
}
