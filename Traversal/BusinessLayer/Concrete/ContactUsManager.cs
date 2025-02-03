using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactUsManager : IContactUsService
    {
        IContactUsDal _contactUsDal;

        public ContactUsManager(IContactUsDal contactUsDal)
        {
            _contactUsDal = contactUsDal;
        }

        public void ChangeContactUsStatusToFalse(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(ContactUs entity)
        {
            _contactUsDal.Delete(entity);
        }

        public ContactUs GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContactUs> GetList()
        {
            return _contactUsDal.GetList();
        }

        public List<ContactUs> GetListContactUsByFalse()
        {
            return _contactUsDal.GetListContactUsByFalse();
        }

        public List<ContactUs> GetListContactUsByTrue()
        {
            return _contactUsDal.GetListContactUsByTrue();
        }

        public void Insert(ContactUs entity)
        {
            _contactUsDal.Insert(entity);
        }

        public void Update(ContactUs entity)
        {
            _contactUsDal.Update(entity);
        }
    }
}
