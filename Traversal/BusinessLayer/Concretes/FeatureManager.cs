using AutoMapper.Features;
using Traversal.BusinessLayer.Abstracts;
using Traversal.DataAccessLayer.Abstracts;
using Traversal.EntityLayer.Concretes;

namespace Traversal.BusinessLayer.Concretes
{
    public class FeatureManager : IFeatureService
    {
        private readonly IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public async Task TDeleteAsync(int id)
        {
            await _featureDal.DeleteAsync(id);
        }

        public async Task<Feature> TGetByIdAsync(int id)
        {
            return await _featureDal.GetByIdAsync(id);
        }

        public async Task<List<Feature>> TGetListAsync()
        {
            return await _featureDal.GetListAsync();
        }

        public async Task TInsertAsync(Feature dto)
        {
            await _featureDal.InsertAsync(dto);
        }

        public async Task TUpdateAsync(Feature dto)
        {
            await _featureDal.UpdateAsync(dto);
        }
    }
}
