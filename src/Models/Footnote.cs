using System;
using System.ComponentModel.DataAnnotations;

namespace NutritionData.Backend.Models
{
    public class Footnote
    {
        [Key]
        public string FootnoteId { get; set; }
        [Required]
        public string NDBNumber { get; set; }
        [Required]
        public string SequenceNumber { get; set; }
        [Required]
        public string Type { get; set; }
        public string NutrientNumber { get; set; }
        [Required]
        public string Text { get; set; }
    }
}
