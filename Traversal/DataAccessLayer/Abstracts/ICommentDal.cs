using Traversal.EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traversal.DataAccessLayer.Abstracts
{
    public interface ICommentDal : IGenericRepositoryDal<Comment>
    {
        public List<Comment> GetCommentListByDestination();
        public List<Comment> GetCommentListWithDestinationAndUser(int id);
    }
}
