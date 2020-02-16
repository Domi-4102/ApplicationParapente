﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationParapente.DataModel
{
    [Table("STAGE")]
    public partial class Stage
    {
        public Stage()
        {
            Encadre = new HashSet<Encadre>();
            Passe = new HashSet<Passe>();
        }

        [Key]
        [Column("Id_Stage")]
        public int IdStage { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DateDebut { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DateFin { get; set; }
        [Column(TypeName = "decimal(15, 2)")]
        public decimal? Prix { get; set; }
        public int? NiveauRequis { get; set; }
        [Column("Id_Brevet")]
        public int IdBrevet { get; set; }

        [ForeignKey(nameof(IdBrevet))]
        [InverseProperty(nameof(Brevet.Stage))]
        public virtual Brevet IdBrevetNavigation { get; set; }
        [InverseProperty("IdStageNavigation")]
        public virtual ICollection<Encadre> Encadre { get; set; }
        [InverseProperty("IdStageNavigation")]
        public virtual ICollection<Passe> Passe { get; set; }
    }
}