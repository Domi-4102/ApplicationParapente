using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationParapente.DataAccess;
using ApplicationParapente.DataModel.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationParapente.Controllers.Repositories
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParagliderController : GenericAsyncController<Paraglider, int>
    {
        public ParagliderController(RepositoryAsync<Paraglider, int> Repository) : base(Repository)
        {

        }
    }
}