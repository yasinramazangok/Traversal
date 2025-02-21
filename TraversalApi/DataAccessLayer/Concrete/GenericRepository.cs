using TraversalApi.DataAccessLayer.Abstract;
using TraversalApi.DataAccessLayer.Context;

namespace TraversalApi.DataAccessLayer.Concrete
{
    public class GenericRepository<T> : IGenericRepositoryDal<T> where T : class, new()
    {
        private readonly TraversalApiContext _traversalApiContext;

        // Constructor injection - Dependency Injection Implementation
        public GenericRepository(TraversalApiContext traversalApiContext)
        {
            _traversalApiContext = traversalApiContext;
        }

        public void Delete(T entity)
        {
            _traversalApiContext.Remove(entity);
            _traversalApiContext.SaveChanges();
        }

        public T GetById(int id)
        {
            return _traversalApiContext.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            return _traversalApiContext.Set<T>().ToList();
        }

        public void Insert(T entity)
        {
            _traversalApiContext.Add(entity);
            _traversalApiContext.SaveChanges();
        }

        public void Update(T entity)
        {
            _traversalApiContext.Update(entity);
            _traversalApiContext.SaveChanges();
        }
    }
}
