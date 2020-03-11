using ApplicationParapente.DataAccess;
using ApplicationParapente.DataModel.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;

namespace ApplicationParapente.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class GenericController<TEntity, Tkey> : ControllerBase where TEntity : DataModel.Model
    {
        private readonly RepositoryAsync<TEntity,Tkey> _Repository;
        public GenericController(RepositoryAsync<TEntity, Tkey> Repository)
        {
            _Repository = Repository;
        }

        // GET: api/[controller]
        [HttpGet]
        public async Task<IEnumerable<TEntity>> Get()
        {

            return await _Repository.GetAllAsync();
  
        }

        // GET: api/[controller]/5
        [HttpGet("{id}")]
        public async Task<TEntity> Get(Tkey id)
        {
            return await _Repository.GetByIdAsync(id);
        }

        // POST: api/[controller]
        [HttpPost]
        public async Task Post([FromBody] TEntity entity)
        {
            await _Repository.InsertAsync(entity);
        }

        // PUT: api/[controller]/205
        [HttpPut("{id}")]
        public async Task Put(Tkey id, [FromBody] TEntity entity)
        {
            //need to bind id
            Type entityType = entity.GetType();
            
            PropertyInfo myPropertyInfo = entityType.GetProperty("Id");
            if (myPropertyInfo != null)
            {
                myPropertyInfo.SetValue(entity,id);
            }
            await _Repository.UpdateAsync(entity);
        }

        // DELETE: api/[controller]/206
        [HttpDelete("{id}")]
        public async Task Delete(Tkey id, [FromBody]TEntity entity)
        {
            //need to bind id
            Type entityType = entity.GetType();

            PropertyInfo myPropertyInfo = entityType.GetProperty("Id");
            if (myPropertyInfo != null)
            {
                myPropertyInfo.SetValue(entity, id);
            }
            await _Repository.DeleteAsync(entity);
        }
    }
}
