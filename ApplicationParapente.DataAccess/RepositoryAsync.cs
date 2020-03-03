using ApplicationParapente.DataModel.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationParapente.DataAccess
{
    public class RepositoryAsync<TEntity, Tkey> : IRepositoryAsync <TEntity, Tkey> where TEntity : ApplicationParapente.DataModel.Model
    {
        private readonly ParagliderContext m_dataContext;
      
        public RepositoryAsync()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ParagliderContext>();

            m_dataContext = new ParagliderContext(optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Paraglider").Options);
        }

        public virtual void DeleteAsync(TEntity entity)
        {
            m_dataContext.Set<TEntity>().Remove(entity);
            m_dataContext.SaveChangesAsync();
        }

        public virtual async  Task<List<TEntity>> GetAllAsync()
        {
            return await m_dataContext.Set<TEntity>().ToListAsync();
        }

        public virtual async Task<TEntity> GetByIdAsync(Tkey id)
        {
            return await m_dataContext.Set<TEntity>().FindAsync(id);
        }

        public virtual void InsertAsync(TEntity entity)
        {
             m_dataContext.Set<TEntity>().AddAsync(entity);
             m_dataContext.SaveChangesAsync();
        }

        public virtual async void UpdateAsync(TEntity entity)
        {
            m_dataContext.Entry(entity).State = EntityState.Modified;
            await m_dataContext.SaveChangesAsync();

        }
    }
}
