using System;
using System.Collections.Generic;

namespace Parapente.Data.Entities
{
    public partial class Brevet
    {
        public Brevet()
        {
            #region Generated Constructor
            Obtients = new HashSet<Obtient>();
            Stages = new HashSet<Stage>();
            #endregion
        }

        #region Generated Properties
        public int IdBrevet { get; set; }

        public string Label { get; set; }

        public int IdNiveau { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Niveau Niveau { get; set; }

        public virtual ICollection<Obtient> Obtients { get; set; }

        public virtual ICollection<Stage> Stages { get; set; }

        #endregion

    }
}
