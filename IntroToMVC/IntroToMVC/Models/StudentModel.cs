using System.ComponentModel.DataAnnotations;

namespace IntroToMVC.Models
{
    public class StudentModel
    {
        [Display(Name = "Student Name")]
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be 3 to 50 letters")]
        [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "Name can only contain letters")]
        public int? id { get; set; }

        public required string name { get; set; }
        [Display(Name = "Department")]
        [Required(ErrorMessage = "Department is required")]
        [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "Department can only contain letters")]
        public required string dept { get; set; }

        [Display(Name = "CGPA")]
        [Required(ErrorMessage = "CGPA is required")]
        [Range(0.0, 4.0, ErrorMessage = "CGPA must be between 0 and 4")]
        public required float cgpa { get; set; }
    }
}
