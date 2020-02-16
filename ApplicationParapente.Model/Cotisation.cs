
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationParapente.DataModel
{
    [Table("COTISATION")]
    public partial class Cotisation
    {
        public Cotisation()
        {
            Paye = new HashSet<Paye>();
        }

        [Key]
        [Column("Id_Cotisation")]
        public int IdCotisation { get; set; }
        [Column(TypeName = "decimal(15, 2)")]
        public decimal? Montant { get; set; }
        [Column(TypeName = "date")]
        public DateTime? AnnéeCotisation { get; set; }

        [InverseProperty("IdCotisationNavigation")]
        public virtual ICollection<Paye> Paye { get; set; }
    }
}