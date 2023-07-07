using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SEP.Models
{
    public class Qualifications
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(StudentId))]
        public string StudentId { get; set; }
        [Required]
        public Student Student { get; set; }
        [Required]
        [DisplayName("Institution")]

        public string Institution { get; set; }
        [Required]
        [DisplayName("Start Date")]
        public DateTime StartDate { get; set; }
        [Required]
        [DisplayName("End Date")]
        public DateTime EndDate { get; set; }
        [Required]
        [DisplayName("Qualification")]
        public string Qalificatiion { get; set; }
        public string? Subjects { get; set; }
        public string? Majors { get; set; }
        public string? SubMajors { get; set; }
        public string? Research { get; set; }
    }
}
