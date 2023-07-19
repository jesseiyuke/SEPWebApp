using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SEP.Models
{
    public class Referees
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(StudentId))]
        public string StudentId { get; set; }
        [Required]
        public Student Student { get; set; }
        [Required]
        [DisplayName("Name")]
        public string Name { get; set; }
        [Required]
        [DisplayName("Job Title")]
        public string JobTitle { get; set; }
        [Required]
        [DisplayName("Insitution")]
        public string Insitution { get; set; }
        [Required]
        [DisplayName("Cellphone")]
        [StringLength(10, ErrorMessage = "Must be 10 digits")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Cellphone number must contain only numbers.")]
        public string Cell { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
