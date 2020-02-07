using System;
using System.Collections.Generic;

namespace Parapente.Data.Entities
{
    public partial class Obtient
    {
        public Obtient()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int IdPilote { get; set; }

        public int IdBrevet { get; set; }

        public DateTime? DateObtention { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Brevet Brevet { get; set; }

        public virtual Pilote Pilote { get; set; }

        #endregion

    }
}
