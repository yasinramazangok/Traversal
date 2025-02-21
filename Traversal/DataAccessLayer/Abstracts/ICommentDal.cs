using Traversal.EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traversal.DataAccessLayer.Abstracts
{
    public interface ICommentDal : IGenericDal<Comment>
    {
        public List<Comment> GetListCommentByDestination();

        public List<Comment> GetListCommentWithDestinationAndUser(int id);
    }
}
