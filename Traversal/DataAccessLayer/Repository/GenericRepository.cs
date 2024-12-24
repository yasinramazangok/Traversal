using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T t)
        {
            using var traversalContext = new Context();
            traversalContext.Remove(t);
            traversalContext.SaveChanges();
        }

        public T GetById(int id)
        {
            using var traversalContext = new Context();
            return traversalContext.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            using var traversalContext = new Context();
            return traversalContext.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            using var traversalContext = new Context();
            traversalContext.Add(t);
            traversalContext.SaveChanges();
        }

        public void Update(T t)
        {
            using var traversalContext = new Context();
            traversalContext.Update(t);
            traversalContext.SaveChanges();
        }
    }
}
