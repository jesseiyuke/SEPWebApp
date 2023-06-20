﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEP.Models
{
    public class ApplicationDocument
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("ApplicationId")]
        public int ApplicationId { get; set; }
        public StudentApplication StudentApplication { get; set; }
        public string Name { get; set; }
        public string FilePath { get; set; }


    }
    }
