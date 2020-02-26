using ApplicationParapente.DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationParapente.DataAccess.Repositories
{
    class payRepository : Repository<Pay, int>
    {

        public payRepository(ParagliderContext context) : base(context) { }


    }
}
