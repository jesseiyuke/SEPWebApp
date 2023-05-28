using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SEP.Models
{
    public class JobPost
    {
        [Key]
        public int Id { get; set; }

        [ValidateNever]
        public ApplicationUser ApplicationUser { get; set; }

        //EmoloyerType

        [BindProperty]
        public string EmoloyerType { get; set; }
        public string[] EmoloyerTypes = new[] { "Internal (within Wits)", "External (created on behalf of)" };

        [Required]
        public int FacultyId { get; set; }
        [ForeignKey("FacultyId")]
        [ValidateNever]
        public Faculty Faculty { get; set; }

        [Required]
        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        [ValidateNever]
        public Department Department { get; set; }

        [Required]
        [Display(Name = "Job title")]
        public string JobTitle { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        [Display(Name = "Description of job")]
        public string JobDescription { get; set; }
        [Required]
        [Display(Name = "Key responsibilities")]
        public string KeyResponsibilities { get; set; }

        [Required]
        public int JobTypeId { get; set; }
        [ForeignKey("JobTypeId")]
        [ValidateNever]
        public JobType JobType { get; set; }

        [Required]
        public int WeekHourId { get; set; }
        [ForeignKey("WeekHourId")]
        [ValidateNever]
        public WeekHour WeekHour { get; set; }

        [Required]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }
        [Required]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }
        [Required]
        [Display(Name = "Hourly Rate")]
        public string HourlyRate { get; set; }

        //YOS


        public bool FirstYear { get; set; }
        public bool SecondYear { get; set; }
        public bool ThirdYear { get; set; }
        public bool Honours { get; set; }
        public bool Graduates { get; set; }
        public bool Masters { get; set; }
        public bool PhD { get; set; }
        public bool Postdoc { get; set; }
        public bool FacultyCheck { get; set; }
        public bool DepartmentCheck { get; set; }


        /*        [BindProperty]
                public List<string> YearOfStudy { get; set; }
                public string[] YearOfStudys =
                    new[] { "Year 1", "Year 2", "Year 3", "Year 4","Honors",
                        "Master's", "PhD","Postdoc","Faculty","Department" };*/

        //CitizenOrNot

        [BindProperty]
        public string OpenTo { get; set; }
        public string[] OpenTos = new[] { "South African citizens or", "Open to everyone" };

        [Required]
        [Display(Name = "Minimum Requirements")]
        public string MinimumRequirements { get; set; }
        [Required]
        [Display(Name = "Application Instruction")]
        public string ApplicationInstruction { get; set; }
        [Required]
        [Display(Name = "Closing Date")]
        public DateTime ClosingDate { get; set; }
        [Required]
        [Display(Name = "Contact person (for internal use and not visible to students)")]
        public string ContactPerson { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Contact No")]
        public string ContactNo { get; set; }

        [Display(Name = "Reviewer’s comment")]
        public string? ReviewerComment { get; set; }

        [Required]
        [Display(Name = "Outcome")]
        public int StatusId { get; set; }
        [ForeignKey("StatusId")]
        [ValidateNever]
        public Status Status { get; set; }


    }


}
