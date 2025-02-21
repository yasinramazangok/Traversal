using Traversal.EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Traversal.DataAccessLayer.Abstracts
{
    public interface IGenericDal<T> where T : class, new()
    {
        void Insert(T t);

        void Delete(T t);

        void Update(T t);

        List<T> GetList();

        T GetById(int id);

        List<T> GetListByFilter(Expression<Func<T, bool>> filter);
    }
}
