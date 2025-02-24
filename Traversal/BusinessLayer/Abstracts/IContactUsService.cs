using Traversal.DTOLayer.AdminDTOs.ContactUsDtos;
using Traversal.EntityLayer.Concretes;

namespace Traversal.BusinessLayer.Abstracts
{
    public interface IContactUsService : IGenericReadonlyService<object, ListContactUsDto>, IGenericWriteService<object, object>
    {
        List<ListContactUsDto> TGetListContactUsByTrue();
        List<ContactUs> GetListContactUsByFalse();
        void ChangeContactUsStatusToFalse(int id);
    }
}
