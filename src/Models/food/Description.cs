namespace NutritionData.Backend.Models.food
{
    public class Description
    {
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string FoodGroup { get; set; }
        public string ScientificName { get; set; }
        public string CommercialName { get; set; }
        public string Manufacturer { get; set; }
        public decimal NitrogenToProteinConversionFactor { get; set; }
        public decimal CarbohydrateFactor { get; set; }
        public decimal FatFactor { get; set; }
        public decimal ProteinFactor { get; set; }
        public string RefusePercent { get; set; }
        public string RefuseDescription { get; set; }
        public string DatabaseSource { get; set; }
        public string ReportingUnit { get; set; }
    }
}