using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApplicationParapente.DataModel.Entities
{
    public class Pay
    {
        public Pay() { }


        [Key]
        public int Id { get; set; }
        public DateTime AmountYear { get; set; }
        public DateTime CotisationDate { get; set; }
        public Pilote Pilote { get; set; }
        public Cotisation Cotisation { get; set; }


    }
}
