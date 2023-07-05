using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SEP.Models
{
    public class Experience
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(StudentId))]
        public string StudentId { get; set; }
        [Required]
        public Student Student { get; set; }
        [Required]
        [DisplayName("Employer Name")]
        public string EmployerName { get; set; }
        [Required]
        [DisplayName("Start Date")]
        public DateTime StartDate { get; set; }
        [Required]
        [DisplayName("End Date")]
        public DateTime EndDate { get; set; }
        [Required]
        [DisplayName("Job Title")]
        public string JobTitle { get; set; }
        [Required]
        [DisplayName("Tasks And Responsilities")]
        public string TasksAndResponsilities { get; set; }

    }
}
