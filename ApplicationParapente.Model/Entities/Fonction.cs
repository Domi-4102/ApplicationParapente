﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationParapente.DataModel.Entities
{
    [Table("FONCTION")]
    public partial class Fonction : Model
    {
        public Fonction()
        {
            Pilot = new HashSet<Pilot>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Label { get; set; }

        [InverseProperty("IdFonctionNavigation")]
        public virtual ICollection<Pilot> Pilot { get; set; }
    }
}