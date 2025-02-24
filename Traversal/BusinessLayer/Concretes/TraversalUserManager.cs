using Traversal.BusinessLayer.Abstracts;
using Traversal.DataAccessLayer.Abstracts;
using Traversal.EntityLayer.Concretes;

namespace Traversal.BusinessLayer.Concretes
{
    public class TraversalUserManager : ITraversalUserService
    {
        private readonly ITraversalUserDal _traversalUserDal;

        public TraversalUserManager(ITraversalUserDal traversalUserDal)
        {
            _traversalUserDal = traversalUserDal;
        }

        public void TDelete(int id)
        {
            var traversalUser = _traversalUserDal.GetById(id);
            _traversalUserDal.Delete(traversalUser);
        }

        public TraversalUser TGetById(int id)
        {
            return _traversalUserDal.GetById(id);
        }

        public List<TraversalUser> TGetList()
        {
            return _traversalUserDal.GetList();
        }

        public void TInsert(TraversalUser dto)
        {
            _traversalUserDal.Insert(dto);
        }

        public void TUpdate(TraversalUser dto)
        {
            _traversalUserDal.Update(dto);
        }
    }
}
