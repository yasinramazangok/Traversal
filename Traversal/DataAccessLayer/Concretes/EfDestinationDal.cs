using Traversal.DataAccessLayer.Abstracts;
using Traversal.EntityLayer.Concretes;
using Microsoft.EntityFrameworkCore;
using Traversal.DataAccessLayer.Contexts;

namespace Traversal.DataAccessLayer.Concretes
{
    public class EfDestinationDal : GenericRepositoryDal<Destination>, IDestinationDal
    {
        private readonly TraversalContext _traversalContext;

        public EfDestinationDal(TraversalContext traversalContext) : base(traversalContext)
        {
            _traversalContext = traversalContext;
        }

        public Destination GetDestinationWithGuide(int id)
        {
            return _traversalContext.Destinations.Where(x => x.DestinationId == id).Include(x => x.Guide).FirstOrDefault();
        }

        public List<Destination> GetRecentDestinations(int count = 4)
        {
            var values = _traversalContext.Destinations.Take(count).OrderByDescending(x => x.DestinationId).ToList();
            return values;
        }
    }
}
