using Traversal.EntityLayer.Concretes;

namespace Traversal.BusinessLayer.Abstracts
{
    public interface IFeatureService : IGenericReadonlyService<Feature, Feature>, IGenericWriteService<Feature, Feature>
    {
    }
}
