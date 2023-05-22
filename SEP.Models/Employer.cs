using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SEP.Models
{
    public class Employer
    {
        public string Id { get; set; }
        [Required]
        [ForeignKey("Id")]
        public ApplicationUser User { get; set; }
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
