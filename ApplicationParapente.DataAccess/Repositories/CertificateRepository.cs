using ApplicationParapente.DataModel.Entities;

namespace ApplicationParapente.DataAccess.Repositories
{
    class CertificateRepository : Repository<Certificate, int>
    {

        public CertificateRepository(ParagliderContext context) : base(context) { }


    }
}
