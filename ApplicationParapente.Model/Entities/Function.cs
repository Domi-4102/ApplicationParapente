using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApplicationParapente.DataModel
{
    public class Function
    {
        public Function()
        {

        }
        [Key]
        public int Id { get; set; }
        public string  Label { get; set; }
    }
}
