using Traversal.EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traversal.DataAccessLayer.Abstracts
{
    public interface IGuideDal : IGenericRepositoryDal<Guide>
    {
        void ChangeGuideStatusToTrue(int id);

        void ChangeGuideStatusToFalse(int id);
    }
}
