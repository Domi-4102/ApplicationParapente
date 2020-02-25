﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationParapente.DataModel.Entities
{
    public partial class Pay : Model
    {
        [Key]
        public short Id { get; set; }
        [Key]
        [Column(TypeName = "date")]
        public DateTime AmountYear { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DateCotisation { get; set; }

        [ForeignKey(nameof(AmountYear))]
        [InverseProperty(nameof(MemberShipFee.Pay))]
        public virtual MemberShipFee AmountYearNavigation { get; set; }
        [ForeignKey(nameof(Id))]
        [InverseProperty(nameof(Pilot.Pay))]
        public virtual Pilot IdNavigation { get; set; }
    }
}