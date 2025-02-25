using Traversal.EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Traversal.DataAccessLayer.Abstracts
{
    public interface IGenericRepositoryDal<T> where T : class, new()
    {
        Task InsertAsync(T t);
        Task DeleteAsync(int id);
        Task UpdateAsync(T t);
        Task<List<T>> GetListAsync();
        Task<T> GetByIdAsync(int id);
        Task<List<T>> GetListByFilterAsync(Expression<Func<T, bool>> filter);
    }
}
