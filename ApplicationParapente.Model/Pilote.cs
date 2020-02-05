using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationParapente.Model
{
    public  class Pilote:Models 
    {
        public int id { get; set; }
        public string  nom { get; set; }
        public string prenom { get; set; }

        public decimal Poids { get; set; }

        public string Adresse { get; set; }
        public string tel { get; set; }
    }
}
