﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Videos4You.Models
{
    public class Genre
    {
        public byte Id { get; set; }

        [Required]
        [StringLength(32)]
        public string Name { get; set; }

    }
}