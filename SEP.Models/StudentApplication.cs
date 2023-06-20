using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEP.Models
{
    public class StudentApplication
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [ForeignKey("StudentId")]
        public string StudentId { get; set; }
        public Student? Student { get; set; }

        [ForeignKey("JobPostId")]
        public int JobPostId { get; set; }
        public JobPost? jobPost { get; set; }
        public string status { get; set; }
    }
}
