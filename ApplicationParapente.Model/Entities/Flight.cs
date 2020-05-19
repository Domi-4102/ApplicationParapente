using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationParapente.DataModel.Entities
{
    public partial class Flight : Model
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DateFly { get; set; }
        public TimeSpan? Duration { get; set; }
        [Column("Id_LandingSite")]
        public int IdLandingSite { get; set; }
        [Column("Id_LaunchingSite")]
        public int IdLaunchingSite { get; set; }
        [Column("Id_PILOT")]
        public int IdPilot { get; set; }
        [Column("Id_Paraglider")]
        public int IdParaglider { get; set; }

        [ForeignKey(nameof(IdLandingSite))]
        [InverseProperty(nameof(LandingSite.Flight))]
        public virtual LandingSite IdLandingSiteNavigation { get; set; }
        [ForeignKey(nameof(IdLaunchingSite))]
        [InverseProperty(nameof(LaunchingSite.Flight))]
        public virtual LaunchingSite IdLaunchingSiteNavigation { get; set; }
        [ForeignKey(nameof(IdParaglider))]
        [InverseProperty(nameof(Paraglider.Flight))]
        public virtual Paraglider IdParagliderNavigation { get; set; }
        [ForeignKey(nameof(IdPilot))]
        [InverseProperty(nameof(Pilot.Flight))]
        public virtual Pilot IdPilotNavigation { get; set; }
    }
}