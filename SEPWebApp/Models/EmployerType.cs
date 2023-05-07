using System.ComponentModel.DataAnnotations;

namespace SEPWebApp.Models
{
    public enum EmployerType
    {
        [Display(Name = "Internal (within Wits)")] Internal,
        [Display(Name = "External (created on behalf of)")] External
    }
}
