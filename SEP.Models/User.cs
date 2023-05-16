using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEP.Models
{
    public class User:Profile
    {
        [Required]
        [DataType(DataType.Password)]
        [NotMapped]
        

        public string rePassword { get; set; }

    }
}
