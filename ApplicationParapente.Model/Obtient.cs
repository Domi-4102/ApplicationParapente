﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationParapente.DataModel
{
    public partial class Obtient
    {
        [Key]
        [Column("Id_Pilote")]
        public int IdPilote { get; set; }
        [Key]
        [Column("Id_Brevet")]
        public int IdBrevet { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DateObtention { get; set; }

        [ForeignKey(nameof(IdBrevet))]
        [InverseProperty(nameof(Brevet.Obtient))]
        public virtual Brevet IdBrevetNavigation { get; set; }
        [ForeignKey(nameof(IdPilote))]
        [InverseProperty(nameof(Pilote.Obtient))]
        public virtual Pilote IdPiloteNavigation { get; set; }
    }
}