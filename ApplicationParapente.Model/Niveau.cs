using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationParapente.DataModel
{
    [Table("NIVEAU")]
    public partial class Niveau
    {
        public Niveau()
        {
            Brevet = new HashSet<Brevet>();
        }

        [Key]
        [Column("Id_Niveau")]
        public int IdNiveau { get; set; }
        [StringLength(50)]
        public string Intitulé { get; set; }
        [StringLength(50)]
        public string Description { get; set; }

        [InverseProperty("IdNiveauNavigation")]
        public virtual ICollection<Brevet> Brevet { get; set; }
    }
}