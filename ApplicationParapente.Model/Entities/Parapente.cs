
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationParapente.DataModel
{
    [Table("PARAPENTE")]
    public partial class Parapente
    {
        public Parapente()
        {
            Vol = new HashSet<Vol>();
        }

        [Key]
        [Column("Id_Parapente")]
        public int IdParapente { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DateMiseEnService { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DateDerniereRevision { get; set; }
        [Column("Id_Modele")]
        public int IdModele { get; set; }

        [ForeignKey(nameof(IdModele))]
        [InverseProperty(nameof(ModeleParapente.Parapente))]
        public virtual ModeleParapente IdModeleNavigation { get; set; }
        [InverseProperty("IdParapenteNavigation")]
        public virtual ICollection<Vol> Vol { get; set; }
    }
}