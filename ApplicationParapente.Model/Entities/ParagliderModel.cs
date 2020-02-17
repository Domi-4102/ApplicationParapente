using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApplicationParapente.DataModel
{
    public class ParagliderModel
    {
        public ParagliderModel() { }

       
        [Key]
        public int Id { get; set; }
        public string NumberOfHomologation { get; set; }
        public DateTime HomologationDate { get; set; }
        public decimal size{ get; set; }
        public decimal MinWeight { get; set; }
        public decimal MaxWeight { get; set; }

    }
}
