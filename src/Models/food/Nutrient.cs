namespace NutritionData.Backend.Models.food
{
    public class Nutrient
    {
        public string Name { get; set; }
        public string Unit { get; set; }
        public string Value { get; set; }
        public Measure[] Measures { get; set; }

    }
}