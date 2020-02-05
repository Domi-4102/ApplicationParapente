using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationParapente.Model
{
    public class Cotisation: Models
    {
        public int Id { get; set; }
        public decimal Montant { get; set; }
        public DateTime AnneeCotisation { get; set; }
    }
}
