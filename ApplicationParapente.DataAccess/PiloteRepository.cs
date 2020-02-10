using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApplicationParapente.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using Parapente.Data;
using Parapente.Data.Entities;

namespace ApplicationParapente.DataAccess
{
    public class PiloteRepository : IPiloteRepository
    {
        public ParapenteContext DataContext { get; }

        void IRepository<Pilote, int>.Delete(Pilote entity)
        {
            DataContext.Set<Pilote>().Remove(entity);
        }

        IEnumerable<Pilote> IRepository<Pilote, int>.GetAll()
        {
            return DataContext.Set<Pilote>().ToList();
        }

        Pilote IRepository<Pilote, int>.GetById(int id)
        {
            return DataContext.Set<Pilote>().FirstOrDefault(e => e.IdPilote == id);
        }

        void IRepository<Pilote, int>.Insert(Pilote entity)
        {
            DataContext.Set<Pilote>().Add(entity);
        }

        void IRepository<Pilote, int>.Update(Pilote entity)
        {
            var editedEntity = DataContext.Set<Pilote>().FirstOrDefault(e => e.IdPilote == entity.IdPilote);
        }
    }
}
