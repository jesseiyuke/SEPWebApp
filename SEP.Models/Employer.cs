using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SEP.Models
{
    public class Employer
    {
        [Key]
        public int Id { get; set; }
        [ValidateNever]
        public ApplicationUser ApplicationUser { get; set; }
        public string JobTitle { get; set; }
        [Required]
        public long CompanyRegNo { get; set; }
        [Required]
        public string BusinessName { get; set; }
        [Required]
        public string TradingName { get; set; }
        [Required]
        public string BusinessType { get; set; }
        [Required]
        public string RegisteredAddress { get; set; }

    }
}
