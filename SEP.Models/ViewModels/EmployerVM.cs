using System.ComponentModel.DataAnnotations;

namespace SEP.Models.ViewModels
{
    public class EmployerVM
    {
        //Application user
        public string? Title { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Telephone { get; set; }

        //Employer
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


        /*        [ValidateNever]
                public Employer Employer { get; set; }*/
    }
}
