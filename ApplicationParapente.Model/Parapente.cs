using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationParapente.Model
{
    public class Parapente:Models
    {
        public int Id { get; set; }
        public DateTime DateMiseEnService { get; set; }
        public DateTime DateDerniereRevision { get; set; }

    }
}
