using Traversal.CQRS.Commands.DestinationCommands;
using Traversal.DataAccessLayer.Contexts;
using Traversal.EntityLayer.Concretes;

namespace Traversal.CQRS.Handlers.DestinationHandlers
{
    public class CreateDestinationCommandHandler
    {
        private readonly TraversalContext _context;

        public CreateDestinationCommandHandler(TraversalContext context)
        {
            _context = context;
        }
        public void Handle(CreateDestinationCommand command)
        {
            _context.Destinations.Add(new Destination
            {
                City = command.City,
                Price = command.Price,
                DayNight = command.DayNight,
                Capacity = command.Capacity,
                Status = true
            });
            _context.SaveChanges();
        }
    }
}
