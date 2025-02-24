using Traversal.DTOLayer.AdminDTOs.DestinationDtos;
using Traversal.EntityLayer.Concretes;

namespace Traversal.BusinessLayer.Abstracts
{
    public interface IDestinationService : IGenericReadonlyService<DestinationDto, ListDestinationDto>, IGenericWriteService<AddDestinationDto, UpdateDestinationDto>
    {
        public DestinationDto GetDestinationWithGuide(int id);
        public List<ListDestinationDto> GetRecentDestinations();
    }
}
