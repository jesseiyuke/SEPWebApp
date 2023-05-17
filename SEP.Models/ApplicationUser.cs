using Microsoft.AspNetCore.Identity;

namespace SEP.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? Title { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? EmailAndUsername { get; set; }
        public int? Telephone { get; set; }
        public int? Cellphone { get; set; }

    }
}
