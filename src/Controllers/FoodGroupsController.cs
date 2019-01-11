using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NutritionaData.Backend.Models;
using NutritionaData.Backend.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NutritionaData.Backend.Controllers
{
    [Route("api/food-groups")]
    public class FoodGroupsController : Controller
    {
        private readonly IFoodGroupRepository _foodGroupRepository;

        public FoodGroupsController(IFoodGroupRepository foodGroupRepository)
        {
            _foodGroupRepository = foodGroupRepository;
        }

        // GET: api/foodgroups
        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(200, Type = typeof(List<FoodGroup>))]
        public async Task<ActionResult> Get()
        {
            var foodGroups = await _foodGroupRepository.ListAsync();

            return Ok(foodGroups);
        }
    }
}
