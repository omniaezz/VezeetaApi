﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezeeta.Dtos.Dtos.CountriesDtos
{
    public class CountryDto
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
        public ICollection<CountryImagesDto> countryImagesDtos { get; set; }
    }
}
