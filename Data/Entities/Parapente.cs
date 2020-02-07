using System;
using System.Collections.Generic;

namespace Parapente.Data.Entities
{
    public partial class Parapente
    {
        public Parapente()
        {
            #region Generated Constructor
            Vols = new HashSet<Vol>();
            #endregion
        }

        #region Generated Properties
        public int IdParapente { get; set; }

        public DateTime? DateMiseEnService { get; set; }

        public DateTime? DateDerniereRevision { get; set; }

        public int IdModele { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ModeleParapente ModeleParapente { get; set; }

        public virtual ICollection<Vol> Vols { get; set; }

        #endregion

    }
}
