using System;
using System.Collections.Generic;
using NutritionaData.Backend.Models;

namespace NutritionData.Backend.Models.food
{
    public class Food
    {
        public string FoodId { get; set; }
        public Description Description { get; set; }
        public Nutrient[] Nutrients { get; set; }
        public List<Source> Sources { get; set; }
        public List<Footnote> Footnotes { get; set; }
    }
}
