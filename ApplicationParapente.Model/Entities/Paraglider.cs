using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationParapente.DataModel.Entities
{
    public partial class Paraglider : Model
    {
        public Paraglider()
        {
            Flight = new HashSet<Flight>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ServiceDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? LastUseService { get; set; }
        [Column("Id_Level")]
        public int IdLevel { get; set; }

        [ForeignKey(nameof(IdLevel))]
        [InverseProperty(nameof(ParagliderModel.Paraglider))]
        public virtual ParagliderModel IdLevelNavigation { get; set; }
        [InverseProperty("IdParagliderNavigation")]
        public virtual ICollection<Flight> Flight { get; set; }
    }
}