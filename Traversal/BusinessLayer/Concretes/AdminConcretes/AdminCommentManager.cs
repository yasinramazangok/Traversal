using AutoMapper;
using Traversal.BusinessLayer.Abstracts;
using Traversal.DataAccessLayer.Abstracts;
using Traversal.DTOLayer.AdminDTOs.CommentDtos;
using Traversal.EntityLayer.Concretes;

namespace Traversal.BusinessLayer.Concretes
{
    public class AdminCommentManager : IAdminCommentService
    {
        private readonly ICommentDal _commentDal;
        private readonly IMapper _mapper;

        public AdminCommentManager(ICommentDal commentDal, IMapper mapper)
        {
            _commentDal = commentDal;
            _mapper = mapper;
        }

        public async Task TDeleteAsync(int id)
        {
            await _commentDal.DeleteAsync(id);
        }

        public Task<object> TGetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public List<ListCommentDto> TGetCommentListByDestination()
        {
            return _mapper.Map<List<ListCommentDto>>(_commentDal.GetCommentListByDestination());
        }

        public Task<List<ListCommentDto>> TGetListAsync()
        {
            throw new NotImplementedException();
        }

        public Task TInsertAsync(object dto)
        {
            throw new NotImplementedException();
        }

        public Task TUpdateAsync(object dto)
        {
            throw new NotImplementedException();
        }


        //public List<ListCommentDto> TGetCommentListByDestination()
        //{
        //    return _mapper.Map<List<ListCommentDto>>(_commentDal.GetCommentListByDestination());
        //}

        //public async Task TDeleteAsync(int id)
        //{
        //    await _commentDal.DeleteAsync(id);
        //}
    }
}
