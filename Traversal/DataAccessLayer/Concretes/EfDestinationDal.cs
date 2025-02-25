using Traversal.DataAccessLayer.Abstracts;
using Traversal.EntityLayer.Concretes;
using Microsoft.EntityFrameworkCore;
using Traversal.DataAccessLayer.Contexts;

namespace Traversal.DataAccessLayer.Concretes
{
    public class EfDestinationDal : GenericRepositoryDal<Destination>, IDestinationDal
    {
        public Destination GetDestinationWithGuide(int id)
        {
            using (var c = new TraversalContext())
            {
                return c.Destinations.Where(x => x.DestinationId == id).Include(x => x.Guide).FirstOrDefault();
            }
        }

        public List<Destination> GetRecentDestinations(int count = 4)
        {
            using (var context = new TraversalContext())
            {
                var values = context.Destinations.Take(count).OrderByDescending(x => x.DestinationId).ToList();
                return values;
            }
        }
    }
}
