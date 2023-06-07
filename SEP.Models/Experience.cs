using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string EmployerName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string JobTitle { get; set; }
        public string TasksAndResponsilities { get; set; }

    }
}
