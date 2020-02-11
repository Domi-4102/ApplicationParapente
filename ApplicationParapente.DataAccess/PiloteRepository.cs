using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApplicationParapente.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Parapente.Data;
using Parapente.Data.Entities;

namespace ApplicationParapente.DataAccess
{
    public class PiloteRepository : IPiloteRepository
    {
        private readonly ParapenteContext _dataContext;

        public PiloteRepository()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ParapenteContext>();
            _dataContext = new ParapenteContext(optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Parapente").Options);
        }

        void IRepository<Pilote, int>.Delete(Pilote entity)
        {
            _dataContext.Set<Pilote>().Remove(entity);
        }

        IEnumerable<Pilote> IRepository<Pilote, int>.GetAll()
        {
            return _dataContext.Set<Pilote>().ToList();
        }

        Pilote IRepository<Pilote, int>.GetById(int id)
        {
            return _dataContext.Set<Pilote>().FirstOrDefault(e => e.IdPilote == id);
        }

        void IRepository<Pilote, int>.Insert(Pilote entity)
        {
            _dataContext.Set<Pilote>().Add(entity);
        }

        void IRepository<Pilote, int>.Update(Pilote entity)
        {
            var editedEntity = _dataContext.Set<Pilote>().FirstOrDefault(e => e.IdPilote == entity.IdPilote);
        }
    }
}
