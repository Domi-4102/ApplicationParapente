using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApplicationParapente.DataModel.Entities
{
    public class LandingSite
    {
        public LandingSite()
        {

        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Orientation { get; set; }
        public string Description { get; set; }
    }
}
