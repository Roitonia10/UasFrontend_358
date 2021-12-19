using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using UasBlazor358.Models;

namespace UasBlazor358.Models
{
    public class Student
    {
        public string studentID { get; set; }
        [Required(ErrorMessage = "Fisrt Name is required")]
        [StringLength(100, MinimumLength = 2)]
        public string firstName { get; set; }
        [Required]

        public string lastName { get; set; }
        [Required]
        public DateTime enrollmentDate { get; set; }
    }
}