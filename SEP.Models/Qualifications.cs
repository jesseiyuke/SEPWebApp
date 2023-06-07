using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public  Student Student { get; set; }

        public string Institution { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Qalificatiion { get; set; }
        public string Subjects { get; set; }
        public string Majors { get; set; }
        public string SubMajors { get; set; }
        public string Research { get; set; }  
     }
}
