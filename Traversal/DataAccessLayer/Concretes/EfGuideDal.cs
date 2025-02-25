using Traversal.DataAccessLayer.Abstracts;
using Traversal.EntityLayer.Concretes;
using Traversal.DataAccessLayer.Contexts;

namespace Traversal.DataAccessLayer.Concretes
{
    public class EfGuideDal : GenericRepositoryDal<Guide>, IGuideDal
    {
        public void ChangeGuideStatusToFalse(int id)
        {
            using var traversalContext = new TraversalContext();

            var guide = traversalContext.Guides.FirstOrDefault(c => c.GuideId == id);
            if (guide != null)
            {
                guide.Status = false;
                traversalContext.SaveChanges();
            }
        }

        public void ChangeGuideStatusToTrue(int id)
        {
            using var traversalContext = new TraversalContext();

            var guide = traversalContext.Guides.FirstOrDefault(c => c.GuideId == id);
            if (guide != null)
            {
                guide.Status = true;
                traversalContext.SaveChanges();
            }
        }
    }
}
