using Traversal.EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traversal.DataAccessLayer.Abstracts
{
    public interface IContactUsDal : IGenericDal<ContactUs>
    {
        List<ContactUs> GetListContactUsByTrue();

        List<ContactUs> GetListContactUsByFalse();

        void ChangeContactUsStatusToFalse(int id);
    }
}
