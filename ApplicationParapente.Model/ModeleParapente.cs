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
        public decimal Taille { get; set; }
        public decimal PoidsMin { get; set; }
        public decimal PoidsMax { get; set; }
    }
}
