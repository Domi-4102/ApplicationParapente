using ApplicationParapente.DataAccess;
using ApplicationParapente.DataModel.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ApplicationParapente.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class PilotController : Controller
    {
        private readonly Repository<Pilot,int> _pilotRepository;
        public PilotController(Repository<Pilot, int> piloteRepository)
        {
            _pilotRepository = piloteRepository;
        }

        // GET: api/Pilot
        [HttpGet]
        public IEnumerable<Pilot> Get()
        {
            return _pilotRepository.GetAll();
        }

        // GET: api/Pilot/5
        [HttpGet("{id}", Name = "Get")]
        public Pilot Get(int id)
        {
            return _pilotRepository.GetById(id);
        }

        // POST: api/Pilot
        [HttpPost]
        public void Post([FromBody] Pilot entity)
        {
            _pilotRepository.Insert(entity);
        }

        // PUT: api/Pilot/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Pilot entity)
        {
            entity.Id = id;
            _pilotRepository.Update(entity);
        }

        // DELETE: /api/Pilot/2
        [HttpDelete("{id}")]
        public void Delete(Pilot pilot)
        {
            _pilotRepository.Delete(pilot);
        }
    }
}
