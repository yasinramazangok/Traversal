using Traversal.DataAccessLayer.Abstracts;
using System.Linq.Expressions;
using Traversal.DataAccessLayer.Contexts;

namespace Traversal.DataAccessLayer.Concretes
{
    public class GenericRepositoryDal<T> : IGenericRepositoryDal<T> where T : class, new()
    {
        public void Delete(T entity)
        {
            using var traversalContext = new TraversalContext();
            traversalContext.Remove(entity);
            traversalContext.SaveChanges();
        }

        public T GetById(int id)
        {
            using var traversalContext = new TraversalContext();
            return traversalContext.Set<T>().Find(id);
        }

        public virtual List<T> GetList()
        {
            using var traversalContext = new TraversalContext();
            return traversalContext.Set<T>().ToList();
        }

        public List<T> GetListByFilter(Expression<Func<T, bool>> filter)
        {
            using var traversalContext = new TraversalContext();
            return traversalContext.Set<T>().Where(filter).ToList();
        }

        public void Insert(T entity)
        {
            using var traversalContext = new TraversalContext();
            traversalContext.Add(entity);
            traversalContext.SaveChanges();
        }

        public void Update(T entity)
        {
            using var traversalContext = new TraversalContext();
            traversalContext.Update(entity);
            traversalContext.SaveChanges();
        }
    }
}
