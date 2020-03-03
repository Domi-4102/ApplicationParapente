using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationParapente.DataAccess
{
    public interface IRepositoryAsync<TEntity, Tkey>
    {
        Task<TEntity> GetByIdAsync(Tkey id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        void InsertAsync(TEntity entity);
        void DeleteAsync(TEntity entity);
        void UpdateAsync(TEntity entity);
    }
}
