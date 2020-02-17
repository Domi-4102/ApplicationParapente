using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApplicationParapente.DataModel
{
    public class Pay
    {
        public Pay() { }


        [Key]
        public int Id { get; set; }
        public DateTime AmountYear { get; set; }
        public DateTime CotisationDate { get; set; }
        public Pilote Pilote { get; set; }
        public MembershipFee MembershipFee { get; set; }


    }
}
