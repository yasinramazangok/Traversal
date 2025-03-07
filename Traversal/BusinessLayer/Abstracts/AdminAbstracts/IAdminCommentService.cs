using Traversal.DTOLayer.AdminDTOs.CommentDtos;
using Traversal.EntityLayer.Concretes;

namespace Traversal.BusinessLayer.Abstracts
{
    public interface IAdminCommentService : IGenericReadonlyService<object, object, ListCommentDto>, IGenericWriteService<object, object>
    {
        List<ListCommentDto> TGetCommentListByDestination();
    }
}
