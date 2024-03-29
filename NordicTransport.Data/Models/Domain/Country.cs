﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordicTransport.Data.Models.Domain 
{ 
    public class Country
    {
        [Key]
        public int CountryID { get; set; }

        public string CountryName { get; set; }

        public string Currency { get; set; }
            
        public virtual ICollection<Users> Users { get; set; }

    }
}
