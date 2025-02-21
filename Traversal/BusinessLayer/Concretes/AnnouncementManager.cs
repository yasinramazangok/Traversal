using Traversal.BusinessLayer.Abstracts;
using Traversal.DataAccessLayer.Abstracts;
using Traversal.EntityLayer.Concretes;

namespace Traversal.BusinessLayer.Concretes
{
    public class AnnouncementManager : IAnnouncementService
    {
        private readonly IAnnouncementDal _announcementDal;

        public AnnouncementManager(IAnnouncementDal announcementDal)
        {
            _announcementDal = announcementDal;
        }

        public void Delete(Announcement entity)
        {
            _announcementDal.Delete(entity);
        }

        public Announcement GetById(int id)
        {
            return _announcementDal.GetById(id);
        }

        public List<Announcement> GetList()
        {
            return _announcementDal.GetList();
        }

        public void Insert(Announcement entity)
        {
            _announcementDal.Insert(entity);
        }

        public void Update(Announcement entity)
        {
            _announcementDal.Update(entity);
        }
    }
}
