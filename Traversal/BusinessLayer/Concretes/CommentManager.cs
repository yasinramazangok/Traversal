using AutoMapper;
using Traversal.BusinessLayer.Abstracts;
using Traversal.DataAccessLayer.Abstracts;
using Traversal.DTOLayer.AdminDTOs.CommentDtos;
using Traversal.EntityLayer.Concretes;

namespace Traversal.BusinessLayer.Concretes
{
    public class CommentManager : ICommentService
    {
        private readonly ICommentDal _commentDal;
        private readonly IMapper _mapper;

        public CommentManager(ICommentDal commentDal, IMapper mapper)
        {
            _commentDal = commentDal;
            _mapper = mapper;
        }

        public void Insert(Comment comment)
        {
            _commentDal.Insert(comment);
        }

        public void Update(Comment comment)
        {
            _commentDal.Update(comment);
        }

        public List<ListCommentDto> TGetCommentListByDestination()
        {
            return _mapper.Map<List<ListCommentDto>>(_commentDal.GetCommentListByDestination());
        }

        public List<ListCommentDto> TGetCommentListWithDestinationAndUser(int id)
        {
            return _mapper.Map<List<ListCommentDto>>(_commentDal.GetCommentListWithDestinationAndUser(id));
        }

        public void TDelete(int id)
        {
            var comment = _commentDal.GetById(id);
            _commentDal.Delete(comment);
        }

        public List<ListCommentDto> TGetList()
        {
            return _mapper.Map<List<ListCommentDto>>(_commentDal.GetList());
        }

        public CommentDto TGetById(int id)
        {
            return _mapper.Map<CommentDto>(_commentDal.GetById(id));
        }

        public void TInsert(object dto)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(object dto)
        {
            throw new NotImplementedException();
        }


    }
}
