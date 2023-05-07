using System.ComponentModel.DataAnnotations;

namespace SEPWebApp.Models
{
    public class JobPost
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public EmployerType EmployerType { get; set; }
        [Required]
        public Faculty Faculty { get; set; }
        [Required]
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
        [Display(Name = "Fulltime or part-time")]
        public JobType JobType { get; set; }
        [Required]
        [Display(Name = "Part-time: Number of hours required in a week")]
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
        [Required]
        [Display(Name = "Limited to")]
        public YearOfStudy YearOfStudy { get; set; }
        [Required]
        [Display(Name = "Limited to")]
        public OpenTo OpenTo { get; set; }
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
        public int ContactNo { get; set; }

        [Display(Name = "Reviewer’s comment")]
        public string? ReviewerComment { get; set; }

        public Outcome? Outcome { get; set; }


    }


}
