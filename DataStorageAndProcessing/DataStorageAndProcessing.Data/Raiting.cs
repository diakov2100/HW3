﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStorageAndProcessing.Data
{
    public class Raiting
    {
        public int Year { get; set; }
        public List<InstitutionRaiting> Institutions { get; set; }
    }
}
