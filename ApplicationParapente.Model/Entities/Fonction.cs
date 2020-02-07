using System;
using System.Collections.Generic;

namespace Parapente.Data.Entities
{
    public partial class Fonction
    {
        public Fonction()
        {
            #region Generated Constructor
            Pilotes = new HashSet<Pilote>();
            #endregion
        }

        #region Generated Properties
        public int IdFonction { get; set; }

        public string Label { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Pilote> Pilotes { get; set; }

        #endregion

    }
}
