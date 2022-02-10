﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordicTransport.Data.Models.Domain
{
    public class Roles

    {

        [Key]
        public int RoleID { get; set; }

        public string RoleName { get; set; }

        public string Currency { get; set; }

        public virtual ICollection<Users> Users { get; set; }

    }
}