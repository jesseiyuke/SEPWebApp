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
        public string StudentId { get; set; }
        [ForeignKey("StudentId")]
        [ValidateNever]
        public Student Student { get; set; }

        public int? JobPostId { get; set; }
        [ForeignKey("JobPostId")]
        [ValidateNever]
        public JobPost? jobPost { get; set; }

        public int? StatusId { get; set; }
        [ForeignKey("StatusId")]
        [ValidateNever]
        public ApplicationStatus? applicationStatus { get; set; }
        public virtual ICollection<ApplicationDocument> Documents { get; set; }
    }
}
