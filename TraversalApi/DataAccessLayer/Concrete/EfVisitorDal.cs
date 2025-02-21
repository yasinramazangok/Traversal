using TraversalApi.DataAccessLayer.Abstract;
using TraversalApi.DataAccessLayer.Context;
using TraversalApi.EntityLayer.Entities;

namespace TraversalApi.DataAccessLayer.Concrete
{
    public class EfVisitorDal : GenericRepository<Visitor>, IVisitorDal
    {
        public EfVisitorDal(TraversalApiContext traversalApiContext) : base(traversalApiContext)
        {
        }
    }
}
