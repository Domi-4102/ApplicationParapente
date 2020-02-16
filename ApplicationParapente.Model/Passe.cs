﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationParapente.DataModel
{
    public partial class Passe
    {
        [Key]
        [Column("Id_Pilote")]
        public int IdPilote { get; set; }
        [Key]
        [Column("Id_Stage")]
        public int IdStage { get; set; }
        [Column("examen")]
        public bool Examen { get; set; }
        public bool Payement { get; set; }

        [ForeignKey(nameof(IdPilote))]
        [InverseProperty(nameof(Pilote.Passe))]
        public virtual Pilote IdPiloteNavigation { get; set; }
        [ForeignKey(nameof(IdStage))]
        [InverseProperty(nameof(Stage.Passe))]
        public virtual Stage IdStageNavigation { get; set; }
    }
}