using Traversal.DTOLayer.AdminDTOs.CommentDtos;

namespace Traversal.BusinessLayer.Abstracts
{
    public interface ICommentService : IGenericReadonlyService<CommentDto, ListCommentDto>, IGenericWriteService<object, object>
    {
        List<ListCommentDto> TGetCommentListByDestination();
        public List<ListCommentDto> TGetCommentListWithDestinationAndUser(int id);
    }
}
