using Traversal.EntityLayer.Concretes;

namespace Traversal.BusinessLayer.Abstracts
{
    public interface ITraversalUserService : IGenericReadonlyService<TraversalUser, TraversalUser, TraversalUser>, IGenericWriteService<TraversalUser, TraversalUser>
    {
    }
}
