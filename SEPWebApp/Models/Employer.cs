using System.ComponentModel.DataAnnotations;

namespace SEPWebApp.Models
{
    public class Employer
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string EmailAndUsername { get; set; }
        [Required]
        public int Telephone { get; set; }
        [Required]
        public int Cellphone { get; set; }
        [Required]
        public string JobTitle { get; set; }
        [Required]
        public int CompanyRegNo { get; set; }
        [Required]
        public string BusinessName { get; set; }
        [Required]
        public string TradingName { get; set; }
        [Required]
        public string BusinessType { get; set; }
        [Required]
        public string RegisteredAddress { get; set; }
        [Required]
        public string Password { get; set; }

    }
}
