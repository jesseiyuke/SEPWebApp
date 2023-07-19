using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SEP.Models
{
    public class WeekHour
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [ForeignKey(nameof(JobTypeId))]
        public int JobTypeId { get; set; }
        [Required]
        public JobType JobType { get; set; }
    }
}

