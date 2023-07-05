using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SEP.Models
{
    public class Employer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ApplicationUserId { get; set; }
        [ForeignKey("ApplicationUserId")]
        [ValidateNever]
        public ApplicationUser ApplicationUser { get; set; }
        [Required]
        [DisplayName("Job Title")]
        public string JobTitle { get; set; }
        [Required]
        [DisplayName("Company registration number")]
        public string CompanyRegNo { get; set; }
        [Required]
        [DisplayName("Business Name")]
        public string BusinessName { get; set; }
        [Required]
        [DisplayName("Trading name")]
        public string TradingName { get; set; }
        [Required]
        [DisplayName("Business Type")]
        public int BusinessTypeId { get; set; }
        [ForeignKey("BusinessTypeId")]
        [ValidateNever]
        public BusinessType BusinessType { get; set; }
        [Required]
        [DisplayName("Registered Address")]
        public string RegisteredAddress { get; set; }

        [Required]
        [Display(Name = "Outcome")]
        public int StatusId { get; set; }
        [ForeignKey("StatusId")]
        [ValidateNever]
        public Status Status { get; set; }



    }
}
