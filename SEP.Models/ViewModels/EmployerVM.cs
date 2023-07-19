using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SEP.Models.ViewModels
{
    public class EmployerVM
    {


        [ValidateNever]
        public ApplicationUser ApplicationUser { get; set; }
        [ValidateNever]
        public IEnumerable<ApplicationUser> ApplicationUserList { get; set; }
        [ValidateNever]
        public Employer Employer { get; set; }
        [ValidateNever]
        public IEnumerable<Employer> EmployerList { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> BusinessTypeList { get; set; }

        [ValidateNever]
        public IEnumerable<SelectListItem> StatusList { get; set; }
    }
}