using Traversal.DataAccessLayer.Abstracts;
using Traversal.EntityLayer.Concretes;
using Microsoft.EntityFrameworkCore;
using Traversal.DataAccessLayer.Contexts;

namespace Traversal.DataAccessLayer.Concretes
{
    public class EfCommentDal : GenericRepositoryDal<Comment>, ICommentDal
    {
        private readonly TraversalContext _traversalContext;

        public EfCommentDal(TraversalContext traversalContext) : base(traversalContext)
        {
            _traversalContext = traversalContext;
        }

        public List<Comment> GetCommentListByDestination()
        {
            return _traversalContext.Comments.Include(comment => comment.Destination).ToList();
        }

        public List<Comment> GetCommentListWithDestinationAndUser(int id)
        {
            return _traversalContext.Comments.Where(x => x.DestinationId == id).Include(x => x.TraversalUser).ToList();
        }
    }
}
