using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using server.Models;
using src.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace server.Controllers
{
    [Route("api/[controller]")]
    public class FoodGroupsController : Controller
    {
        private readonly IFoodGroupRepository _foodGroupRepository;

        public FoodGroupsController(IFoodGroupRepository foodGroupRepository)
        {
            _foodGroupRepository = foodGroupRepository;
        }

        // GET: api/foodgroups
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var foodGroups = await _foodGroupRepository.ListAsync();

            return Ok(foodGroups);
        }
    }
}
