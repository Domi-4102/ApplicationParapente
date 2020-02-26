using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationParapente.DataAccess
{
    public interface IRepository<TEntity, Tkey>
    {
        TEntity GetById(Tkey id);
        IEnumerable<TEntity> GetAll();
        void Insert(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
    }
}
