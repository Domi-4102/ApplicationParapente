using ApplicationParapente.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationParapente.Models
{
    public class PiloteViewModel:Model
    {
        #region Properties
        public int IdPilote { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        #endregion
    }
}
