using System.ComponentModel.DataAnnotations;

namespace SEPWebApp.Models
{
    public enum OpenTo
    {
        [Display(Name = "South African citizens or")] Citizen,
        [Display(Name = "Open to everyone")] Open
    }
}
