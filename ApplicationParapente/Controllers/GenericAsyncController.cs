using ApplicationParapente.DataAccess;
using ApplicationParapente.DataModel.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApplicationParapente.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class GenericAsyncController<TEntity, Tkey> : ControllerBase where TEntity : DataModel.Model
    {
        private readonly RepositoryAsync<TEntity,Tkey> _Repository;
        public GenericAsyncController(RepositoryAsync<TEntity, Tkey> Repository)
        {
            _Repository = Repository;
        }

        // GET: api/[controller]
        [HttpGet]
        public async Task<IEnumerable<TEntity>> GetGeneric()
        {

            return await _Repository.GetAllAsync();
  
        }

        // GET: api/[controller]/5
        [HttpGet("{id}", Name = "GetGeneric")]
        public async Task<TEntity> GetGeneric(Tkey id)
        {
            return await _Repository.GetByIdAsync(id);
        }

        // POST: api/[controller]
        [HttpPost]
        public async Task PostGeneric([FromBody] TEntity entity)
        {
            await _Repository.InsertAsync(entity);
        }

        // PUT: api/[controller]/205
        [HttpPut("{id}")]
        public async Task PutGeneric(Tkey id, [FromBody] TEntity entity)
        {
            //need to bind id
            await _Repository.UpdateAsync(entity);
        }

        // DELETE: api/[controller]/206
        [HttpDelete("{id}")]
        public async Task DeleteGeneric(Tkey id, [FromBody]TEntity entity)
        {
            //need to bind id
            await _Repository.DeleteAsync(entity);
        }
    }
}
