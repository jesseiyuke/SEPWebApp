using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace SEP.Models.ViewModels
{
    public class EmployerVM
    {
        [ValidateNever]
        public ApplicationUser ApplicationUser { get; set; }
        public Employer Employer { get; set; }
    }
}
