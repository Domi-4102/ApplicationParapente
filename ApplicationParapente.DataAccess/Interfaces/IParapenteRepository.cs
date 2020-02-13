using System;
using System.Collections.Generic;
using System.Text;
using Parapente.Data.Entities;

namespace ApplicationParapente.DataAccess.Interfaces
{
    public interface IParapenteRepository:IRepository<Parapente.Data.Entities.Parapente, int>
    {
    }
}
