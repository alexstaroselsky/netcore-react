using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using server.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace server.Controllers
{
    [Route("api/[controller]")]
    public class FoodGroupsController : Controller
    {
        // GET: api/foodgroups
        [HttpGet]
        public ActionResult Get()
        {
            var foodGroups = new List<FoodGroup>();
            return Ok(foodGroups);
        }
    }
}
