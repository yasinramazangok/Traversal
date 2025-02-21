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
    public class EfContactUsDal : GenericRepository<ContactUs>, IContactUsDal
    {
        public void ChangeContactUsStatusToFalse(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContactUs> GetListContactUsByFalse()
        {
            using(var context=new TraversalContext())
            {
                var values = context.ContactUses.Where(x => x.Status == false).ToList();
                return values;
            }
        }

        public List<ContactUs> GetListContactUsByTrue()
        {
            using (var context = new TraversalContext())
            {
                var values = context.ContactUses.Where(x => x.Status == true).ToList();
                return values;
            }
        }
    }
}
