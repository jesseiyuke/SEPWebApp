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
        public string? Address { set; get; }
        public string? IdNo { set; get; }
        [ForeignKey(nameof(DriversLicenseId))]
        public int DriversLicenseId { get; set; }
        public DriverLicense? DriversLicense { set; get; }
        public string? CareerObjective { set; get; }
        [ForeignKey(nameof(GenderId))]
        public int GenderId { get; set; }
        public Gender? Gender { set; get; }
        [ForeignKey(nameof(RaceId))]
        public int RaceId { get; set; }
        public Race? Race { set; get; }
        [ForeignKey(nameof(NationalityId))]
        public int NationalityId { get; set; }
        public Nationality? Nationality { set; get; }
        [ForeignKey(nameof(YearOfStudyId))]
        public int YearOfStudyId { get; set; }
        public YearOfStudy? YearOfStudy { set; get; }
        [ForeignKey(nameof(DepartmentId))]
        public int DepartmentId { get; set; }
        public Department? Department { set; get; }
        public string? Skills { set; get; }
        public string? Achivements { set; get; }
        public string? Interests { set; get; }

    }
}
