using System;

namespace NutritionData.Backend.Models.food
{
    public class Food
    {
        public Description Description { get; set; }
        public Nutrient[] Nutrients { get; set; }
        public Source[] Sources { get; set; }
        public String[] Footnotes { get; set; }
    }
}
