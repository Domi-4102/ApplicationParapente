using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationParapente.DataAccess.Interfaces
{
    public interface IRepository<TEntity, Tkey>
    {
        TEntity GetById(Tkey id);
        IEnumerable<TEntity> GetAll();
        void Insert(TEntity entity);
        void Delete(Tkey id);
        void Update(TEntity entity);
    }
}
