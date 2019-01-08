using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace server.Models
{
    public class FoodGroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string FoodGroupId { get; set; } // FdGrp_Cd
        [Required]
        public string Name { get; set; }
    }
}
