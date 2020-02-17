using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApplicationParapente.DataModel
{
    class Fonction
    {
        public Fonction()
        {

        }
        [Key]
        public int id { get; set; }
        public string  Label { get; set; }
    }
}
