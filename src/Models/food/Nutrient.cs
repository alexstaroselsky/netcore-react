using System.Collections.Generic;

namespace NutritionData.Backend.Models.food
{
    public class Nutrient
    {
        public string NutrientId { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public string Value { get; set; }
        public List<Measure> Measures { get; set; }

    }
}