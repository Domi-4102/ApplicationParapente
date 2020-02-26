using ApplicationParapente.DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationParapente.DataAccess.Repositories
{
    class SuperviseRepository : Repository<Supervise, int>
    {

        public SuperviseRepository(ParagliderContext context) : base(context) { }


    }
}
