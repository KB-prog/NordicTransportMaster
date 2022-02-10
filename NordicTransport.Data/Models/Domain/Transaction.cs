using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordicTransport.Data.Models.Domain
{
    public class Transaction

    {

        [Key]
        public int TransactionID { get; set; } 

        public int Total { get; set; }

    }
}