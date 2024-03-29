﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordicTransport.Data.Models.Domain
{
    public class Location
    {
        [Key]
        public int LocationID { get; set; }

        public string LocationName { get; set; }

        public string LocationAddress { get; set; }

        public virtual ICollection<TollOperators> TollOperators { get; set; }
    }
}
