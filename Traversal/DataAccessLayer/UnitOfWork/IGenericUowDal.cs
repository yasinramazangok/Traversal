using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traversal.DataAccessLayer.Abstracts
{
    public interface IGenericUowDal<T> where T : class
    {
        void Insert(T entity);
        void Update(T entity);
        void MultiUpdate(List<T> entity);
        T GetById(int id);

        void BeginTransaction();
        void Commit();
        void Rollback();
        void Save();
    }
}
