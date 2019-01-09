using System;
using System.ComponentModel.DataAnnotations;

namespace src.Models
{
    public class Weight
    {
        [Key]
        public string WeightId { get; set; }
        [Required]
        public string NDBNumber { get; set; }
        [Required]
        public string SequenceNumber { get; set; }
        [Required]
        public double Amount { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public double Grams { get; set; }
        public int NumberDataPoints { get; set; }
        public double StandardDeviation { get; set; }
    }
}
