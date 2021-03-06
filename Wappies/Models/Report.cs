﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Wappies.Models
{
    public class Report
    {
        public int ID { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Created { get; set; }

        public bool Completed { get; set; }

        public List<Location> Locations { get; set; }
    }
}
