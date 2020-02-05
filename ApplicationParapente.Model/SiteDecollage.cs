using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationParapente.Model
{
    public class SiteDecollage:Models
    {
        public int id { get; set; }
        public string Nom { get; set; }
        public string Orientation { get; set; }
        public string Description { get; set; }
        public int NiveauRequis { get; set; }
    }
}
