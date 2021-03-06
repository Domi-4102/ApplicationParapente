﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationParapente.DataModel.Entities
{
    public partial class Obtain : Model
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Key]
        [Column("Id_Certificate")]
        public int IdCertificate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ObtainingDate { get; set; }

        [ForeignKey(nameof(IdCertificate))]
        [InverseProperty(nameof(Certificate.Obtain))]
        public virtual Certificate IdCertificateNavigation { get; set; }
        [ForeignKey(nameof(Id))]
        [InverseProperty(nameof(Pilot.Obtain))]
        public virtual Pilot IdNavigation { get; set; }
    }
}