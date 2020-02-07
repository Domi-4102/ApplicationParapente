using System;
using System.Collections.Generic;

namespace Parapente.Data.Entities
{
    public partial class Paye
    {
        public Paye()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int IdPilote { get; set; }

        public int IdCotisation { get; set; }

        public DateTime? DateCotisation { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Cotisation Cotisation { get; set; }

        public virtual Pilote Pilote { get; set; }

        #endregion

    }
}
