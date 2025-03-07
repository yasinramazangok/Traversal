using AutoMapper;
using Traversal.BusinessLayer.Abstracts;
using Traversal.DataAccessLayer.Abstracts;
using Traversal.DataAccessLayer.Concretes;
using Traversal.DTOLayer.AdminDTOs.AnnouncementDtos;
using Traversal.DTOLayer.AdminDTOs.DestinationDtos;
using Traversal.EntityLayer.Concretes;

namespace Traversal.BusinessLayer.Concretes
{
    public class AdminDestinationManager : IAdminDestinationService
    {
        private readonly IDestinationDal _destinationDal;
        private readonly IMapper _mapper;

        public AdminDestinationManager(IDestinationDal destinationDal, IMapper mapper)
        {
            _destinationDal = destinationDal;
            _mapper = mapper;
        }

        public DestinationDto GetDestinationWithGuide(int id)
        {
            return _mapper.Map<DestinationDto>(_destinationDal.GetDestinationWithGuide(id));
        }

        public List<ListDestinationDto> GetRecentDestinations()
        {
            return _mapper.Map<List<ListDestinationDto>>(_destinationDal.GetRecentDestinations(4));
        }

        public async Task TDeleteAsync(int id)
        {
            await _destinationDal.DeleteAsync(id);
        }

        public async Task<DestinationDto> TGetByIdAsync(int id)
        {
            var values = await _destinationDal.GetByIdAsync(id);
            return _mapper.Map<DestinationDto>(values);
        }

        public async Task<List<ListDestinationDto>> TGetListAsync()
        {
            var values = await _destinationDal.GetListAsync();
            return _mapper.Map<List<ListDestinationDto>>(values);
        }

        public async Task TInsertAsync(AddDestinationDto dto)
        {
            dto.Status = true;
            await _destinationDal.InsertAsync(_mapper.Map<Destination>(dto));
        }

        public async Task TUpdateAsync(UpdateDestinationDto dto)
        {
            await _destinationDal.UpdateAsync(_mapper.Map<Destination>(dto));
        }
    }
}
