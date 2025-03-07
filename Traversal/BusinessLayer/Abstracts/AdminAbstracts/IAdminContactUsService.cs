using Traversal.DTOLayer.AdminDTOs.ContactUsDtos;
using Traversal.EntityLayer.Concretes;

namespace Traversal.BusinessLayer.Abstracts
{
    public interface IAdminContactUsService : IGenericReadonlyService<object, object, ListContactUsDto>, IGenericWriteService<object, object>
    {
        List<ListContactUsDto> TGetListContactUsByTrue();
    }
}
