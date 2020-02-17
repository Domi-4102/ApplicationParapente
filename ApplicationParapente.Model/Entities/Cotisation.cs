using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApplicationParapente.DataModel.Entities
{
    public class Cotisation
    {
        public Cotisation() { }

        [Key]
        public DateTime AmountYear { get; set; }
        public decimal Amount { get; set; }
    }
}
