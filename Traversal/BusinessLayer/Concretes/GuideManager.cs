using AutoMapper;
using FluentValidation.Results;
using Traversal.BusinessLayer.Abstracts;
using Traversal.BusinessLayer.ValidationRules;
using Traversal.DataAccessLayer.Abstracts;
using Traversal.DataAccessLayer.Concretes;
using Traversal.DTOLayer.AdminDTOs.GuideDtos;
using Traversal.EntityLayer.Concretes;

namespace Traversal.BusinessLayer.Concretes
{
    public class GuideManager : IGuideService
    {
        private readonly IGuideDal _guideDal;
        private readonly IMapper _mapper;

        public GuideManager(IGuideDal guideDal, IMapper mapper)
        {
            _guideDal = guideDal;
            _mapper = mapper;
        }

        public void ChangeGuideStatusToFalse(int id)
        {
            _guideDal.ChangeGuideStatusToFalse(id);
        }

        public void ChangeGuideStatusToTrue(int id)
        {
            _guideDal.ChangeGuideStatusToTrue(id);
        }

        public void TDelete(int id)
        {
            var guide = _guideDal.GetById(id);
            _guideDal.Delete(guide);
        }

        public GuideDto TGetById(int id)
        {
            return _mapper.Map<GuideDto>(_guideDal.GetById(id));
        }

        public List<ListGuideDto> TGetList()
        {
            return _mapper.Map<List<ListGuideDto>>(_guideDal.GetList());
        }

        public void TInsert(AddGuideDto dto)
        {
            AddGuideValidator validationRules = new AddGuideValidator();
            ValidationResult result = validationRules.Validate(dto);
            if (result.IsValid)
                _guideDal.Insert(_mapper.Map<Guide>(dto));
        }

        public void TUpdate(Guide dto)
        {
            _guideDal.Update(dto);
        }

        public void TUpdate(object dto)
        {
            throw new NotImplementedException();
        }
    }
}
