using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SEP.Models
{
    public class StudentApplication
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ApplicationUserId { get; set; }
        [ForeignKey("ApplicationUserId")]
        [ValidateNever]
        public ApplicationUser ApplicationUser { get; set; }

        public int? JobPostId { get; set; }
        [ForeignKey("JobPostId")]
        [ValidateNever]
        public JobPost? jobPost { get; set; }
        public string status { get; set; }
    }
}
