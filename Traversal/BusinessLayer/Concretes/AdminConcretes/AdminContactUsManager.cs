using AutoMapper;
using Traversal.BusinessLayer.Abstracts;
using Traversal.DataAccessLayer.Abstracts;
using Traversal.DataAccessLayer.Concretes;
using Traversal.DTOLayer.AdminDTOs.ContactUsDtos;
using Traversal.EntityLayer.Concretes;

namespace Traversal.BusinessLayer.Concretes
{
    public class AdminContactUsManager : IAdminContactUsService
    {
        private readonly IContactUsDal _contactUsDal;
        private readonly IMapper _mapper;

        public AdminContactUsManager(IContactUsDal contactUsDal, IMapper mapper)
        {
            _contactUsDal = contactUsDal;
            _mapper = mapper;
        }

        public Task TDeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<object> TGetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ListContactUsDto>> TGetListAsync()
        {
            throw new NotImplementedException();
        }

        public List<ListContactUsDto> TGetListContactUsByTrue()
        {
            return _mapper.Map<List<ListContactUsDto>>(_contactUsDal.GetListContactUsByTrue());
        }

        public Task TInsertAsync(object dto)
        {
            throw new NotImplementedException();
        }

        public Task TUpdateAsync(object dto)
        {
            throw new NotImplementedException();
        }
    }
}
