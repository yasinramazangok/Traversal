using Microsoft.EntityFrameworkCore.Storage;
using Traversal.DataAccessLayer.Abstracts;
using Traversal.DataAccessLayer.Contexts;
namespace Traversal.DataAccessLayer.UnitOfWork
{
    public class GenericUowDal<T> : IGenericUowDal<T> where T : class
    {
        private readonly TraversalContext _traversalContext;
        private IDbContextTransaction _dbContextTransaction;

        public GenericUowDal(TraversalContext traversalContext)
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

        public void BeginTransaction()
        {
            _dbContextTransaction = _traversalContext.Database.BeginTransaction();
        }

        public void Commit()
        {
            _traversalContext.SaveChanges();
            _dbContextTransaction?.Commit();
        }

        public void Rollback()
        {
            _dbContextTransaction?.Rollback();
        }

        public void Save()
        {
            _traversalContext.SaveChanges();
        }
    }
}
