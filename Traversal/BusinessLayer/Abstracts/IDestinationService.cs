using Traversal.EntityLayer.Concretes;

namespace Traversal.BusinessLayer.Abstracts
{
    public interface IDestinationService : IGenericService<Destination>
    {
        public Destination GetDestinationWithGuide(int id);
        public List<Destination> GetRecentDestinations();
    }
}
