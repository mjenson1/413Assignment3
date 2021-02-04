using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace _413Assignment3.Models
{
    public class MovieResponse
    {
        [Required]
        public string Category { get; set; }
        [Required]
        public string Title { get; set; }
        [Required(ErrorMessage = "The Year field is required")]
        public int? Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; } //drop down
        public bool? Edited { get; set; } //optional
        public string LentTo { get; set; } // optional
        [MaxLength(25)]
        public string Notes { get; set; } // optional limited to 25 chars
    }
}
