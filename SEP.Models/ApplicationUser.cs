using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace SEP.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? Title { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        [StringLength(10, ErrorMessage = "Must be 10 digits")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Cellphone number must contain only numbers.")]
        public string? Telephone { get; set; }

    }
}
