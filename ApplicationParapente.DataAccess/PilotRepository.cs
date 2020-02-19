using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApplicationParapente.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using ApplicationParapente.DataModel;
using ApplicationParapente.DataModel.Entities;

namespace ApplicationParapente.DataAccess
{
    public class PilotRepository : IPilotRepository
    {
        private readonly ParagliderContext _dataContext;

        public PilotRepository()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ParagliderContext>();

            _dataContext = new ParagliderContext(optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Paraglider").Options);
        }

        void IRepository<Pilot, int>.Delete(int id)
        {
            Pilot p = _dataContext.Set<Pilot>().FirstOrDefault(e => e.Id == id);
            _dataContext.Set<Pilot>().Remove(p);
            _dataContext.SaveChanges();
        }

        IEnumerable<Pilot> IRepository<Pilot, int>.GetAll()
        {
            return _dataContext.Set<Pilot>().ToList();
        }

        Pilot IRepository<Pilot, int>.GetById(int id)
        {
            return _dataContext.Set<Pilot>().FirstOrDefault(e => e.Id == id);
        }

        void IRepository<Pilot, int>.Insert(Pilot entity)
        {
            _dataContext.Set<Pilot>().Add(entity);
            _dataContext.SaveChanges();
        }

        void IRepository<Pilot, int>.Update(Pilot entity)
        {
            var EntityToEdit = _dataContext.Set<Pilot>().Where(e => e.Id == entity.Id).FirstOrDefault();

            if (EntityToEdit != null)
            {
                EntityToEdit.LastName= entity.LastName ;
                EntityToEdit.FirstName = entity.FirstName;
                EntityToEdit.Weight = entity.Weight;
                EntityToEdit.Adress =entity.Adress;
                EntityToEdit.Tel = entity.Tel;
                
                
                _dataContext.SaveChanges();
            }
            
        }
    }
}
