using System.Collections.Generic;
using ApplicationParapente.DataAccess.Interfaces;
using Microsoft.AspNetCore.Mvc;
using ApplicationParapente.DataModel;

namespace ApplicationParapente.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class PiloteController : ControllerBase
    {
        private readonly IPilotRepository _pilotRepository;
        public PiloteController(IPilotRepository piloteRepository)
        {
            _pilotRepository = piloteRepository;
        }

        // GET: api/Pilote
        [HttpGet]
        public IEnumerable<Pilot> Get()
        {
            return _pilotRepository.GetAll();
        }

        // GET: api/Pilote/5
        [HttpGet("{id}", Name = "Get")]
        public Pilot Get(int id)
        {
            return _pilotRepository.GetById(id);
        }

        // POST: api/Pilote
        [HttpPost]
        public void Post([FromBody] Pilot entity)
        {
            _pilotRepository.Insert(entity);
        }

        // PUT: api/Pilote/5
        [HttpPut("{id}")]
        public void Put(int id,[FromBody] Pilot entity)
        {
            entity.Id = id;
            _pilotRepository.Update(entity);
        }

        // DELETE: /api/Pilote/2
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _pilotRepository.Delete(id);
        }
    }
}
