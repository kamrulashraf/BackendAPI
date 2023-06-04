﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
    public class Status
    {
        [Key]
        [Required]
        public int StatusID { get; set; }
        [Required]
        public string StatusName { get; set; }
    }
}
