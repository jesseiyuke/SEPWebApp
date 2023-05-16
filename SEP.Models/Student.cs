using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SEP.Models
{
    public class Student:Profile
    {
        [Required]
        public string Address { set; get; }
        
        public string IdNo { set; get; }
        [Required]
        public string DriversLicense { set; get; }
        [Required]
        public string CareerObjective { set; get; }
        [Required]
        public string Gender { set; get; }
        [Required]
        public string Race { set; get; }
        [Required]
        public string Nationality { set; get; }
        [Required]
        public string YOS { set; get; }
        [Required]
        public int DepartmentId { set; get; }
    }
}
