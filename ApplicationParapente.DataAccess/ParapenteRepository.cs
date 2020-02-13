using Microsoft.EntityFrameworkCore;
using Parapente.Data;
using Parapente.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationParapente.DataAccess
{
    class ParapenteRepository
    {
        private readonly ParapenteContext _dataContext;
        public ParapenteRepository()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ParapenteContext>();

            _dataContext = new ParapenteContext(optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Parapente").Options);
        }


        public void Delete(int id)
        {
            Parapente.Data.Entities.Parapente p = _dataContext.Set<Parapente.Data.Entities.Parapente>().FirstOrDefault(e => e.IdParapente == id);
            _dataContext.Set<Parapente.Data.Entities.Parapente>().Remove(p);
            _dataContext.SaveChanges();
        }

        public IEnumerable<Parapente.Data.Entities.Parapente> GetAll()
        {
            return _dataContext.Set<Parapente.Data.Entities.Parapente>().ToList();
        }

        public Parapente.Data.Entities.Parapente GetById(int id)
        {
            return _dataContext.Set<Parapente.Data.Entities.Parapente>().FirstOrDefault(e => e.IdParapente == id);
        }

        public void Insert(Parapente.Data.Entities.Parapente entity)
        {
            _dataContext.Set<Parapente.Data.Entities.Parapente>().Add(entity);
            _dataContext.SaveChanges();
        }

        public void Update(Parapente.Data.Entities.Parapente entity)
        {
            var EntityToEdit = _dataContext.Set<Parapente.Data.Entities.Parapente>().Where(e => e.IdParapente == entity.IdParapente).FirstOrDefault();

            // if (EntityToEdit != null)
            // {
            EntityToEdit.DateMiseEnService = entity.DateMiseEnService;
            EntityToEdit.DateDerniereRevision = entity.DateDerniereRevision;
            EntityToEdit.IdModele = entity.IdModele;
            EntityToEdit.ModeleParapente = entity.ModeleParapente;
            _dataContext.SaveChanges();

            // }
        }
    }
