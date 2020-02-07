using System;
using System.Collections.Generic;

namespace Parapente.Data.Entities
{
    public partial class Pilote
    {
        public Pilote()
        {
            #region Generated Constructor
            Encadres = new HashSet<Encadre>();
            Obtients = new HashSet<Obtient>();
            Passes = new HashSet<Passe>();
            Payes = new HashSet<Paye>();
            Vols = new HashSet<Vol>();
            #endregion
        }

        #region Generated Properties
        public int IdPilote { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public decimal? Poids { get; set; }

        public string Adresse { get; set; }

        public string Tel { get; set; }

        public int IdFonction { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Encadre> Encadres { get; set; }

        public virtual Fonction Fonction { get; set; }

        public virtual ICollection<Obtient> Obtients { get; set; }

        public virtual ICollection<Passe> Passes { get; set; }

        public virtual ICollection<Paye> Payes { get; set; }

        public virtual ICollection<Vol> Vols { get; set; }

        #endregion

    }
}
