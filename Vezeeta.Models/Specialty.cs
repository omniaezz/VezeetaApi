﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezeeta.Models
{
    public class Specialty : BaseEntity
    {
        public string SpecialtyName { get; set; }

        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }

        public ICollection<Subspecialties> Subspecialties { get; set; }
    }
}
