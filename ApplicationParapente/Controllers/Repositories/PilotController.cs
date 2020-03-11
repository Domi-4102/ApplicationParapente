using ApplicationParapente.DataAccess;
using ApplicationParapente.DataModel.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationParapente.Controllers.Repositories
{
    [Route("api/[controller]")]
    [ApiController]
    public class PilotController : GenericAsyncController<Pilot, int>
    {
        public PilotController(RepositoryAsync<Pilot, int> Repository) : base(Repository)
        {

        }
    }
}