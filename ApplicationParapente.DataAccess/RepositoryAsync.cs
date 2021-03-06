﻿using ApplicationParapente.DataModel.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApplicationParapente.DataAccess
{
    public class RepositoryAsync<TEntity, Tkey> : IRepositoryAsync<TEntity, Tkey> where TEntity : DataModel.Model
    {
        private readonly ParagliderContext m_dataContext;
      
        public RepositoryAsync()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ParagliderContext>();

            m_dataContext = new ParagliderContext(optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Paraglider").Options);
        }

        public virtual async Task DeleteAsync(TEntity entity)
        {
            m_dataContext.Set<TEntity>().Remove(entity);
            await m_dataContext.SaveChangesAsync();
        }

        public virtual async Task<List<TEntity>> GetAllAsync()
        {
            return await m_dataContext.Set<TEntity>().ToListAsync();
        }

        public virtual async Task<TEntity> GetByIdAsync(Tkey id)
        {
            return await m_dataContext.Set<TEntity>().FindAsync(id);
        }

        public virtual async Task InsertAsync(TEntity entity)
        {
            m_dataContext.Set<TEntity>().Add(entity);
            await m_dataContext.SaveChangesAsync();
        }

        public virtual async Task UpdateAsync(TEntity entity)
        {
            m_dataContext.Entry(entity).State = EntityState.Modified;
            await m_dataContext.SaveChangesAsync();

        }
    }
}
