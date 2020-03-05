using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApplicationParapente.DataAccess
{
    public interface IRepositoryAsync<TEntity, Tkey>
    {
        Task<TEntity> GetByIdAsync(Tkey id);
        Task<List<TEntity>> GetAllAsync();
        Task InsertAsync(TEntity entity);
        Task DeleteAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
    }
}
