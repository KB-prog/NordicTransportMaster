using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordicTransport.Data.Models.Domain
{ 
public class Users

    {

        [Key]
        [Required]
        public int UserID { get; set; }

        public string UForename { get; set; }

        public string USurname { get; set; }

        public DateTime UDOB { get; set; }

        public string UAddress { get; set; }

        public string UPostcode { get; set; }

        public string UEmail { get; set; }


        [Required]
        public string UPassword { get; set; } 


        public virtual ICollection<Contracts> Contracts { get; set; }

        public virtual ICollection<TollOperators> TollOperators { get; set; }

    }
}