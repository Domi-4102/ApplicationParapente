using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationParapente.DataModel.Entities
{
    public partial class LandingSite : Model
    {
        public LandingSite()
        {
            Flight = new HashSet<Flight>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [Column(TypeName = "text")]
        public string Orientation { get; set; }
        [StringLength(100)]
        public string Description { get; set; }
        [Column("Id_Level")]
        public int IdLevel { get; set; }

        [ForeignKey(nameof(IdLevel))]
        [InverseProperty(nameof(Level.LandingSite))]
        public virtual Level IdLevelNavigation { get; set; }
        [InverseProperty("IdLandingSiteNavigation")]
        public virtual ICollection<Flight> Flight { get; set; }
    }
}