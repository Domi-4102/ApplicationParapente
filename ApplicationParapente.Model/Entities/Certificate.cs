using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationParapente.DataModel.Entities
{
    public partial class Certificate : Model
    {
        public Certificate()
        {
            Internship = new HashSet<Internship>();
            Obtain = new HashSet<Obtain>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Label { get; set; }
        [Column("Id_Level")]
        public int IdLevel { get; set; }

        [ForeignKey(nameof(IdLevel))]
        [InverseProperty(nameof(Level.Certificate))]
        public virtual Level IdLevelNavigation { get; set; }
        [InverseProperty("IdCertificateNavigation")]
        public virtual ICollection<Internship> Internship { get; set; }
        [InverseProperty("IdCertificateNavigation")]
        public virtual ICollection<Obtain> Obtain { get; set; }
    }
}