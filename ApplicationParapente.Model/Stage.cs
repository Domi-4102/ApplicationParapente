using System;

namespace ApplicationParapente.Model
{
    public class Stage:Models
    {
        public int Id { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public Decimal Prix { get; set; }
        public int NiveauRequis { get; set; }
        
    }
}