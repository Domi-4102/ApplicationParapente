using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApplicationParapente.DataModel.Entities
{
    public class Pilote
    {
        public Pilote()
        {


        }

        [Key]
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public decimal Poids { get; set; }
        public string Adress { get; set; }
        public string Tel { get; set; }
       // public Fonction Foction { }


    }
}
