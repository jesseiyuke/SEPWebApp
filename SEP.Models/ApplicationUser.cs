﻿using Microsoft.AspNetCore.Identity;

namespace SEP.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? Title { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Telephone { get; set; }

        /*        For future use:
         *        public int ? EmployerId { get; set; }
                [ForeignKey(nameof(EmployerId))]
                [ValidateNever]
                public Employer Employer { get; set; }*/


    }
}
