using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NutritionData.Backend.Models
{
    public class SourceCode
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string SourceCodeId { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
