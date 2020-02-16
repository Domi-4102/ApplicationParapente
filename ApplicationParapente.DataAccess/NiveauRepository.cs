using ApplicationParapente.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using ApplicationParapente.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationParapente.DataAccess
{
    class NiveauRepository : INiveauRepository
    {
        private readonly ParapenteContext _dataContext;
        public NiveauRepository()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ParapenteContext>();

            _dataContext = new ParapenteContext(optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Parapente").Options);
        }
        public void Delete(int id)
        {

            Niveau niveau = _dataContext.Set<Niveau>().FirstOrDefault(e => e.IdNiveau == id);
            _dataContext.Set<Niveau>().Remove(niveau);
            _dataContext.SaveChanges();
        }

        public IEnumerable<Niveau> GetAll()
        {
            return _dataContext.Set<Niveau>().ToList();
        }

        public Niveau GetById(int id)
        {
            return _dataContext.Set<Niveau>().FirstOrDefault(e => e.IdNiveau == id);
        }

        public void Insert(Niveau entity)
        {
            _dataContext.Set<Niveau>().Add(entity);
            _dataContext.SaveChanges();
        }

        public void Update(Niveau entity)
        {
            var EntityToEdit = _dataContext.Set<Niveau>().Where(e => e.IdNiveau == entity.IdNiveau).FirstOrDefault();

            if (EntityToEdit != null)
            {
                EntityToEdit.Intitulé = entity.Intitulé;
                EntityToEdit.Description = entity.Description;


                _dataContext.SaveChanges();
            }
        }
    }
}
