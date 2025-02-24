using Traversal.DTOLayer.AdminDTOs.AboutDtos;
using Traversal.EntityLayer.Concretes;

namespace Traversal.BusinessLayer.Abstracts
{
    public interface IAboutService : IGenericReadonlyService<object, ListAboutDto>, IGenericWriteService<AddAboutDto, UpdateAboutDto>
    {
    }
}
