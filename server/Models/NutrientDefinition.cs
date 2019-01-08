using System;
using System.ComponentModel.DataAnnotations;

namespace server.Models
{
    public class NutrientDefinition
    {
        [Key]
        public string NutrientDefinitionId { get; set; } // Nutr_No
        [Required]
        public string Units { get; set; } // Units
        public string Tag { get; set; } // Tagname
        [Required]
        public string Name { get; set; } // NutrDesc
        [Required]
        public int Decimals { get; set; } // Num_Dec
        [Required]
        public string SortOrder { get; set; }
    }
}
