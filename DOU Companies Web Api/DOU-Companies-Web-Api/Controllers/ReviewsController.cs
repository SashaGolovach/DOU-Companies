using System.Linq;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Routing;

namespace DOU
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