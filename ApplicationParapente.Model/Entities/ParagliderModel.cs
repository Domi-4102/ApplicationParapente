﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationParapente.DataModel.Entities
{
    public partial class ParagliderModel : Model
    {
        public ParagliderModel()
        {
            Paraglider = new HashSet<Paraglider>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string NumberOfHomologation { get; set; }
        [StringLength(50)]
        public string HomologationDate { get; set; }
        [Column(TypeName = "decimal(15, 2)")]
        public decimal? Size { get; set; }
        [Column(TypeName = "decimal(15, 2)")]
        public decimal? MinWeight { get; set; }
        [StringLength(50)]
        public string MaxWeight { get; set; }

        [InverseProperty("IdLevelNavigation")]
        public virtual ICollection<Paraglider> Paraglider { get; set; }
    }
}