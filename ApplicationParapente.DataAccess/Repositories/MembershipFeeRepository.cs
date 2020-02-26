using ApplicationParapente.DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationParapente.DataAccess.Repositories
{
    class MembershipFeeRepository : Repository<MemberShipFee, int>
    {

        public MembershipFeeRepository(ParagliderContext context) : base(context) { }


    }
}
