﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationParapente.DataModel
{
    [Table("SITE_DECOLLAGE")]
    public partial class SiteDecollage
    {
        public SiteDecollage()
        {
            Vol = new HashSet<Vol>();
        }

        [Key]
        [Column("Id_Decollage")]
        public int IdDecollage { get; set; }
        [StringLength(100)]
        public string Nom { get; set; }
        [StringLength(50)]
        public string Orientation { get; set; }
        [StringLength(250)]
        public string Description { get; set; }
        public int? NiveauRequis { get; set; }

        [InverseProperty("IdDecollageNavigation")]
        public virtual ICollection<Vol> Vol { get; set; }
    }
}