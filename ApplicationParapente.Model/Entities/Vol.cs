using System;
using System.Collections.Generic;

namespace Parapente.Data.Entities
{
    public partial class Vol
    {
        public Vol()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int IdPilote { get; set; }

        public int IdParapente { get; set; }

        public int IdAtterissage { get; set; }

        public int IdDecollage { get; set; }

        public DateTime? DateVol { get; set; }

        public decimal? DureeVol { get; set; }

        #endregion

        #region Generated Relationships
        public virtual Parapente Parapente { get; set; }

        public virtual Pilote Pilote { get; set; }

        public virtual SiteAtterissage SiteAtterissage { get; set; }

        public virtual SiteDecollage SiteDecollage { get; set; }

        #endregion

    }
}
