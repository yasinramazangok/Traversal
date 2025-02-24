using Traversal.DTOLayer.AdminDTOs.DestinationDtos;
using Traversal.DTOLayer.AdminDTOs.GuideDtos;

namespace Traversal.BusinessLayer.Abstracts
{
    public interface IGuideService : IGenericReadonlyService<GuideDto, ListGuideDto>, IGenericWriteService<AddGuideDto, object>
    {
        void ChangeGuideStatusToTrue(int id);
        void ChangeGuideStatusToFalse(int id);
    }
}
