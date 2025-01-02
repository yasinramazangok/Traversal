using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfGuideDal : GenericRepository<Guide>, IGuideDal
    {
        public void ChangeGuideStatusToFalse(int id)
        {
            using var traversalContext = new Context();

            var guide = traversalContext.Guides.FirstOrDefault(c => c.GuideId == id);
            if (guide != null)
            {
                guide.Status = false;
                traversalContext.SaveChanges();
            }
        }

        public void ChangeGuideStatusToTrue(int id)
        {
            using var traversalContext = new Context();

            var guide = traversalContext.Guides.FirstOrDefault(c => c.GuideId == id);
            if (guide != null)
            {
                guide.Status = true;
                traversalContext.SaveChanges();
            }
        }
    }
}
