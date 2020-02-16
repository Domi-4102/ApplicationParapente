using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationParapente.DataModel
{
    [Table("MODELE_PARAPENTE")]
    public partial class ModeleParapente
    {
        public ModeleParapente()
        {
            Parapente = new HashSet<Parapente>();
        }

        [Key]
        [Column("Id_Modele")]
        public int IdModele { get; set; }
        [Required]
        [StringLength(50)]
        public string NumeroHomologation { get; set; }
        [Column("dateHomologation")]
        [StringLength(50)]
        public string DateHomologation { get; set; }
        [Column(TypeName = "decimal(15, 2)")]
        public decimal? Taille { get; set; }
        [Column(TypeName = "decimal(15, 2)")]
        public decimal? PoidsMin { get; set; }
        [Column(TypeName = "decimal(15, 2)")]
        public decimal? PoidMax { get; set; }

        [InverseProperty("IdModeleNavigation")]
        public virtual ICollection<Parapente> Parapente { get; set; }
    }
}