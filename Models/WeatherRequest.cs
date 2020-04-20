using System.ComponentModel.DataAnnotations;

namespace sample.Models 
    {
    public class WeatherRequest {
        [Required]
        public string country { get; set;}
        [Required]
        public string city { get; set; }
        [Required]
        public int day { get; set; }
        [Required]
        public int month { get; set; }
        [Required]
        public int year { get; set; }
    }
}