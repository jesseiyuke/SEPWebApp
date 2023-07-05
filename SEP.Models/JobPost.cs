using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SEP.Models
{
    public class JobPost
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ApplicationUserId { get; set; }
        [ForeignKey("ApplicationUserId")]
        [ValidateNever]
        public ApplicationUser ApplicationUser { get; set; }


        //EmoloyerType

        [BindProperty]
        [Required]
        [DisplayName("Employer Type")]
        public string EmoloyerType { get; set; }
        public string[] EmoloyerTypes = new[] { "Internal", "External" };

        [Required]
        [DisplayName("Faculty")]
        public int FacultyId { get; set; }
        [ForeignKey("FacultyId")]
        [ValidateNever]
        public Faculty Faculty { get; set; }

        [Required]
        [DisplayName("Department")]
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
        [Display(Name = "Job Description")]
        public string JobDescription { get; set; }
        [Required]
        [Display(Name = "Key responsibilities")]
        public string KeyResponsibilities { get; set; }

        [Required]
        [Display(Name = "Job Type")]
        public int JobTypeId { get; set; }
        [ForeignKey("JobTypeId")]
        [ValidateNever]
        public JobType JobType { get; set; }

        [Required]
        [Display(Name = "Week hour")]
        public int WeekHourId { get; set; }
        [ForeignKey("WeekHourId")]
        [ValidateNever]
        public WeekHour WeekHour { get; set; }

        [Required]
        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "End Date")]
        public DateTime? EndDate { get; set; }
        [Required]
        [Display(Name = "Hourly Rate")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Hourly Rate must contain only numbers.")]
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
        [Required]
        [DisplayName("Nationality")]
        public string OpenTo { get; set; }
        public string[] OpenTos = new[] { "South African citizens", "Open to everyone" };

        [Required]
        [Display(Name = "Minimum Requirements")]
        public string MinimumRequirements { get; set; }
        [Required]
        [Display(Name = "Application Instruction")]
        public string ApplicationInstruction { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Closing Date")]
        public DateTime? ClosingDate { get; set; }
        [Required]
        [Display(Name = "Contact person")]
        public string ContactPerson { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Contact Number")]
        [StringLength(10, ErrorMessage = "Must be 10 digits")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Contact number must contain only numbers.")]
        public string ContactNo { get; set; }

        [Display(Name = "Reviewer’s comment")]
        public string? ReviewerComment { get; set; }

        [Required]
        [Display(Name = "Outcome")]
        public int StatusId { get; set; }
        [ForeignKey("StatusId")]
        [ValidateNever]
        public ApplicationStatus ApplicationStatus { get; set; }


    }


}
