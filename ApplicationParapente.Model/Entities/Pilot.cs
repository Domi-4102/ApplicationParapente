using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationParapente.DataModel.Entities
{
    [Table("PILOT")]
    public  class Pilot : Model
    {
        public Pilot()
        {
            Flight = new HashSet<Flight>();
            Obtain = new HashSet<Obtain>();
            Pay = new HashSet<Pay>();
            Supervise = new HashSet<Supervise>();
            Take = new HashSet<Take>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(100)]
        public string LastName { get; set; }
        [StringLength(100)]
        public string FirstName { get; set; }
        [Column(TypeName = "decimal(15, 2)")]
        public decimal? Weight { get; set; }
        [StringLength(300)]
        public string Adress { get; set; }
        [StringLength(100)]
        public string Tel { get; set; }
        [Column("Id_FONCTION")]
        public int IdFonction { get; set; }

        [ForeignKey(nameof(IdFonction))]
        [InverseProperty(nameof(Fonction.Pilot))]
        public virtual Fonction IdFonctionNavigation { get; set; }
        [InverseProperty("IdPilotNavigation")]
        public virtual ICollection<Flight> Flight { get; set; }
        [InverseProperty("IdNavigation")]
        public virtual ICollection<Obtain> Obtain { get; set; }
        [InverseProperty("IdNavigation")]
        public virtual ICollection<Pay> Pay { get; set; }
        [InverseProperty("IdNavigation")]
        public virtual ICollection<Supervise> Supervise { get; set; }
        [InverseProperty("IdNavigation")]
        public virtual ICollection<Take> Take { get; set; }
    }
}