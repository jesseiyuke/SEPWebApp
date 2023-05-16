using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEP.Models
{
    public abstract class Profile
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public Roles Role { get; set; }

        [Phone]
        public String ? Telephone { get; set; }
        [Required]
        [Phone]
        public String Cellphone { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
