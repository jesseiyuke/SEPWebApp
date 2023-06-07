using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string Name { get; set; }
        public string JobTitle { get; set; }
        public string Insitution { get; set; }
        public string Cell { get; set; }
        public string Email { get; set; }
    }
}
