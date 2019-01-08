using System;
using System.ComponentModel.DataAnnotations;

namespace server.Models
{
    public class FoodGroup
    {
        [Key]
        public string FoodGroupId { get; set; } // FdGrp_Cd
        [Required]
        public string Name { get; set; }
    }
}
