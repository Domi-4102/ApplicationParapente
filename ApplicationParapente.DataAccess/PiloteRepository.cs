using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApplicationParapente.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using ApplicationParapente.DataModel;

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

        void IRepository<Pilote, int>.Delete(int id)
        {
            Pilote p = _dataContext.Set<Pilote>().FirstOrDefault(e => e.Id == id);
            _dataContext.Set<Pilote>().Remove(p);
            _dataContext.SaveChanges();
        }

        IEnumerable<Pilote> IRepository<Pilote, int>.GetAll()
        {
            return _dataContext.Set<Pilote>().ToList();
        }

        Pilote IRepository<Pilote, int>.GetById(int id)
        {
            return _dataContext.Set<Pilote>().FirstOrDefault(e => e.Id == id);
        }

        void IRepository<Pilote, int>.Insert(Pilote entity)
        {
            _dataContext.Set<Pilote>().Add(entity);
            _dataContext.SaveChanges();
        }

        void IRepository<Pilote, int>.Update(Pilote entity)
        {
            var EntityToEdit = _dataContext.Set<Pilote>().Where(e => e.Id == entity.Id).FirstOrDefault();

            if (EntityToEdit != null)
            {
                EntityToEdit.LastName= entity.LastName ;
                EntityToEdit.FirstName = entity.FirstName;
                EntityToEdit.Weight = entity.Weight;
                EntityToEdit.Adress =entity.Adress;
                EntityToEdit.Tel = entity.Tel;
                EntityToEdit.Function = entity.Function;
                
                _dataContext.SaveChanges();
            }
            
        }
    }
}
