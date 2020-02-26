using ApplicationParapente.DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationParapente.DataAccess.Repositories
{
    class LevelRepository : Repository<Level, int>
    {

        public LevelRepository(ParagliderContext context) : base(context) { }


    }
}
