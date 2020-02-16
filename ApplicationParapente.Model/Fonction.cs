using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationParapente.DataModel
{
    [Table("FONCTION")]
    public partial class Fonction
    {
        public Fonction()
        {
            Pilote = new HashSet<Pilote>();
        }

        [Key]
        [Column("Id_Fonction")]
        public int IdFonction { get; set; }
        [Required]
        [StringLength(50)]
        public string Label { get; set; }

        [InverseProperty("IdFonctionNavigation")]
        public virtual ICollection<Pilote> Pilote { get; set; }
    }
}