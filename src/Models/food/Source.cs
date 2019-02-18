using System.ComponentModel.DataAnnotations;

namespace NutritionData.Backend.Models.food
{
    public class Source
    {
        [Key]
        public string SourceId { get; set; } // DataSrc_ID
        public string Title { get; set; }
        public string Journal { get; set; }
        public string Authors { get; set; } // comma separated
        public string Volume { get; set; } // Vol_City
        public string Issue { get; set; } // Issue_State
        public string Year { get; set; }
        public string StartPage { get; set; } // Start_Page
        public string EndPage { get; set; } // End_Page
    }
}