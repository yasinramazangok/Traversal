using AutoMapper;
using Traversal.BusinessLayer.Abstracts;
using Traversal.DataAccessLayer.Abstracts;
using Traversal.DTOLayer.AdminDTOs.AnnouncementDtos;
using Traversal.EntityLayer.Concretes;

namespace Traversal.BusinessLayer.Concretes
{
    public class AdminAnnouncementManager : IAdminAnnouncementService
    {
        private readonly IAnnouncementDal _announcementDal;
        private readonly IMapper _mapper;

        public AdminAnnouncementManager(IAnnouncementDal announcementDal, IMapper mapper)
        {
            _announcementDal = announcementDal;
            _mapper = mapper;

        }

        public async Task TDeleteAsync(int id)
        {
            await _announcementDal.DeleteAsync(id);
        }

        public async Task<AnnouncementDto> TGetByIdAsync(int id)
        {
            var values = await _announcementDal.GetByIdAsync(id);
            return _mapper.Map<AnnouncementDto>(values);
        }

        public async Task<List<ListAnnouncementDto>> TGetListAsync()
        {
            var values = await _announcementDal.GetListAsync();
            return _mapper.Map<List<ListAnnouncementDto>>(values);
        }

        public async Task TInsertAsync(AddAnnouncementDto dto)
        {
            dto.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            await _announcementDal.InsertAsync(_mapper.Map<Announcement>(dto));
        }

        public async Task TUpdateAsync(UpdateAnnouncementDto dto)
        {
            await _announcementDal.UpdateAsync(_mapper.Map<Announcement>(dto));
        }
    }
}
