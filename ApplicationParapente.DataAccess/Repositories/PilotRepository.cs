﻿
using ApplicationParapente.DataModel.Entities;

namespace ApplicationParapente.DataAccess
{
    public class PilotRepository :Repository<Pilot,int>
    {

        public PilotRepository(ParagliderContext context) : base(context) { }

     
    }
}
