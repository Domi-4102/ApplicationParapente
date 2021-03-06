﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationParapente.DataModel.Entities
{
    public partial class Internship : Model
    {
        public Internship()
        {
            Supervise = new HashSet<Supervise>();
            Take = new HashSet<Take>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column(TypeName = "date")]
        public DateTime? StartDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? EndDate { get; set; }
        [Column(TypeName = "decimal(15, 2)")]
        public decimal? Price { get; set; }
        [Column("Id_Certificate")]
        public int IdCertificate { get; set; }

        [ForeignKey(nameof(IdCertificate))]
        [InverseProperty(nameof(Certificate.Internship))]
        public virtual Certificate IdCertificateNavigation { get; set; }
        [InverseProperty("IdInternshipNavigation")]
        public virtual ICollection<Supervise> Supervise { get; set; }
        [InverseProperty("IdInternshipNavigation")]
        public virtual ICollection<Take> Take { get; set; }
    }
}