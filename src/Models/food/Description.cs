using System.ComponentModel.DataAnnotations;
using NutritionaData.Backend.Models;

namespace NutritionData.Backend.Models.food
{
    public class Description
    {
        [Key]
        public string DescriptionId { get; set; } // NDB_No
        [Required]
        public string ShortDescription { get; set; } // Shrt_Desc
        [Required]
        public string LongDescription { get; set; } // Long_Desc
        [Required]
        public FoodGroup FoodGroup { get; set; } // FdGrp_Cd
        public string ScientificName { get; set; } // SciName
        public string CommonName { get; set; } // ComName
        public string Manufacturer { get; set; } // ManufacName
        public bool Survey { get; set; } // Survey
        public decimal NitrogenToProteinConversionFactor { get; set; } // N_Factor
        public decimal CarbohydrateFactor { get; set; } // CHO_Factor
        public decimal FatFactor { get; set; } // Fat_Factor
        public decimal ProteinFactor { get; set; } // Pro_Factor
        public double RefusePercent { get; set; } // Refuse
        public string RefuseDescription { get; set; } // Ref_desc
        public string DatabaseSource { get; set; }
        public string ReportingUnit { get; set; }
    }
}