using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.BusinessLayer.Abstracts;
using Traversal.DataAccessLayer.Abstracts;

namespace Traversal.BusinessLayer.Concretes
{
    public class GenericManager<TEntity, TDto, TListDto, TAddDto, TUpdateDto> : IGenericReadonlyService<TEntity, TDto, TListDto>, IGenericWriteService<TAddDto, TUpdateDto>
        where TEntity : class, new()
        where TDto : class
        where TListDto : class
        where TAddDto : class
        where TUpdateDto : class
    {
        private readonly IGenericRepositoryDal<TEntity> _genericRepositoryDal;
        private readonly IMapper _mapper;

        public GenericManager(IGenericRepositoryDal<TEntity> genericRepositoryDal, IMapper mapper)
        {
            _genericRepositoryDal = genericRepositoryDal;
            _mapper = mapper;
        }

        public async Task TDeleteAsync(int id)
        {
            await _genericRepositoryDal.DeleteAsync(id);
        }

        public async Task<TDto> TGetByIdAsync(int id)
        {
            var entity = await _genericRepositoryDal.GetByIdAsync(id);
            return _mapper.Map<TDto>(entity);
        }

        public async Task<List<TListDto>> TGetListAsync()
        {
            var entities = await _genericRepositoryDal.GetListAsync();
            return _mapper.Map<List<TListDto>>(entities);
        }

        public async Task TInsertAsync(TAddDto dto)
        {
            var entity = _mapper.Map<TEntity>(dto);
            await _genericRepositoryDal.InsertAsync(entity);
        }

        public async Task TUpdateAsync(TUpdateDto dto)
        {
            var entity = _mapper.Map<TEntity>(dto);
            await _genericRepositoryDal.UpdateAsync(entity);
        }
    }
}
