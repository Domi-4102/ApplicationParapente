﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationParapente.DataModel
{
    [Table("SITE_ATTERISSAGE")]
    public partial class SiteAtterissage
    {
        public SiteAtterissage()
        {
            Vol = new HashSet<Vol>();
        }

        [Key]
        [Column("Id_Atterissage")]
        public int IdAtterissage { get; set; }
        [StringLength(100)]
        public string Nom { get; set; }
        [StringLength(50)]
        public string Orientation { get; set; }
        [StringLength(100)]
        public string Description { get; set; }
        public int? NiveauRequis { get; set; }

        [InverseProperty("IdAtterissageNavigation")]
        public virtual ICollection<Vol> Vol { get; set; }
    }
}