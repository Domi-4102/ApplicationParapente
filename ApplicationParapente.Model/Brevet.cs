
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationParapente.DataModel
{
    [Table("BREVET")]
    public partial class Brevet
    {
        public Brevet()
        {
            Obtient = new HashSet<Obtient>();
            Stage = new HashSet<Stage>();
        }

        [Key]
        [Column("Id_Brevet")]
        public int IdBrevet { get; set; }
        [Required]
        [StringLength(50)]
        public string Label { get; set; }
        [Column("Id_Niveau")]
        public int IdNiveau { get; set; }

        [ForeignKey(nameof(IdNiveau))]
        [InverseProperty(nameof(Niveau.Brevet))]
        public virtual Niveau IdNiveauNavigation { get; set; }
        [InverseProperty("IdBrevetNavigation")]
        public virtual ICollection<Obtient> Obtient { get; set; }
        [InverseProperty("IdBrevetNavigation")]
        public virtual ICollection<Stage> Stage { get; set; }
    }
}