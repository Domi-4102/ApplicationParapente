using System;
using System.Collections.Generic;

namespace Parapente.Data.Entities
{
    public partial class Niveau
    {
        public Niveau()
        {
            #region Generated Constructor
            Brevets = new HashSet<Brevet>();
            #endregion
        }

        #region Generated Properties
        public int IdNiveau { get; set; }

        public string Intitulé { get; set; }

        public string Description { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Brevet> Brevets { get; set; }

        #endregion

    }
}
