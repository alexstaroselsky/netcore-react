using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NutritionData.Backend.Models.food
{
    public class Food
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string FoodId { get; set; } // NDB_No
        public Description Description { get; set; }
        public List<Nutrient> Nutrients { get; set; }
        public List<Source> Sources { get; set; }
        public List<Footnote> Footnotes { get; set; }
    }
}
