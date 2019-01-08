using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace server.Models
{
    public class NutrientDefinition
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string NutrientDefinitionId { get; set; } // Nutr_No
        [Required]
        public string Units { get; set; } // Units
        public string Tag { get; set; } // Tagname
        [Required]
        public string Name { get; set; } // NutrDesc
        [Required]
        public int Decimals { get; set; } // Num_Dec
        [Required]
        public string SortOrder { get; set; } // SR_Order
    }
}
