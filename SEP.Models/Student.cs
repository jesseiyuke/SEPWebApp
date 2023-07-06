using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SEP.Models
{
    public class Student
    {
        public string Id { get; set; }
        [Required]
        [ForeignKey("Id")]
        public ApplicationUser ApplicationUser { get; set; }

        [Required]
        [DisplayName("Address")]
        public string Address { set; get; }
        [RegularExpression("(([0-9]{2})(0|1)([0-9])([0-3])([0-9]))([ ]?)(([ 0-9]{4})([ ]?)([ 0-1][8]([ ]?)[ 0-9]))", ErrorMessage = "Invalid ID number")]
        public string? IdNo { set; get; }
        [Required]
        [DisplayName("Drivers License")]
        [ForeignKey(nameof(DriversLicenseId))]
        public int DriversLicenseId { get; set; }
        public DriverLicense? DriversLicense { set; get; }
        public string? CareerObjective { set; get; }
        [ForeignKey(nameof(GenderId))]
        [Required]
        [DisplayName("Gender")]
        public int GenderId { get; set; }
        public Gender? Gender { set; get; }
        [ForeignKey(nameof(RaceId))]
        [Required]
        [DisplayName("Race")]
        public int RaceId { get; set; }
        public Race? Race { set; get; }
        [ForeignKey(nameof(NationalityId))]
        [Required]
        [DisplayName("Nationality")]
        public int NationalityId { get; set; }
        public Nationality? Nationality { set; get; }
        [ForeignKey(nameof(YearOfStudyId))]
        [Required]
        [DisplayName("Year of study")]
        public int YearOfStudyId { get; set; }
        public YearOfStudy? YearOfStudy { set; get; }
        [ForeignKey(nameof(DepartmentId))]
        [Required]
        [DisplayName("Department")]
        public int DepartmentId { get; set; }
        public Department? Department { set; get; }
        public string? Skills { set; get; }
        public string? Achivements { set; get; }
        public string? Interests { set; get; }

    }
}
