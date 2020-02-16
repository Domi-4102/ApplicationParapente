
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationParapente.DataModel
{
    public partial class Vol
    {
        [Key]
        [Column("Id_Pilote")]
        public int IdPilote { get; set; }
        [Key]
        [Column("Id_Parapente")]
        public int IdParapente { get; set; }
        [Key]
        [Column("Id_Atterissage")]
        public int IdAtterissage { get; set; }
        [Key]
        [Column("Id_Decollage")]
        public int IdDecollage { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DateVol { get; set; }
        [Column(TypeName = "decimal(15, 2)")]
        public decimal? DureeVol { get; set; }

        [ForeignKey(nameof(IdAtterissage))]
        [InverseProperty(nameof(SiteAtterissage.Vol))]
        public virtual SiteAtterissage IdAtterissageNavigation { get; set; }
        [ForeignKey(nameof(IdDecollage))]
        [InverseProperty(nameof(SiteDecollage.Vol))]
        public virtual SiteDecollage IdDecollageNavigation { get; set; }
        [ForeignKey(nameof(IdParapente))]
        [InverseProperty(nameof(Parapente.Vol))]
        public virtual Parapente IdParapenteNavigation { get; set; }
        [ForeignKey(nameof(IdPilote))]
        [InverseProperty(nameof(Pilote.Vol))]
        public virtual Pilote IdPiloteNavigation { get; set; }
    }
}