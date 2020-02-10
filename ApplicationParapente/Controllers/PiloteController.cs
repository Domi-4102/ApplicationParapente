using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationParapente.DataAccess.Interfaces;
using ApplicationParapente.DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Parapente.Data.Entities;

namespace ApplicationParapente.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class PiloteController : ControllerBase
    {
        public IPiloteRepository Pil { get; }

        // GET: api/Pilote
        [HttpGet]
        public IEnumerable<Pilote> Get()
        {
            return Pil.GetAll();
        }

        // GET: api/Pilote/5
        [HttpGet("{id}", Name = "Get")]
        public Pilote Get(int id)
        {
            return Pil.GetById(id);
        }

        // POST: api/Pilote
        [HttpPost]
        public void Post([FromBody] Pilote entity)
        {
            Pil.Insert(entity);
        }

        // PUT: api/Pilote/5
        [HttpPut("{id}")]
        public void Put([FromBody] Pilote entity)
        {
            Pil.Update(entity);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(Pilote entity)
        {
            Pil.Delete(entity);
        }
    }
}
