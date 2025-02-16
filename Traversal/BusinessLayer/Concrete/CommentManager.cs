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

        public void Delete(Comment comment)
        {
            _commentDal.Delete(comment);
        }

        public Comment GetById(int id)
        {
            return _commentDal.GetById(id);
        }

        public List<Comment> GetCommentByDestinationId(int id)
        {
            return _commentDal.GetListByFilter(comment => comment.DestinationId == id);
        }

        public List<Comment> GetList()
        {
            return _commentDal.GetList();
        }

        public List<Comment> GetListCommentByDestination()
        {
            return _commentDal.GetListCommentByDestination();
        }

        public void Insert(Comment comment)
        {
            _commentDal.Insert(comment);
        }

        public List<Comment> GetListCommentWithDestinationAndUser(int id)
        {
            return _commentDal.GetListCommentWithDestinationAndUser(id);
        }

        public void Update(Comment comment)
        {
            _commentDal.Update(comment);
        }
    }
}
