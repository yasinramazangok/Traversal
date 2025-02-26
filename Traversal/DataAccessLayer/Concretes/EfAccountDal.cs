using Traversal.DataAccessLayer.Abstracts;
using Traversal.DataAccessLayer.Contexts;
using Traversal.DataAccessLayer.UnitOfWork;
using Traversal.EntityLayer.Concretes;

namespace Traversal.DataAccessLayer.Concretes
{
    public class EfAccountDal : GenericUowDal<Account>, IAccountDal
    {
        public EfAccountDal(TraversalContext traversalContext) : base(traversalContext)
        {
        }
    }
}
