using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SEP.Models
{
    public class Employer
    {
        public string Id { get; set; }
        [Required]
        [ForeignKey("Id")]
        public ApplicationUser ApplicationUser { get; set; }
        [Required]
        public string JobTitle { get; set; }
        [Required]
        public string CompanyRegNo { get; set; }
        [Required]
        public string BusinessName { get; set; }
        [Required]
        public string TradingName { get; set; }
        [Required]
        public int BusinessTypeId { get; set; }
        [ForeignKey("BusinessTypeId")]
        [ValidateNever]
        public BusinessType BusinessType { get; set; }
        [Required]
        public string RegisteredAddress { get; set; }

    }
}
