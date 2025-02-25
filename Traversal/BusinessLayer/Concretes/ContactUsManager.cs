using AutoMapper;
using Traversal.BusinessLayer.Abstracts;
using Traversal.DataAccessLayer.Abstracts;
using Traversal.DataAccessLayer.Concretes;
using Traversal.DTOLayer.AdminDTOs.ContactUsDtos;
using Traversal.EntityLayer.Concretes;

namespace Traversal.BusinessLayer.Concretes
{
    public class ContactUsManager : IContactUsService
    {
        private readonly IContactUsDal _contactUsDal;
        private readonly IMapper _mapper;

        public ContactUsManager(IContactUsDal contactUsDal, IMapper mapper)
        {
            _contactUsDal = contactUsDal;
            _mapper = mapper;
        }

        public void ChangeContactUsStatusToFalse(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContactUs> GetListContactUsByFalse()
        {
            return _contactUsDal.GetListContactUsByFalse();
        }

        public List<ListContactUsDto> TGetListContactUsByTrue()
        {
            return _mapper.Map<List<ListContactUsDto>>(_contactUsDal.GetListContactUsByTrue());
        }

        public async Task<List<ListContactUsDto>> TGetListAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<object> TGetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task TInsertAsync(object dto)
        {
            throw new NotImplementedException();
        }

        public async Task TUpdateAsync(object dto)
        {
            throw new NotImplementedException();
        }

        public async Task TDeleteAsync(int id)
        {
            await _contactUsDal.DeleteAsync(id);
        }
    }
}
