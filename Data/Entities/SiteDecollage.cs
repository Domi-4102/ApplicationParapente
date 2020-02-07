using System;
using System.Collections.Generic;

namespace Parapente.Data.Entities
{
    public partial class SiteDecollage
    {
        public SiteDecollage()
        {
            #region Generated Constructor
            Vols = new HashSet<Vol>();
            #endregion
        }

        #region Generated Properties
        public int IdDecollage { get; set; }

        public string Nom { get; set; }

        public string Orientation { get; set; }

        public string Description { get; set; }

        public int? NiveauRequis { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Vol> Vols { get; set; }

        #endregion

    }
}
