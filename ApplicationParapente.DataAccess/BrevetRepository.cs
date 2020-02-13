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
    public class BrevetRepository : IBrevetRepository
    {
        private readonly ParapenteContext _dataContext;

        public BrevetRepository()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ParapenteContext>();

            _dataContext = new ParapenteContext(optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Parapente").Options);
        }

        void IRepository<Brevet, int>.Delete(int id)
        {
            Brevet p = _dataContext.Set<Brevet>().FirstOrDefault(e => e.IdBrevet == id);
            _dataContext.Set<Brevet>().Remove(p);
            _dataContext.SaveChanges();
        }

        IEnumerable<Brevet> IRepository<Brevet, int>.GetAll()
        {
            return _dataContext.Set<Brevet>().ToList();
        }

        Brevet IRepository<Brevet, int>.GetById(int id)
        {
            return _dataContext.Set<Brevet>().FirstOrDefault(e => e.IdBrevet == id);
        }

        void IRepository<Brevet, int>.Insert(Brevet entity)
        {
            _dataContext.Set<Brevet>().Add(entity);
            _dataContext.SaveChanges();
        }

        void IRepository<Brevet, int>.Update(Brevet entity)
        {
            var EntityToEdit = _dataContext.Set<Brevet>().Where(e => e.IdBrevet == entity.IdBrevet).FirstOrDefault();

            if (EntityToEdit != null)
            {
                EntityToEdit.Label= entity.Label;
                EntityToEdit.IdNiveau = entity.IdNiveau;
                
                _dataContext.SaveChanges();
            }
            
        }
    }
}
