﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationParapente.DataModel
{
    [Table("PILOTE")]
    public partial class Pilote
    {
        public Pilote()
        {
            Encadre = new HashSet<Encadre>();
            Obtient = new HashSet<Obtient>();
            Passe = new HashSet<Passe>();
            Paye = new HashSet<Paye>();
            Vol = new HashSet<Vol>();
        }

        [Key]
        [Column("Id_Pilote")]
        public int IdPilote { get; set; }
        [StringLength(100)]
        public string Nom { get; set; }
        [StringLength(100)]
        public string Prenom { get; set; }
        [Column(TypeName = "decimal(15, 2)")]
        public decimal? Poids { get; set; }
        [StringLength(300)]
        public string Adresse { get; set; }
        [StringLength(100)]
        public string Tel { get; set; }
        [Column("Id_Fonction")]
        public int IdFonction { get; set; }

        [ForeignKey(nameof(IdFonction))]
        [InverseProperty(nameof(Fonction.Pilote))]
        public virtual Fonction IdFonctionNavigation { get; set; }
        [InverseProperty("IdPiloteNavigation")]
        public virtual ICollection<Encadre> Encadre { get; set; }
        [InverseProperty("IdPiloteNavigation")]
        public virtual ICollection<Obtient> Obtient { get; set; }
        [InverseProperty("IdPiloteNavigation")]
        public virtual ICollection<Passe> Passe { get; set; }
        [InverseProperty("IdPiloteNavigation")]
        public virtual ICollection<Paye> Paye { get; set; }
        [InverseProperty("IdPiloteNavigation")]
        public virtual ICollection<Vol> Vol { get; set; }
    }
}