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
        private readonly IPiloteRepository _piloteRepository;
        public PiloteController(IPiloteRepository piloteRepository)
        {
            _piloteRepository = piloteRepository;
        }

        // GET: api/Pilote
        [HttpGet]
        public IEnumerable<Pilote> Get()
        {
            return _piloteRepository.GetAll();
        }

        // GET: api/Pilote/5
        [HttpGet("{id}", Name = "Get")]
        public Pilote Get(int id)
        {
            return _piloteRepository.GetById(id);
        }

        // POST: api/Pilote
        [HttpPost]
        public void Post([FromBody] Pilote entity)
        {
            _piloteRepository.Insert(entity);
        }

        // PUT: api/Pilote/5
        [HttpPut("{id}")]
        public void Put(int id,[FromBody] Pilote entity)
        {
            entity.IdPilote = id;
            _piloteRepository.Update(entity);
        }

        // DELETE: /api/Pilote/2
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _piloteRepository.Delete(id);
        }
    }
}
