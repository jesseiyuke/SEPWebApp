using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEP.Models
{
    public class Student
    {
        public string Id { get; set; }
        [Required]
        [ForeignKey("Id")]
        public ApplicationUser User { get; set; }

        [Required]
        public string Address { set; get; }

        public string IdNo { set; get; }
        [Required]
        public DriverLicense DriversLicense { set; get; }
        [Required]
        public string CareerObjective { set; get; }
        [Required]
        public Gender Gender { set; get; }
        [Required]
        public Race Race { set; get; }
        [Required]
        public Nationality Nationality { set; get; }
        [Required]
        public YearOfStudy YearOfStudy { set; get; }
        [Required]
        public Department Department { set; get; }
    }
}
