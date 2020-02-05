using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationParapente.Model
{
    public class Encadre:Models
    {
        public virtual ICollection<Pilote> Pilotes { get; set; }
        public virtual ICollection<Stage> Stages { get; set; }
    }
}
