using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationParapente.DataModel.Entities
{
    public partial class MemberShipFee:Model
    {
        public MemberShipFee()
        {
            Pay = new HashSet<Pay>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(TypeName = "date")]
        public DateTime AmountYear { get; set; }
        [Column(TypeName = "decimal(15, 2)")]
        public decimal? Amount { get; set; }

        [InverseProperty("AmountYearNavigation")]
        public virtual ICollection<Pay> Pay { get; set; }
    }
}