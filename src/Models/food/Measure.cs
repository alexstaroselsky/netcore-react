namespace NutritionData.Backend.Models.food
{
    public class Measure
    {
        public string Label { get; set; }
        public decimal Equivalent { get; set; }
        public string EUnit { get; set; }
        public decimal Quantity { get; set; }
        public decimal Value { get; set; }
    }
}