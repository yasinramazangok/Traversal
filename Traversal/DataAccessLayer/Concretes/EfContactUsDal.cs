using Traversal.DataAccessLayer.Abstracts;
using Traversal.DataAccessLayer.Contexts;
using Traversal.EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traversal.DataAccessLayer.Concretes
{
    public class EfContactUsDal : GenericRepositoryDal<ContactUs>, IContactUsDal
    {
        private readonly TraversalContext _traversalContext;
        public EfContactUsDal(TraversalContext traversalContext) : base(traversalContext)
        {
            _traversalContext = traversalContext;
        }

        public void ChangeContactUsStatusToFalse(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContactUs> GetListContactUsByFalse()
        {
            var values = _traversalContext.ContactUses.Where(x => x.Status == false).ToList();
            return values;
        }

        public List<ContactUs> GetListContactUsByTrue()
        {
            var values = _traversalContext.ContactUses.Where(x => x.Status == true).ToList();
            return values;
        }
    }
}
