using ApplicationParapente.DataAccess;
using ApplicationParapente.DataModel.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApplicationParapente.Controllers
{

    [Route("api/async/[controller]")]
    [ApiController]
    public class PilotAsyncController : Controller
    {
        private readonly RepositoryAsync<Pilot,int> _pilotRepository;
        public PilotAsyncController(RepositoryAsync<Pilot, int> piloteRepository)
        {
            _pilotRepository = piloteRepository;
        }

        // GET: api/async/Pilot
        [HttpGet]
        public async Task<IEnumerable<Pilot>> GetAsync()
        {

            return await _pilotRepository.GetAllAsync();
  
        }

        // GET: api/async/Pilot/5
        [HttpGet("{id}", Name = "GetAsync")]
        public async Task<Pilot> GetAsync(int id)
        {
            return await _pilotRepository.GetByIdAsync(id);
        }

        // POST: api/async/Pilot
        [HttpPost]
        public async Task PostAsync([FromBody] Pilot entity)
        {
            await _pilotRepository.InsertAsync(entity);
        }

        // PUT: api/async/Pilot/205
        [HttpPut("{id}")]
        public async Task PutAsync(int id, [FromBody] Pilot entity)
        {
            entity.Id = id;
            await _pilotRepository.UpdateAsync(entity);
        }

        // DELETE: api/async/Pilot/206
        [HttpDelete("{id}")]
        public async Task DeleteAsync(Pilot pilot)
        {
            await _pilotRepository.DeleteAsync(pilot);
        }
    }
}
