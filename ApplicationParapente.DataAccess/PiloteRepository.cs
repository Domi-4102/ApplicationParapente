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
        private readonly ParapenteContext _dataContext;

        public PiloteRepository()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ParapenteContext>();

            _dataContext = new ParapenteContext(optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Parapente").Options);
        }

        void IRepository<Pilote, int>.Delete(int id)
        {
            Pilote p = _dataContext.Set<Pilote>().FirstOrDefault(e => e.IdPilote == id);
            _dataContext.Set<Pilote>().Remove(p);
            _dataContext.SaveChanges();
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
            _dataContext.SaveChanges();
        }

        void IRepository<Pilote, int>.Update(Pilote entity)
        {
            var EntityToEdit = _dataContext.Set<Pilote>().Where(e => e.IdPilote == entity.IdPilote).FirstOrDefault();

            if (EntityToEdit != null)
            {
                EntityToEdit.Nom= entity.Nom ;
                EntityToEdit.Prenom = entity.Prenom;
                EntityToEdit.Poids = entity.Poids;
                EntityToEdit.Adresse =entity.Adresse;
                EntityToEdit.Tel = entity.Tel;
                EntityToEdit.IdFonction = entity.IdFonction;
                
                _dataContext.SaveChanges();
            }
            
        }
    }
}
