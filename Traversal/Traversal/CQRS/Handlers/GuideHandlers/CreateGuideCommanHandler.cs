using MediatR;
using Traversal.CQRS.Commands.GuideCommands;
using Traversal.DataAccessLayer.Contexts;
using Traversal.EntityLayer.Concretes;

namespace Traversal.CQRS.Handlers.GuideHandlers
{
    public class CreateGuideCommanHandler : IRequestHandler<CreateGuideCommand>
    {
        private readonly TraversalContext _context;

        public CreateGuideCommanHandler(TraversalContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(CreateGuideCommand request, CancellationToken cancellationToken)
        {
            _context.Guides.Add(new Guide
            {
                Name = request.Name,
                Description = request.Description,
                Status = true             
            });
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
