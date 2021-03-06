using System.Linq;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Routing;

namespace DOU
{
    [ODataRoutePrefix("companies")]
    public class CompaniesController : ODataController
    {
        private DouCompaniesDbContext _context;

        public CompaniesController(DouCompaniesDbContext context)
        {
            _context = context;
        }

        [ODataRoute]
        [EnableQuery]
        public IQueryable<CompanyModel> Get()
        {
            return _context.Companies.AsQueryable();
        }
    }
}