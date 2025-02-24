using AutoMapper;
using Traversal.BusinessLayer.Abstracts;
using Traversal.DataAccessLayer.Abstracts;
using Traversal.DTOLayer.AdminDTOs.AnnouncementDtos;
using Traversal.EntityLayer.Concretes;

namespace Traversal.BusinessLayer.Concretes
{
    public class AnnouncementManager : IAnnouncementService
    {
        private readonly IAnnouncementDal _announcementDal;
        private readonly IMapper _mapper;

        public AnnouncementManager(IAnnouncementDal announcementDal, IMapper mapper)
        {
            _announcementDal = announcementDal;
            _mapper = mapper;

        }

        public void TDelete(int id)
        {
            var announcement = _announcementDal.GetById(id);
            _announcementDal.Delete(announcement);
        }

        public AnnouncementDto TGetById(int id)
        {
            return _mapper.Map<AnnouncementDto>(_announcementDal.GetById(id));
        }

        public List<ListAnnouncementDto> TGetList()
        {
            return _mapper.Map<List<ListAnnouncementDto>>(_announcementDal.GetList());
        }

        public void TInsert(AddAnnouncementDto dto)
        {
            dto.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            _announcementDal.Insert(_mapper.Map<Announcement>(dto));
        }

        public void TUpdate(UpdateAnnouncementDto dto)
        {
            _announcementDal.Update(_mapper.Map<Announcement>(dto));
        }
    }
}
