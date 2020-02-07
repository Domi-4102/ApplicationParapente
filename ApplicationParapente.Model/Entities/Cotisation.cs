using System;
using System.Collections.Generic;

namespace Parapente.Data.Entities
{
    public partial class Cotisation
    {
        public Cotisation()
        {
            #region Generated Constructor
            Payes = new HashSet<Paye>();
            #endregion
        }

        #region Generated Properties
        public int IdCotisation { get; set; }

        public decimal? Montant { get; set; }

        public DateTime? AnnéeCotisation { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Paye> Payes { get; set; }

        #endregion

    }
}
