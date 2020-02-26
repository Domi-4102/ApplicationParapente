using ApplicationParapente.DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationParapente.DataAccess.Repositories
{
    class TakeRepository : Repository<Take, int>
    {

        public TakeRepository(ParagliderContext context) : base(context) { }


    }
}
