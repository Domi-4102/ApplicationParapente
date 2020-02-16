using ApplicationParapente.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using ApplicationParapente.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationParapente.DataAccess
{
    class FonctionRepository : IFonctionRepository
    {
        private readonly ParapenteContext _dataContext;
        public FonctionRepository()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ParapenteContext>();

            _dataContext = new ParapenteContext(optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Parapente").Options);
        }
       

        public void Delete(int id)
        {
            Fonction p = _dataContext.Set<Fonction>().FirstOrDefault(e => e.IdFonction == id);
            _dataContext.Set<Fonction>().Remove(p);
            _dataContext.SaveChanges();
        }

        public IEnumerable<Fonction> GetAll()
        {
            return _dataContext.Set<Fonction>().ToList();
        }

        public Fonction GetById(int id)
        {
            return _dataContext.Set<Fonction>().FirstOrDefault(e => e.IdFonction == id);
        }

        public void Insert(Fonction entity)
        {
            _dataContext.Set<Fonction>().Add(entity);
            _dataContext.SaveChanges();
        }

        public void Update(Fonction entity)
        {
            var EntityToEdit = _dataContext.Set<Fonction>().Where(e => e.IdFonction == entity.IdFonction).FirstOrDefault();

            if (EntityToEdit != null)
            {
                EntityToEdit.Label = entity.Label;
            
                _dataContext.SaveChanges();
            }
        }
    }
}
