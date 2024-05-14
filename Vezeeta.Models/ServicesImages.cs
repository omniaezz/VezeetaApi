﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezeeta.Models
{
    public class ServicesImages : BaseEntity
    {
        public string ImagePath { get; set; }

        [ForeignKey("Services")]
        public int ServiceId { get; set; }
        public Services Services { get; set; }
    }
}
