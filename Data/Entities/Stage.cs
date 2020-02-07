using System;
using System.Collections.Generic;

namespace Parapente.Data.Entities
{
    public partial class Stage
    {
        public Stage()
        {
            #region Generated Constructor
            Encadres = new HashSet<Encadre>();
            Passes = new HashSet<Passe>();
            #endregion
        }

        #region Generated Properties
        public int IdStage { get; set; }

        public DateTime? DateDebut { get; set; }

        public DateTime? DateFin { get; set; }

        public decimal? Prix { get; set; }

        public int? NiveauRequis { get; set; }

        public int IdBrevet { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Brevet Brevet { get; set; }

        public virtual ICollection<Encadre> Encadres { get; set; }

        public virtual ICollection<Passe> Passes { get; set; }

        #endregion

    }
}
