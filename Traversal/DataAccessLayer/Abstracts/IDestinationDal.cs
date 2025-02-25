using Traversal.EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traversal.DataAccessLayer.Abstracts
{
    public interface IDestinationDal : IGenericRepositoryDal<Destination>
    {
        public Destination GetDestinationWithGuide(int id);

        public List<Destination> GetRecentDestinations(int count = 4);

    }
}
