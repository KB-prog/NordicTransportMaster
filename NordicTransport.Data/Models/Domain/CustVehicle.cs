﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordicTransport.Data.Models.Domain
{
    public class CustVehicle

    {

        [Key]
        public int CustVehicleID { get; set; }

        public DateTime TravelDate { get; set; }

        public double DistanceTravelled { get; set; }


        public virtual ICollection<Transaction> Transactions { get; set; }



    }
}