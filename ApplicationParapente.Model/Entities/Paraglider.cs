using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationParapente.DataModel
{
    public class Paraglider
    {
        public Paraglider() { }

        public int Id { get; set; }
        public DateTime ServiceDate { get; set; }
        public DateTime LastUseDate { get; set; }
        public ParagliderModel ParagliderModel { get; set; }
    }

   
}
