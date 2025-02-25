using Traversal.DataAccessLayer.Abstracts;
using System.Linq.Expressions;
using Traversal.DataAccessLayer.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Traversal.DataAccessLayer.Concretes
{
    public class GenericRepositoryDal<T> : IGenericRepositoryDal<T> where T : class, new()
    {
        private readonly TraversalContext _traversalContext;

        public GenericRepositoryDal(TraversalContext traversalContext)
        {
            _traversalContext = traversalContext;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity != null)
            {
                _traversalContext.Set<T>().Remove(entity);
                await _traversalContext.SaveChangesAsync();
            }
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _traversalContext.Set<T>().FindAsync(id);
        }

        public virtual async Task<List<T>> GetListAsync()
        {
            return await _traversalContext.Set<T>().ToListAsync();
        }

        public async Task<List<T>> GetListByFilterAsync(Expression<Func<T, bool>> filter)
        {
            return await _traversalContext.Set<T>().Where(filter).ToListAsync();
        }

        public async Task InsertAsync(T entity)
        {
            await _traversalContext.Set<T>().AddAsync(entity);
            await _traversalContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _traversalContext.Set<T>().Update(entity);
            await _traversalContext.SaveChangesAsync();
        }
    }
}
