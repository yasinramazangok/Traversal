using AutoMapper;
using TraversalApi.BusinessLayer.Abstract;
using TraversalApi.DataAccessLayer.Abstract;
using TraversalApi.DTOLayer.VisitorDTOs;
using TraversalApi.EntityLayer.Entities;

namespace TraversalApi.BusinessLayer.Concrete
{
    public class VisitorManager : IVisitorService
    {
        private readonly IVisitorDal _visitorDal;
        private readonly IMapper _mapper;

        public VisitorManager(IVisitorDal visitorDal, IMapper mapper)
        {
            _visitorDal = visitorDal;
            _mapper = mapper;
        }

        public void TDelete(int id)
        {
            var visitor = _visitorDal.GetById(id);
            _visitorDal.Delete(visitor);
        }

        public VisitorDto TGetById(int id)
        {
            return _mapper.Map<VisitorDto>(_visitorDal.GetById(id));
        }

        public List<ListVisitorDto> TGetList()
        {
            return _mapper.Map<List<ListVisitorDto>>(_visitorDal.GetList());
        }

        public void TInsert(AddVisitorDto dto)
        {
            _visitorDal.Insert(_mapper.Map<Visitor>(dto));
        }

        public void TUpdate(UpdateVisitorDto dto)
        {
            _visitorDal.Update(_mapper.Map<Visitor>(dto));
        }
    }
}
