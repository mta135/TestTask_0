﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestTask_0.Models
{
    public class CityInformation
    {
        public int Id { get; set; }

        public int Population { get; set; }

        public string OtherName { get; set; }

        public string MayorName { get; set; }

        public City City { get; set; }
    }
}
