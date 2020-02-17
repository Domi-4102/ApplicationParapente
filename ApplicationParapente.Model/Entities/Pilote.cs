using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApplicationParapente.DataModel
{ 
    public class Pilote
    {
        public Pilote()
        {


        }

        #region Properties Region
        [Key]
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public decimal Weight { get; set; }
        public string Adress { get; set; }
        public string Tel { get; set; }
        #endregion
        #region Relationship Region
        public virtual Function Function { get; set; }
        public virtual ICollection<Certificate> Certificates{ get; set; }
        public virtual ICollection<Internship> Internships { get; set; }
        public virtual ICollection<MembershipFee> MembershipFees { get; set; }
        public virtual ICollection<Fly> Flies { get; set; }
        #endregion


    }
}
