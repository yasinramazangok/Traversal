using Traversal.DTOLayer.AdminDTOs.CommentDtos;
using Traversal.EntityLayer.Concretes;

namespace Traversal.BusinessLayer.Abstracts
{
    public interface ICommentService : IGenericReadonlyService<Comment, CommentDto, ListCommentDto>, IGenericWriteService<object, object>
    {
        List<ListCommentDto> TGetCommentListByDestination();
        public List<ListCommentDto> TGetCommentListWithDestinationAndUser(int id);
    }
}
