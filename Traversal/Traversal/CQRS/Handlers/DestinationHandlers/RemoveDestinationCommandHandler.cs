using Traversal.CQRS.Commands.DestinationCommands;
using Traversal.DataAccessLayer.Contexts;

namespace Traversal.CQRS.Handlers.DestinationHandlers
{
    public class RemoveDestinationCommandHandler
    {
        private readonly TraversalContext _context;

        public RemoveDestinationCommandHandler(TraversalContext context)
        {
            _context = context;
        }

        public void Handle(RemoveDestinationCommand command)
        {
            var values = _context.Destinations.Find(command.Id);
            _context.Destinations.Remove(values);
            _context.SaveChanges();
        }
    }
}
