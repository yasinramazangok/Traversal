using Traversal.CQRS.Queries.DestinationQueries;
using Traversal.CQRS.Results.DestinationResults;
using Traversal.DataAccessLayer.Contexts;

namespace Traversal.CQRS.Handlers.DestinationHandlers
{
    public class GetDestinationByIdQueryHandler
    {
        private readonly TraversalContext _context;

        public GetDestinationByIdQueryHandler(TraversalContext context)
        {
            _context = context;
        }

        public GetDestinationByIdQueryResult Handle(GetDestinationByIdQuery query)
        {
            var values = _context.Destinations.Find(query.Id);
            return new GetDestinationByIdQueryResult
            {
                DestinationId = values.DestinationId,
                City = values.City,
                DayNight = values.DayNight,
                Price=values.Price
            };
        }
    }
}
