using System;
using System.Collections.Generic;

namespace Parapente.Data.Entities
{
    public partial class Passe
    {
        public Passe()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int IdPilote { get; set; }

        public int IdStage { get; set; }

        public bool Examen { get; set; }

        public bool Payement { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Pilote Pilote { get; set; }

        public virtual Stage Stage { get; set; }

        #endregion

    }
}
