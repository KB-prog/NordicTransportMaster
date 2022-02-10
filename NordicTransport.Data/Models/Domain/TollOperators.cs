using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordicTransport.Data.Models.Domain
{
    public class TollOperators

    {

        [Key]
        public int TollOperatorID { get; set; }
        public string TollName { get; set; }
        public virtual ICollection<HighwayToll> HighwayTolls { get; set; } 
    }
}