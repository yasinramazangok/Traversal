using Traversal.EntityLayer.Concretes;

namespace Traversal.BusinessLayer.Abstracts
{
    public interface IGuideService : IGenericService<Guide>
    {
        void ChangeGuideStatusToTrue(int id);
        void ChangeGuideStatusToFalse(int id);
    }
}
