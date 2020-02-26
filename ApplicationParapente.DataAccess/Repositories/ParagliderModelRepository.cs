using ApplicationParapente.DataModel.Entities;

namespace ApplicationParapente.DataAccess.Repositories
{
    class ParagliderModelRepository : Repository<ParagliderModel, int>
    {

        public ParagliderModelRepository(ParagliderContext context) : base(context) { }


    }
}
