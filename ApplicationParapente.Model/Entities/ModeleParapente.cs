using System;
using System.Collections.Generic;

namespace Parapente.Data.Entities
{
    public partial class ModeleParapente
    {
        public ModeleParapente()
        {
            #region Generated Constructor
            Parapentes = new HashSet<Parapente>();
            #endregion
        }

        #region Generated Properties
        public int IdModele { get; set; }

        public string NumeroHomologation { get; set; }

        public string DateHomologation { get; set; }

        public decimal? Taille { get; set; }

        public decimal? PoidsMin { get; set; }

        public decimal? PoidMax { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<Parapente> Parapentes { get; set; }

        #endregion

    }
}
