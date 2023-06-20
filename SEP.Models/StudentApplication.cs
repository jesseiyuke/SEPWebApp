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
        public Student Student { get; set; }

        [ForeignKey("JobPostId")]
        public int JobPostId { get; set; }
        public JobPost? jobPost { get; set; }
        public string status { get; set; }
    }
}
