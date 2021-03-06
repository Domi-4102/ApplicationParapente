﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationParapente.DataModel.Entities
{
    public partial class Take : Model
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Key]
        [Column("Id_Internship")]
        public int IdInternship { get; set; }
        [Column("examen")]
        public bool Examen { get; set; }
        public bool? Payement { get; set; }

        [ForeignKey(nameof(IdInternship))]
        [InverseProperty(nameof(Internship.Take))]
        public virtual Internship IdInternshipNavigation { get; set; }
        [ForeignKey(nameof(Id))]
        [InverseProperty(nameof(Pilot.Take))]
        public virtual Pilot IdNavigation { get; set; }
    }
}