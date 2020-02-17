using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApplicationParapente.DataModel.Entities
{
    class Fly
    {
        public Fly()
        {

        }
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Duration { get; set; }
        public LandingSite LandingSite { get; set; }
        public LaunchingSite LaunchingSite { get; set; }
        public Pilote Pilote { get; set; }
        public Paraglider Paraglider { get; set; }


    }
}
