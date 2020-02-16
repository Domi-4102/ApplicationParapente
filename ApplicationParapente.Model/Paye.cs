﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationParapente.DataModel
{
    public partial class Paye
    {
        [Key]
        [Column("Id_Pilote")]
        public int IdPilote { get; set; }
        [Key]
        [Column("Id_Cotisation")]
        public int IdCotisation { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DateCotisation { get; set; }

        [ForeignKey(nameof(IdCotisation))]
        [InverseProperty(nameof(Cotisation.Paye))]
        public virtual Cotisation IdCotisationNavigation { get; set; }
        [ForeignKey(nameof(IdPilote))]
        [InverseProperty(nameof(Pilote.Paye))]
        public virtual Pilote IdPiloteNavigation { get; set; }
    }
}