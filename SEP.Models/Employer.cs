using System.ComponentModel.DataAnnotations;

namespace SEP.Models
{
    public class Employer : Profile
    {

        public string Title { get; set; }
        [Required]
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
