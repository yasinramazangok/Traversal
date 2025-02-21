using Traversal.DataAccessLayer.Abstracts;
using Traversal.DataAccessLayer.Contexts;
using Traversal.EntityLayer.Concretes;

namespace Traversal.DataAccessLayer.Concretes
{
    public class EfAccountDal : GenericUowRepository<Account>, IAccountDal
    {
        public EfAccountDal(TraversalContext traversalContext) : base(traversalContext)
        {

        }
    }
}
