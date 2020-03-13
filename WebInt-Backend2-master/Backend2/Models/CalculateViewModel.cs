using System;
using System.ComponentModel.DataAnnotations;

namespace Backend2.Models
{
    public class CalculateViewModel
    {
        [Required(ErrorMessage = "First number is required")]
        public int firstNum { get; set; }

        [Required(ErrorMessage = "Second number is required")]
        public int secondNum { get; set; }

    }
}
