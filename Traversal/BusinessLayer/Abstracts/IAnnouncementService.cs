using Traversal.DTOLayer.AdminDTOs.AnnouncementDtos;
using Traversal.EntityLayer.Concretes;

namespace Traversal.BusinessLayer.Abstracts
{
    public interface IAnnouncementService : IGenericReadonlyService<AnnouncementDto, ListAnnouncementDto>, IGenericWriteService<AddAnnouncementDto, UpdateAnnouncementDto>
    {
    }
}
