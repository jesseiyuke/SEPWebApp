using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SEP.Models.ViewModels
{
    public class FileVM
    {
        [ValidateNever]
        public StudentApplication Application { get; set; }
        [ValidateNever]
        public ApplicationDocument ApplicationDocument { get; set; }

    }
}
