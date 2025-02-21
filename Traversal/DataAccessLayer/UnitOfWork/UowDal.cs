using Traversal.DataAccessLayer.Contexts;
namespace Traversal.DataAccessLayer.UnitOfWork

{
    public class UowDal : IUowDal
    {
        private readonly TraversalContext _traversalcontext;

        public UowDal(TraversalContext traversalcontext)
        {
            _traversalcontext = traversalcontext;
        }
        public void Save()
        {
            _traversalcontext.SaveChanges();
        }
    }
}
