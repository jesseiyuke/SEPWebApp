using System.ComponentModel.DataAnnotations;

namespace SEP.Models
{
    public class Faculty
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Department> Departments { get; set; }
    }
}
