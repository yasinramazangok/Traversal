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

        public void TDelete(int id)
        {
            var subAbout = _subAboutDal.GetById(id);
            _subAboutDal.Delete(subAbout);
        }

        public SubAbout TGetById(int id)
        {
            return _subAboutDal.GetById(id);
        }

        public List<SubAbout> TGetList()
        {
            return _subAboutDal.GetList();
        }

        public void TInsert(SubAbout dto)
        {
            _subAboutDal.Insert(dto);
        }

        public void TUpdate(SubAbout dto)
        {
            _subAboutDal.Update(dto);
        }
    }
}
