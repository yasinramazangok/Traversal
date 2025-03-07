using Traversal.EntityLayer.Concretes;

namespace Traversal.BusinessLayer.Abstracts
{
    public interface IAdminTraversalUserService : IGenericReadonlyService<TraversalUser, TraversalUser, TraversalUser>, IGenericWriteService<TraversalUser, TraversalUser>
    {
    }
}
