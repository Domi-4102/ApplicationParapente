using ApplicationParapente.DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationParapente.DataAccess.Repositories
{
    class ParagliderRepository : Repository<Paraglider, int>
    {

        public ParagliderRepository(ParagliderContext context) : base(context) { }


    }
}
