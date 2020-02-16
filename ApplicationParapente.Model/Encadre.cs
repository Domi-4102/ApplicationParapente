﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationParapente.DataModel
{
    public partial class Encadre
    {
        [Key]
        [Column("Id_Pilote")]
        public int IdPilote { get; set; }
        [Key]
        [Column("Id_Stage")]
        public int IdStage { get; set; }

        [ForeignKey(nameof(IdPilote))]
        [InverseProperty(nameof(Pilote.Encadre))]
        public virtual Pilote IdPiloteNavigation { get; set; }
        [ForeignKey(nameof(IdStage))]
        [InverseProperty(nameof(Stage.Encadre))]
        public virtual Stage IdStageNavigation { get; set; }
    }
}