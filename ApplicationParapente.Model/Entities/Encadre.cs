using System;
using System.Collections.Generic;

namespace Parapente.Data.Entities
{
    public partial class Encadre
    {
        public Encadre()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int IdPilote { get; set; }

        public int IdStage { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Pilote Pilote { get; set; }

        public virtual Stage Stage { get; set; }

        #endregion

    }
}
