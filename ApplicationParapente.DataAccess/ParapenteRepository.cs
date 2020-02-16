using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApplicationParapente.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using ApplicationParapente.DataModel;

namespace ApplicationParapente.DataAccess
{
    public class ParapenteRepository : IParapenteRepository
    {
        private readonly ParapenteContext _dataContext;

        public ParapenteRepository()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ParapenteContext>();

            _dataContext = new ParapenteContext(optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Parapente").Options);
        }

        void IRepository<Parapente, int>.Delete(int id)
        {
            Parapente p = _dataContext.Set<Parapente>().FirstOrDefault(e => e.IdParapente == id);
            _dataContext.Set<Parapente>().Remove(p);
            _dataContext.SaveChanges();
        }

        IEnumerable<Parapente> IRepository<Parapente, int>.GetAll()
        {
            return _dataContext.Set<Parapente>().ToList();
        }

        Parapente IRepository<Parapente, int>.GetById(int id)
        {
            return _dataContext.Set<Parapente>().FirstOrDefault(e => e.IdParapente == id);
        }

        void IRepository<Parapente, int>.Insert(Parapente entity)
        {
            _dataContext.Set<Parapente>().Add(entity);
            _dataContext.SaveChanges();
        }

        void IRepository<Parapente, int>.Update(Parapente entity)
        {
            var EntityToEdit = _dataContext.Set<Parapente>().Where(e => e.IdParapente == entity.IdParapente).FirstOrDefault();

            if (EntityToEdit != null)
            {
                EntityToEdit.DateMiseEnService = entity.DateMiseEnService;
                EntityToEdit.DateDerniereRevision = entity.DateDerniereRevision;
                EntityToEdit.IdModele = entity.IdModele;
                

                _dataContext.SaveChanges();
            }

        }
    }
}
