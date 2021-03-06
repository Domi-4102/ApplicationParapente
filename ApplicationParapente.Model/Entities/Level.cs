﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationParapente.DataModel.Entities
{
    public partial class Level : Model
    {
        public Level()
        {
            Certificate = new HashSet<Certificate>();
            LandingSite = new HashSet<LandingSite>();
            LaunchingSite = new HashSet<LaunchingSite>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(50)]
        public string Label { get; set; }
        [StringLength(50)]
        public string Description { get; set; }

        [InverseProperty("IdLevelNavigation")]
        public virtual ICollection<Certificate> Certificate { get; set; }
        [InverseProperty("IdLevelNavigation")]
        public virtual ICollection<LandingSite> LandingSite { get; set; }
        [InverseProperty("IdLevelNavigation")]
        public virtual ICollection<LaunchingSite> LaunchingSite { get; set; }
    }
}