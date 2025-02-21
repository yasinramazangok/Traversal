using MediatR;
using Traversal.CQRS.Queries.GuideQueries;
using Traversal.CQRS.Results.GuideResults;
using Traversal.DataAccessLayer.Contexts;

namespace Traversal.CQRS.Handlers.GuideHandlers
{
    public class GetGuideByIdQueryHandler : IRequestHandler<GetGuideByIdQuery, GetGuideByIdQueryResult>
    {
        private readonly TraversalContext _context;

        public GetGuideByIdQueryHandler(TraversalContext context)
        {
            _context = context;
        }

        public async Task<GetGuideByIdQueryResult> Handle(GetGuideByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Guides.FindAsync(request.Id);
            return new GetGuideByIdQueryResult
            {
                GuideId = values.GuideId,
                Description = values.Description,
                Name = values.Name
            };
        }
    }
}
