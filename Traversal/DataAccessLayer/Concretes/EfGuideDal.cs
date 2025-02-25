using Traversal.DataAccessLayer.Abstracts;
using Traversal.EntityLayer.Concretes;
using Traversal.DataAccessLayer.Contexts;

namespace Traversal.DataAccessLayer.Concretes
{
    public class EfGuideDal : GenericRepositoryDal<Guide>, IGuideDal
    {
        private readonly TraversalContext _traversalContext;

        public EfGuideDal(TraversalContext traversalContext) : base(traversalContext)
        {
            _traversalContext = traversalContext;
        }

        public void ChangeGuideStatusToFalse(int id)
        {
            var guide = _traversalContext.Guides.FirstOrDefault(c => c.GuideId == id);
            if (guide != null)
            {
                guide.Status = false;
                _traversalContext.SaveChanges();
            }
        }

        public void ChangeGuideStatusToTrue(int id)
        {
            var guide = _traversalContext.Guides.FirstOrDefault(c => c.GuideId == id);
            if (guide != null)
            {
                guide.Status = true;
                _traversalContext.SaveChanges();
            }
        }
    }
}
