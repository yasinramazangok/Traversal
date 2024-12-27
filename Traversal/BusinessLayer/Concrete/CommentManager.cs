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
    public class CommentManager : ICommentService
    {
        private readonly ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void Delete(Comment entity)
        {
            throw new NotImplementedException();
        }

        public Comment GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetCommentByDestinationId(int id)
        {
            return _commentDal.GetListByFilter(c => c.DestinationId == id);
        }

        public List<Comment> GetList()
        {
            throw new NotImplementedException();
        }

        public void Insert(Comment entity)
        {
            _commentDal.Insert(entity);
        }

        public void Update(Comment entity)
        {
            throw new NotImplementedException();
        }
    }
}
