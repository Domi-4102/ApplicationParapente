using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApplicationParapente.DataModel
{
    class MembershipFee
    {
        public MembershipFee() 
        { 

        }

        [Key]
        public DateTime AmountYear { get; set; }
        public decimal Amount { get; set; }
    }
}
