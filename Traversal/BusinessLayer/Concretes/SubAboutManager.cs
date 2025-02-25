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

        public async Task TDeleteAsync(int id)
        {
            await _subAboutDal.DeleteAsync(id);
        }

        public async Task<SubAbout> TGetByIdAsync(int id)
        {
            return await _subAboutDal.GetByIdAsync(id);
        }

        public async Task<List<SubAbout>> TGetListAsync()
        {
            return await _subAboutDal.GetListAsync();
        }

        public async Task TInsertAsync(SubAbout dto)
        {
            await _subAboutDal.InsertAsync(dto);
        }

        public async Task TUpdateAsync(SubAbout dto)
        {
            await _subAboutDal.UpdateAsync(dto);
        }
    }
}
