using System;
using System.Collections.Generic;
using System.Text;
using ApplicationParapente.DataAccess.Interfaces;
using Parapente.Data.Entities;

namespace ApplicationParapente.DataAccess
{
    public class PiloteRepository : IPiloteRepository
    {
        void IRepository<Pilote, int>.Delete(Pilote entity)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Pilote> IRepository<Pilote, int>.GetAll()
        {
            throw new NotImplementedException();
        }

        Pilote IRepository<Pilote, int>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        void IRepository<Pilote, int>.Insert(Pilote entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Pilote, int>.Update(Pilote entity)
        {
            throw new NotImplementedException();
        }
    }
}
