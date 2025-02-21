using Traversal.DataAccessLayer.Abstracts;
using Traversal.DataAccessLayer.Contexts;
namespace Traversal.DataAccessLayer.Concretes
{
    public class GenericUowRepository<T> : IGenericUowDal<T> where T : class
    {
        private readonly TraversalContext _traversalContext;

        public GenericUowRepository(TraversalContext traversalContext)
        {
            _traversalContext = traversalContext;
        }

        public T GetById(int id)
        {
            return _traversalContext.Set<T>().Find(id);
        }

        public void Insert(T t)
        {
            _traversalContext.Add(t);
        }

        public void MultiUpdate(List<T> t)
        {
            _traversalContext.UpdateRange(t);
        }

        public void Update(T t)
        {
            _traversalContext.Update(t);
        }
    }
}
