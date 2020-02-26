using ApplicationParapente.DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationParapente.DataAccess.Repositories
{
    class InternShipRepository : Repository<Internship, int>
    {

        public InternShipRepository(ParagliderContext context) : base(context) { }


    }
}
