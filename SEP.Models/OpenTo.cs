using System.ComponentModel.DataAnnotations;

namespace SEP.Models
{
    public enum OpenTo
    {
        [Display(Name = "South African citizens or")] Citizen,
        [Display(Name = "Open to everyone")] Open
    }
}
