using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationParapente.DataModel.Entities
{
    [Table("supervise")]
    public partial class Supervise : Model
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Key]
        [Column("Id_Internship")]
        public int IdInternship { get; set; }

        [ForeignKey(nameof(IdInternship))]
        [InverseProperty(nameof(Internship.Supervise))]
        public virtual Internship IdInternshipNavigation { get; set; }
        [ForeignKey(nameof(Id))]
        [InverseProperty(nameof(Pilot.Supervise))]
        public virtual Pilot IdNavigation { get; set; }
    }
}