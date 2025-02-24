using Traversal.DataAccessLayer.Abstracts;
using Traversal.EntityLayer.Concretes;
using Microsoft.EntityFrameworkCore;
using Traversal.DataAccessLayer.Contexts;

namespace Traversal.DataAccessLayer.Concretes
{
    public class EfCommentDal : GenericRepository<Comment>, ICommentDal
    {
        public List<Comment> GetCommentListByDestination()
        {
            using (var c = new TraversalContext())
            {
                return c.Comments.Include(comment => comment.Destination).ToList();
            }
        }

        public List<Comment> GetCommentListWithDestinationAndUser(int id)
        {
            using (var c = new TraversalContext())
            {
                return c.Comments.Where(x => x.DestinationId == id).Include(x => x.TraversalUser).ToList();
            }
        }
    }
}
