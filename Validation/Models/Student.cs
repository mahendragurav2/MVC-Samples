using System.ComponentModel.DataAnnotations;

namespace ServerValidation.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Name is Requirde")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email is Requirde")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                            @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                            @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                            ErrorMessage="Email is not valid")]
        public string Email { get; set; }
    }
}