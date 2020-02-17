using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApplicationParapente.DataModel
{
    public class Obtein
    {
        public Obtein() { }
        [Key]
        public int id { get; set; }
        public DateTime ObtainingDate { get; set; }
        public Pilote Pilote { get; set; }
        public Certificate Certificate { get; set; }
    }

}
