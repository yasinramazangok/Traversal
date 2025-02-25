using Traversal.DTOLayer.AdminDTOs.DestinationDtos;
using Traversal.DTOLayer.AdminDTOs.GuideDtos;
using Traversal.EntityLayer.Concretes;

namespace Traversal.BusinessLayer.Abstracts
{
    public interface IGuideService : IGenericReadonlyService<Guide, GuideDto, ListGuideDto>, IGenericWriteService<AddGuideDto, object>
    {
        void ChangeGuideStatusToTrue(int id);
        void ChangeGuideStatusToFalse(int id);
    }
}
