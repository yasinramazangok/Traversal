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

        public async Task TDeleteAsync(int id)
        {
            await _traversalUserDal.DeleteAsync(id);
        }

        public async Task<TraversalUser> TGetByIdAsync(int id)
        {
            return await _traversalUserDal.GetByIdAsync(id);
        }

        public async Task<List<TraversalUser>> TGetListAsync()
        {
            return await _traversalUserDal.GetListAsync();
        }

        public async Task TInsertAsync(TraversalUser dto)
        {
            await _traversalUserDal.InsertAsync(dto);
        }

        public async Task TUpdateAsync(TraversalUser dto)
        {
            await _traversalUserDal.UpdateAsync(dto);
        }
    }
}
