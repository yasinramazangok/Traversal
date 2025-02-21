using Traversal.BusinessLayer.Abstracts;
using Traversal.DataAccessLayer.Abstracts;
using Traversal.EntityLayer.Concretes;

namespace Traversal.BusinessLayer.Concretes
{
    public class SubAboutManager : ISubAboutService
    {
        private readonly ISubAboutDal _subAboutDal;

        public SubAboutManager(ISubAboutDal subAboutDal)
        {
            _subAboutDal = subAboutDal;
        }

        public void Delete(SubAbout entity)
        {
            _subAboutDal.Delete(entity);
        }

        public SubAbout GetById(int id)
        {
            return _subAboutDal.GetById(id);
        }

        public List<SubAbout> GetList()
        {
            return _subAboutDal.GetList();
        }

        public void Insert(SubAbout entity)
        {
            _subAboutDal.Insert(entity);
        }

        public void Update(SubAbout entity)
        {
            _subAboutDal.Update(entity);
        }
    }
}
