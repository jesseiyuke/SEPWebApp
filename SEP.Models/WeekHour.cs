using System.ComponentModel.DataAnnotations;

namespace SEP.Models
{
    public class WeekHour
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}

