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
            _commentDal.InsertAsync(comment);
        }

        public void Update(Comment comment)
        {
            _commentDal.UpdateAsync(comment);
        }

        public List<ListCommentDto> TGetCommentListByDestination()
        {
            return _mapper.Map<List<ListCommentDto>>(_commentDal.GetCommentListByDestination());
        }

        public List<ListCommentDto> TGetCommentListWithDestinationAndUser(int id)
        {
            return _mapper.Map<List<ListCommentDto>>(_commentDal.GetCommentListWithDestinationAndUser(id));
        }

        public async Task<List<ListCommentDto>> TGetListAsync()
        {
            return _mapper.Map<List<ListCommentDto>>(_commentDal.GetListAsync());
        }

        public async Task<CommentDto> TGetByIdAsync(int id)
        {
            return _mapper.Map<CommentDto>(_commentDal.GetByIdAsync(id));
        }

        public async Task TInsertAsync(object dto)
        {
            throw new NotImplementedException();
        }

        public async Task TUpdateAsync(object dto)
        {
            throw new NotImplementedException();
        }

        public async Task TDeleteAsync(int id)
        {
            await _commentDal.DeleteAsync(id);
        }
    }
}
