using Traversal.EntityLayer.Concretes;

namespace Traversal.BusinessLayer.Abstracts
{
    public interface ICommentService : IGenericService<Comment>
    {
        List<Comment> GetCommentByDestinationId(int id);

        List<Comment> GetListCommentByDestination();

        public List<Comment> GetListCommentWithDestinationAndUser(int id);
    }
}
