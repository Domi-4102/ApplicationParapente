using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationParapente.Model
{
    public class ModeleParapente:Models
    {
        public int Id { get; set; }
        public string NumeroHomologation { get; set; }
        public DateTime DateHomologation { get; set; }
        public Decimal Taille { get; set; }
        public Decimal PoidsMin { get; set; }
        public Decimal PoidsMax { get; set; }
    }
}
