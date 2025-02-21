using Microsoft.EntityFrameworkCore;
using Traversal.CQRS.Results.DestinationResults;
using Traversal.DataAccessLayer.Contexts;

namespace Traversal.CQRS.Handlers.DestinationHandlers
{
    public class GetAllDestinationQueryHandler
    {
        private readonly TraversalContext _context;

        public GetAllDestinationQueryHandler(TraversalContext context)
        {
            _context = context;
        }

        public List<GetAllDestinationQueryResult> Handle()
        {
            var values = _context.Destinations.Select(x => new GetAllDestinationQueryResult
            {
                id = x.DestinationId,
                capacity = x.Capacity,
                city = x.City,
                daynight = x.DayNight,
                price = x.Price
            }).AsNoTracking().ToList();
            return values;
        }
    }
}
