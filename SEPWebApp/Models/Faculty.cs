using System.ComponentModel.DataAnnotations;

namespace SEPWebApp.Models
{
    public enum Faculty
    {
        [Display(Name = "Commerce, Law and Management")] CommerceLawManagement,
        [Display(Name = "Engineering and the Built Environment")] Engineering,
        [Display(Name = "Health Sciences")] HealthSciences,
        Humanities,
        Science
    }
}
