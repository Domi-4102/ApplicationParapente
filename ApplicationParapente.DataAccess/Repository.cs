using ApplicationParapente.DataModel.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ApplicationParapente.DataAccess
{
    public class Repository<TEntity, Tkey> : IRepository <TEntity, Tkey> where TEntity : ApplicationParapente.DataModel.Model
    {
        private readonly ParagliderContext m_dataContext;
      

        public Repository()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ParagliderContext>();

            m_dataContext = new ParagliderContext(optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Paraglider").Options);
        }

        public virtual void Delete(TEntity entity)
        {
            m_dataContext.Set<TEntity>().Remove(entity);
            m_dataContext.SaveChanges();
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return m_dataContext.Set<TEntity>().AsEnumerable();
        }

        public virtual TEntity GetById(Tkey id)
        {
            return m_dataContext.Set<TEntity>().Find(id);
        }

        public virtual void Insert(TEntity entity)
        {
            m_dataContext.Set<TEntity>().Add(entity);
            m_dataContext.SaveChanges();
        }

        public virtual void Update(TEntity entity)
        {
            m_dataContext.Entry(entity).State = EntityState.Modified;
            m_dataContext.SaveChanges();
        }

      
    }
}
