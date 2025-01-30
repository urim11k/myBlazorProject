using System.ComponentModel.DataAnnotations;

namespace BlazorEventCardExample.Models
{
    public class RegistrationModel
    {
        [Required(ErrorMessage = "Full Name is required.")]
        public string? FullName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email address.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters.")]
        public string? Password { get; set; }
    }
}



