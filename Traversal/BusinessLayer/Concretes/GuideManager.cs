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

        public async Task TDeleteAsync(int id)
        {
            await _guideDal.DeleteAsync(id);
        }

        public async Task<GuideDto> TGetByIdAsync(int id)
        {
            var values = await _guideDal.GetListAsync();
            return _mapper.Map<GuideDto>(values);
        }

        public async Task<List<ListGuideDto>> TGetListAsync()
        {
            var values = await _guideDal.GetListAsync();
            return _mapper.Map<List<ListGuideDto>>(values);
        }

        public async Task TInsertAsync(AddGuideDto dto)
        {
            AddGuideValidator validationRules = new AddGuideValidator();
            ValidationResult result = validationRules.Validate(dto);
            if (result.IsValid)
                await _guideDal.InsertAsync(_mapper.Map<Guide>(dto));
        }

        public async Task TUpdateAsync(Guide dto)
        {
            await _guideDal.UpdateAsync(dto);
        }

        public Task TUpdateAsync(object dto)
        {
            throw new NotImplementedException();
        }
    }
}
