using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TraversalUserManager : ITraversalUserService
    {
        private readonly ITraversalUserDal _traversalUserDal;

        public TraversalUserManager(ITraversalUserDal traversalUserDal)
        {
            _traversalUserDal = traversalUserDal;
        }

        public void Delete(TraversalUser entity)
        {
            _traversalUserDal.Delete(entity);
        }

        public TraversalUser GetById(int id)
        {
            return _traversalUserDal.GetById(id);
        }

        public List<TraversalUser> GetList()
        {
            return _traversalUserDal.GetList();
        }

        public void Insert(TraversalUser entity)
        {
            _traversalUserDal.Insert(entity);
        }

        public void Update(TraversalUser entity)
        {
            _traversalUserDal.Update(entity);
        }
    }
}
