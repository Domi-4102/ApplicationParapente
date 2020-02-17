using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApplicationParapente.DataModel.Entities
{
    public class Level
    {
        public Level()
        {

        }
        [Key]
        public int Id { get; set; }
        public string Intitule { get; set; }
        public string Description { get; set; }
    }
}
