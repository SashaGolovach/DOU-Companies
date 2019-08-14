using System.Linq;
using DOU_Companies_Web_Api.Models;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Routing;

namespace DOU_Companies_Web_Api.Controllers
{
    [ODataRoutePrefix("reviews")]
    public class ReviewsController : ODataController
    {
        private DouCompaniesDbContext _context;

        public ReviewsController(DouCompaniesDbContext context)
        {
            _context = context;
        }

        [ODataRoute]
        [EnableQuery]
        public IQueryable<ReviewItemModel> Get()
        {
            return _context.Reviews.AsQueryable();
        }
    }
}