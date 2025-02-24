using AutoMapper;
using Traversal.BusinessLayer.Abstracts;
using Traversal.DataAccessLayer.Abstracts;
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

        public void Delete(ContactUs entity)
        {
            _contactUsDal.Delete(entity);
        }

        public List<ContactUs> GetList()
        {
            return _contactUsDal.GetList();
        }

        public List<ContactUs> GetListContactUsByFalse()
        {
            return _contactUsDal.GetListContactUsByFalse();
        }

        public void Insert(ContactUs entity)
        {
            _contactUsDal.Insert(entity);
        }

        public void Update(ContactUs entity)
        {
            _contactUsDal.Update(entity);
        }

        public void TDelete(int id)
        {
            throw new NotImplementedException();
        }

        public object TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ListContactUsDto> TGetList()
        {
            throw new NotImplementedException();
        }

        public List<ListContactUsDto> TGetListContactUsByTrue()
        {
            return _mapper.Map<List<ListContactUsDto>>(_contactUsDal.GetListContactUsByTrue());
        }

        public void TInsert(object dto)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(object dto)
        {
            throw new NotImplementedException();
        }
    }
}
