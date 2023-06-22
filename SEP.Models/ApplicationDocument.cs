using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SEP.Models
{
    public class ApplicationDocument
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ApplicationUserId { get; set; }
        [ForeignKey("ApplicationUserId")]
        [ValidateNever]
        public ApplicationUser ApplicationUser { get; set; }
        //public StudentApplication StudentApplication { get; set; }
        public string? Name { get; set; }
        [Required]
        public string Description { get; set; }
        [ValidateNever]
        public string FilePath { get; set; }


    }
}
