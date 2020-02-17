using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApplicationParapente.DataModel
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
        public decimal Weight { get; set; }
        public string Adress { get; set; }
        public string Tel { get; set; }
        public Function Function { get; set; }


    }
}
