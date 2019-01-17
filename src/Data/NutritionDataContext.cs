using Microsoft.EntityFrameworkCore;
using NutritionData.Backend.Models.food;
using System.Collections.Generic;

namespace NutritionData.Backend.Data
{
    public class NutritionDataContext : DbContext
    {
        public NutritionDataContext(DbContextOptions<NutritionDataContext> options)
            : base(options)
        { }

        public DbSet<Food> Foods { get; set; }
    }
}
