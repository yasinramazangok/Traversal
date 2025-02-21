using MediatR;
using Microsoft.EntityFrameworkCore;
using Traversal.CQRS.Queries.GuideQueries;
using Traversal.CQRS.Results.GuideResults;
using Traversal.DataAccessLayer.Contexts;

namespace Traversal.CQRS.Handlers.GuideHandlers
{
    public class GetAllGuideQueryHandler : IRequestHandler<GetAllGuideQuery, List<GetAllGuideQueryResult>>
    {
        private readonly TraversalContext _context;

        public GetAllGuideQueryHandler(TraversalContext context)
        {
            _context = context;
        }
        public async Task<List<GetAllGuideQueryResult>> Handle(GetAllGuideQuery request, CancellationToken cancellationToken)
        {
            return await _context.Guides.Select(x => new GetAllGuideQueryResult
            {
                GuideId = x.GuideId,
                Description = x.Description,
                Image = x.Image,
                Name = x.Name
            }).AsNoTracking().ToListAsync();
        }
    }
}
