using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordicTransport.Data.Models.Domain
{
    public class HighwayToll
    {
        [Key]
        public int HighwayTollID { get; set; }

        public int TollPrice { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }

    }
}

