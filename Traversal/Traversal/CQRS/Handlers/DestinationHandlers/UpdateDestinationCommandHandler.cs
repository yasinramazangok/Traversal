using Traversal.CQRS.Commands.DestinationCommands;
using Traversal.DataAccessLayer.Contexts;

namespace Traversal.CQRS.Handlers.DestinationHandlers
{
    public class UpdateDestinationCommandHandler
    {
        private readonly TraversalContext _context;

        public UpdateDestinationCommandHandler(TraversalContext context)
        {
            _context = context;
        }
        public void Handle(UpdateDestinationCommand command)
        {
            var values = _context.Destinations.Find(command.DestinationId);
            values.City = command.City;
            values.DayNight = command.DayNight;
            values.Price = command.Price;
            _context.SaveChanges();
        }
    }
}
