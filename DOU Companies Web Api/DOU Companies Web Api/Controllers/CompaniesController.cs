using System.Linq;
using DOU_Companies_Web_Api.Models;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Routing;

namespace DOU_Companies_Web_Api.Controllers
{
    [ODataRoutePrefix("comp")]
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