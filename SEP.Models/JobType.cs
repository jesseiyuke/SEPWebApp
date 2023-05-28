using System.ComponentModel.DataAnnotations;

namespace SEP.Models
{
    public class JobType
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
