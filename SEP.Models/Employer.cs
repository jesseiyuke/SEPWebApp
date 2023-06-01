using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SEP.Models
{
    public class Employer
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string JobTitle { get; set; }
        [Required]
        public string CompanyRegNo { get; set; }
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
