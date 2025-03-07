using Traversal.DTOLayer.AdminDTOs.AnnouncementDtos;
using Traversal.EntityLayer.Concretes;

namespace Traversal.BusinessLayer.Abstracts
{
    public interface IAdminAnnouncementService : IGenericReadonlyService<Announcement, AnnouncementDto, ListAnnouncementDto>, IGenericWriteService<AddAnnouncementDto, UpdateAnnouncementDto>
    {
    }
}
