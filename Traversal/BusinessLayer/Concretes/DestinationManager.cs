using AutoMapper;
using Traversal.BusinessLayer.Abstracts;
using Traversal.DataAccessLayer.Abstracts;
using Traversal.DataAccessLayer.Concretes;
using Traversal.DTOLayer.AdminDTOs.AnnouncementDtos;
using Traversal.DTOLayer.AdminDTOs.DestinationDtos;
using Traversal.EntityLayer.Concretes;

namespace Traversal.BusinessLayer.Concretes
{
    public class DestinationManager : IDestinationService
    {
        private readonly IDestinationDal _destinationDal;
        private readonly IMapper _mapper;

        public DestinationManager(IDestinationDal destinationDal, IMapper mapper)
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

        public void TDelete(int id)
        {
            var destination = _destinationDal.GetById(id);
            _destinationDal.Delete(destination);
        }

        public DestinationDto TGetById(int id)
        {
            return _mapper.Map<DestinationDto>(_destinationDal.GetById(id));
        }

        public List<ListDestinationDto> TGetList()
        {
            return _mapper.Map<List<ListDestinationDto>>(_destinationDal.GetList());
        }

        public void TInsert(AddDestinationDto dto)
        {
            dto.Status = true;
            _destinationDal.Insert(_mapper.Map<Destination>(dto));
        }

        public void TUpdate(UpdateDestinationDto dto)
        {
            _destinationDal.Insert(_mapper.Map<Destination>(dto));
        }

        public void Update(Destination entity)
        {
            _destinationDal.Update(entity);
        }
    }
}
