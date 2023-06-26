using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SEP.Models
{
    public class StudentApplication
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ApplicationUserId { get; set; }
        [ForeignKey("ApplicationUserId")]
        [ValidateNever]
        public ApplicationUser ApplicationUser { get; set; }

        public int? JobPostId { get; set; }
        [ForeignKey("JobPostId")]
        [ValidateNever]
        public JobPost? jobPost { get; set; }

        //From JobPost model

        [Required]
        [Display(Name = "Job title")]
        public string JobTitle { get; set; }

        [Required]
        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        [ValidateNever]
        public Department Department { get; set; }

        [Required]
        public int WeekHourId { get; set; }
        [ForeignKey("WeekHourId")]
        [ValidateNever]
        public WeekHour WeekHour { get; set; }

        [Required]
        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }


        [Required]
        [Display(Name = "Outcome")]
        public int StatusId { get; set; }
        [ForeignKey("StatusId")]
        [ValidateNever]
        public Status Status { get; set; }

        //Student Details
        [ForeignKey(nameof(FacultyId))]
        public int FacultyId { get; set; }
        public Faculty? Faculty { get; set; }

        [ForeignKey(nameof(StudentDepartmentId))]
        public int? StudentDepartmentId { get; set; }
        public Department? StudentDepartment { set; get; }

        [ForeignKey(nameof(YearOfStudyId))]
        public int YearOfStudyId { get; set; }
        public YearOfStudy? YearOfStudy { set; get; }

        [ForeignKey(nameof(GenderId))]
        public int GenderId { get; set; }
        public Gender? Gender { set; get; }

        [ForeignKey(nameof(NationalityId))]
        public int NationalityId { get; set; }
        public Nationality? Nationality { set; get; }

        /*        [Required]
                public int StudentId { get; set; }
                [ForeignKey("StudentId")]
                [ValidateNever]
                public Student Student { get; set; }*/
    }
}
