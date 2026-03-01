using System.ComponentModel.DataAnnotations;

namespace ValidationPractice.Models
{
    public class ValidationFormModel
    {
        [Required]
        [RegularExpression(@"^[A-Za-z\s]+$",ErrorMessage ="Name can only contain letters")]
        public string name { get; set; } = string.Empty;
        
        [Required]
        [EmailAddress]
        public string email { get; set; } = string.Empty;

        [Required]
        [PastDate]
        //[DataType(DataType.Date)]
        public DateTime dob { get; set; }
        [Required]
        public string pass { get; set; } = string.Empty;

        [Required]
        [Compare("pass", ErrorMessage = "Passwords do not match, please check again")]
        public string cpass { get; set; } = string.Empty;
    }
}
